using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    public class MyLogImpl : LogImpl, IMyLog
    {

        private readonly static Type ThisDeclaringType = typeof(MyLogImpl);

        /// <summary>
        /// The fully qualified name of this declaring type not the type of any subclass.
        /// </summary>
        /// <param name="logger"></param>
        public MyLogImpl(ILogger logger)
            : base(logger)
        {
        }

        #region Implementation fo IMyLog



        public void Debug(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName)
        {
            Debug(operatorID, operand, actionType, message,

 ip, browser, machineName, null);
        }

        public void Debug(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t)
        {
            if (this.IsDebugEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository,
                    Logger.Name, Level.Info, message, t);

                loggingEvent.Properties["Operator"] = operatorID;
                loggingEvent.Properties["Operand"] = operand;
                loggingEvent.Properties["IP"] = ip;
                loggingEvent.Properties["Browser"] = browser;
                loggingEvent.Properties["MachineName"] = machineName;
                Logger.Log(loggingEvent);
            }
        }
        public void Info(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName)
        {
            Info(operatorID, operand, actionType, message, ip, browser, machineName, null);
        }
        public void Info(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, System.Exception t)
        {
            if (this.IsInfoEnabled)
            {
                LoggingEvent loggingEvent =

                new LoggingEvent(ThisDeclaringType, Logger.Repository,

                Logger.Name, Level.Info, message, t);

                loggingEvent.Properties["Operator"] = operatorID;

                loggingEvent.Properties["Operand"] = operand;

                loggingEvent.Properties["ActionType"] = actionType;

                loggingEvent.Properties["IP"] = ip;

                loggingEvent.Properties["Browser"] = browser;

                loggingEvent.Properties["MachineName"] = machineName;

                Logger.Log(loggingEvent);
            }
        }
        public void Warn(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName)
        {

            Warn(operatorID, operand, actionType, message, ip, browser, machineName, null);

        }

        public void Warn(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, System.Exception t)
        {
            if (this.IsWarnEnabled)
            {
                LoggingEvent loggingEvent =

new LoggingEvent(ThisDeclaringType, Logger.Repository,

Logger.Name, Level.Info, message, t);

                loggingEvent.Properties["Operator"] = operatorID;

                loggingEvent.Properties["Operand"] = operand;

                loggingEvent.Properties["ActionType"] = actionType;

                loggingEvent.Properties["IP"] = ip;

                loggingEvent.Properties["Browser"] = browser;

                loggingEvent.Properties["MachineName"] = machineName;

                Logger.Log(loggingEvent);
            }
        }

        public void Error(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName)
        {

            Error(operatorID, operand, actionType, message, ip, browser, machineName, null);

        }

        public void Error(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, System.Exception t)
        {
            if (this.IsErrorEnabled)
            {
                LoggingEvent loggingEvent =

new LoggingEvent(ThisDeclaringType, Logger.Repository,

Logger.Name, Level.Info, message, t);

                loggingEvent.Properties["Operator"] = operatorID;

                loggingEvent.Properties["Operand"] = operand;

                loggingEvent.Properties["ActionType"] = actionType;

                loggingEvent.Properties["IP"] = ip;

                loggingEvent.Properties["Browser"] = browser;

                loggingEvent.Properties["MachineName"] = machineName;

                Logger.Log(loggingEvent);
            }
        }
        public void Fatal(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName)
        {

            Fatal(operatorID, operand, actionType, message, ip, browser, machineName, null);

        }

        public void Fatal(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, System.Exception t)
        {

            if (this.IsFatalEnabled)
            {

                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Info, message, t);

                loggingEvent.Properties["Operator"] = operatorID;

                loggingEvent.Properties["Operand"] = operand;

                loggingEvent.Properties["ActionType"] = actionType;

                loggingEvent.Properties["IP"] = ip;

                loggingEvent.Properties["Browser"] = browser;

                loggingEvent.Properties["MachineName"] = machineName;

                Logger.Log(loggingEvent);

            }

        }
        #endregion

    }
}
