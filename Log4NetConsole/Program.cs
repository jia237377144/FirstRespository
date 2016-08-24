using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4NetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("ReflectionLayout");

            try
            {

                log.Debug(new LogMessage(1, "操作对象：0", 1, "这是四个参数测试", "192.168.1.1", "MyComputer", "Maxthon(MyIE2)Fans"));

            }

            catch (Exception ec)
            {

                log.Error(new LogMessage(1,"操作对象：0",1,"这是全部参数测试","192.168.1.1","MyComputer","Maxthon(MyIE2)Fans"),ec);

            }
            Console.ReadLine();
        }
    }
}
