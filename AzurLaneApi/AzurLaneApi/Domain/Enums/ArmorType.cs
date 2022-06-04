using System.ComponentModel;

namespace AzurLaneApi.Domain.Enums
{
    public enum ArmorType
    {
        [Description("Light")]
        Light = 0,

        [Description("Medium")]
        Medium = 1,

        [Description("Heavy")]
        Heavy = 2
    }
}
