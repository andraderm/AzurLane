using System.ComponentModel;

namespace AzurLaneApi.Domain.Enums
{
    public enum Rarity
    {
        [Description("Unknown")]
        Unknown = 0,

        [Description("Normal")]
        Normal = 1,

        [Description("Rare")]
        Rare = 2,

        [Description("Elite")]
        Elite = 3,

        [Description("Super Rare")]
        SuperRare = 4,

        [Description("Ultra Rare")]
        UltraRare = 5
    }
}
