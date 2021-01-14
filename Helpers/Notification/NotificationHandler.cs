using System;
using System.Collections.Generic;
using Solid.Helpers.Loggers;
using Solid.Helpers.Loggers.FactoryMethod;
using Solid.Helpers.Utils.Enums;

namespace Solid.Helpers.Notification
{
    public class NotificationHandler
    {
        public IDictionary<ErrorCriticalityLevelEnum, Func<LoggerCreator>> LoggerCreators { get; set; }

        public NotificationHandler()
        {
            LoggerCreators = new Dictionary<ErrorCriticalityLevelEnum, Func<LoggerCreator>>
            {
                {ErrorCriticalityLevelEnum.GenericError, () => GetGenericLoggerCreator()},
                {ErrorCriticalityLevelEnum.CriticalError, () => GetCriticalLoggerCreator()}
            };
        }


        public LoggerCreator GetGenericLoggerCreator()
        {
            return new GenericErrorLoggerCreator();
        }

        public LoggerCreator GetCriticalLoggerCreator()
        {
            return new CriticalErrorLoggerCreator();
        }
    }
}