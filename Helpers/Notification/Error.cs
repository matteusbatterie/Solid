using Solid.Helpers.Utils.Enums;

namespace Solid.Helpers.Notification
{
    public class Error
    {
        public ErrorCriticalityLevelEnum Criticality { get; set; }
        public string Message { get; set; }
    }
}