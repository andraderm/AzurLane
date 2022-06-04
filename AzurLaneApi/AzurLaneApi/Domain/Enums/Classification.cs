using System.ComponentModel;

namespace AzurLaneApi.Domain.Enums
{
    public enum Classification
    {
        [Description("Unknown")]
        Unknown = 0,

        [Description("Destroyer")]
        Destroyer = 1,

        [Description("Light Cruiser")]
        LightCruiser = 2,

        [Description("Heavy Cruiser")]
        HeavyCruiser = 3,

        [Description("Large Cruiser")]
        LargeCruiser = 4,

        [Description("Monitor")]
        Monitor = 5,

        [Description("Battleship")]
        Battleship = 6,

        [Description("Battlecruiser")]
        Battlecruiser = 7,

        [Description("Aviation Battleship")]
        AviationBattleship = 8,

        [Description("Aircraft Carrier")]
        AircraftCarrier = 9,

        [Description("Light Aircraft Carrier")]
        LightAircraftCarrier = 10,

        [Description("Submarine")]
        Submarine = 11,

        [Description("Submarine Carrier")]
        SubmarineCarrier = 12,

        [Description("Repair Ship")]
        RepairShip = 13,

        [Description("Munition Ship")]
        MunitionShip = 14,

        [Description("Guided-Missile Destroyer")]
        GuidedMissileDestroyer = 15
    }
}
