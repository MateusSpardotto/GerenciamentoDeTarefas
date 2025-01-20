using System.ComponentModel;

namespace Domain.Enums
{
    public enum Status
    {
        [Description("Pending")]
        Pending,
        [Description("InProgress")]
        InProgress,
        [Description("Completed")]
        Completed
    }
}
