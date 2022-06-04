namespace AzurLaneApi.Domain.Entities
{
    public class BaseStatus : BaseEntity
    {
        public double Health { get; set; }
        public double Firepower { get; set; }
        public double Torpedo { get; set; }
        public double Aviation { get; set; }
        public double AntiAir { get; set; }
        public double Reload { get; set; }
        public double Evasion { get; set; }
        public double Speed { get; set; }
        public double Accuracy { get; set; }
        public double Luck { get; set; }
        public double AntiSubmarineWarfare { get; set; }
        public double OilConsumption { get; set; }
        public double Oxygen { get; set; }
        public double Ammunition { get; set; }
        public double Power { get; set; }

        public BaseStatus() : base() { }
    }
}
