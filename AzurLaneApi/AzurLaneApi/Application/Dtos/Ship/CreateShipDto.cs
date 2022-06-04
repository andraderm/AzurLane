using AzurLaneApi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AzurLaneApi.Application.Dtos.Ship
{
    public class CreateShipDto : BaseStatusDto
    {
        [Required]
        public string Name { get; set; }
        public string Illustrator { get; set; }
        public string VoiceActor { get; set; }
        public string Faction { get; set; }
        public string ShipClass { get; set; }
        public bool Flagship { get; set; }
        public DateTime ConstructionTime { get; set; }
        public ArmorType ArmorType { get; set; }
        public Rarity Rarity { get; set; }
        public Classification ShipType { get; set; }
        public ShipCombatPosition CombatPosition { get; set; }

        public CreateShipDto() : base()
        {
            Name = string.Empty;
            Illustrator = string.Empty;
            VoiceActor = string.Empty;
            Faction = string.Empty;
            ShipClass = string.Empty;
            Flagship = false;
        }
    }
}
