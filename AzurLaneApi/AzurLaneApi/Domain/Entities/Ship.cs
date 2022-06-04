using AzurLaneApi.Domain.Enums;

namespace AzurLaneApi.Domain.Entities
{
    public class Ship : BaseStatus
    {
        public string Name { get; set; }
        public string Illustrator { get; set; }
        public string VoiceActor { get; set; }
        public string Faction { get; set; }
        public string ShipClass { get; set; }
        public byte[] Image { get; set; }
        public bool Flagship { get; set; }
        public DateTime ConstructionTime { get; set; }
        public ArmorType ArmorType { get; set; }
        public Rarity Rarity { get; set; }
        public Classification ShipType { get; set; }
        public ShipCombatPosition CombatPosition { get; set; }

        public Ship() : base()
        {
            Name = string.Empty;
            Illustrator = string.Empty;
            VoiceActor = string.Empty;
            Faction = string.Empty;
            ShipClass = string.Empty;
            Flagship = false;
            Image = new byte[0];
        }
    }
}
