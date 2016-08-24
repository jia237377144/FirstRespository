using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    public class LogMessage
    {


        public LogMessage(int operatorID,string operand,int ActionType,string message,string ip,string machineName,string browser)
        {
            this.ActionType = ActionType;
            this.Operator = operatorID;
            this.Message = message;
            this.Operand = operand;
            this.IP = ip;
            this.Browser = browser;
            this.MachineName = machineName;
        }

        public int ActionType { get; set; }

        public int Operator { get; set; }

        public string Message { get; set; }

        public string Operand { get; set; }

        public string IP { get; set; }

        public string Browser { get; set; }

        public string MachineName { get; set; }
    }
}
