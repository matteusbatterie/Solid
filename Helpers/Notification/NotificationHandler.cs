using System;
using System.Collections.Generic;
using Solid.Helpers.Loggers;
using Solid.Helpers.Loggers.FactoryMethod;
using Solid.Helpers.Utils.Enums;

namespace Solid.Helpers.Notification
{
    public class NotificationHandler
    {
        public IDictionary<ErrorCriticalityLevelEnum, Func<ErrorLoggerCreator>> LoggerCreators { get; set; }

        public NotificationHandler()
        {
            LoggerCreators = new Dictionary<ErrorCriticalityLevelEnum, Func<ErrorLoggerCreator>>
            {
                {ErrorCriticalityLevelEnum.GenericError, () => GetGenericLoggerCreator()},
                {ErrorCriticalityLevelEnum.CriticalError, () => GetCriticalLoggerCreator()}
            };
        }


        public ErrorLoggerCreator GetGenericLoggerCreator()
        {
            return new GenericErrorLoggerCreator();
        }

        public ErrorLoggerCreator GetCriticalLoggerCreator()
        {
            return new CriticalErrorLoggerCreator();
        }
    }
}
