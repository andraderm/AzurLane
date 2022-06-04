using AzurLaneApi.Application.Interfaces;
using AzurLaneApi.Application.Services;
using AzurLaneApi.Domain.Data;
using AzurLaneApi.Domain.Interfaces;
using AzurLaneApi.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Application Services
builder.Services.AddScoped<IShipApplicationService, ShipApplicationService>();

// Domain Services
builder.Services.AddScoped<IShipService, ShipService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
