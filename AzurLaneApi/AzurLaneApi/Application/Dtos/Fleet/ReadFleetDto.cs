using AzurLaneApi.Application.Dtos.Ship;

namespace AzurLaneApi.Application.Dtos.Fleet
{
    public class ReadFleetDto : BaseDto
    {
        public string Name { get; set; }
        public ICollection<ReadShipDto> Ships { get; set; }

        public ReadFleetDto() : base()
        {
            Name = string.Empty;
            Ships = new List<ReadShipDto>();
        }
    }
}
