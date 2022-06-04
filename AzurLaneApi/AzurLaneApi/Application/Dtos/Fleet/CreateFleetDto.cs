namespace AzurLaneApi.Application.Dtos.Fleet
{
    public class CreateFleetDto : BaseDto
    {
        public string Name { get; set; }

        public CreateFleetDto() : base()
        {
            Name = string.Empty;
        }
    }
}
