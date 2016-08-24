﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    public interface IMyLog : ILog
    {
        void Debug(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName);

        void Debug(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t);

        void Info(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName);

        void Info(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t);

        void Warn(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName);

        void Warn(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t);

        void Error(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName);

        void Error(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t);



        void Fatal(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName);

        void Fatal(int operatorID, string operand, int actionType, object message, string ip, string browser, string machineName, Exception t);
    }
}
