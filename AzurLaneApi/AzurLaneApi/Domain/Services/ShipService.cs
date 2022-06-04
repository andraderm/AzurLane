using AzurLaneApi.Domain.Data;
using AzurLaneApi.Domain.Entities;
using AzurLaneApi.Domain.Interfaces;

namespace AzurLaneApi.Domain.Services
{
    public class ShipService : BaseService<Ship>, IShipService
    {
        public ShipService(AppDbContext context) : base(context)
        {

        }
    }
}
