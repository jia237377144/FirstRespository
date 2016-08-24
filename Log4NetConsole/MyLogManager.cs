using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    public class MyLogManager
    {
        #region Static Member Variables

        /// <summary>
        /// The wrapper map to use to hold the <see cref="EventIDLogImpl"> objects
        /// </summary>
        private static readonly WrapperMap s_wrapperMap = new WrapperMap(new WrapperCreationHandler(WrapperCreationHandler));



        #endregion

        /// <summary>
        /// Private constructor to prevent object creation
        /// </summary>
        public MyLogManager() { }



        #region Type Specific Manager Methods


        /// <summary>
        /// 如果name的logger存在，那就返回
        /// </summary>
        /// <param name="name">如果名称为name的logger存在，就将它返回</param>
        /// <returns></returns>
        public static IMyLog Exists(string name)
        {
            return Exists(Assembly.GetCallingAssembly(), name);
        }
        /// <summary>
        /// 如果name的logger存在，那就返回
        /// </summary>
        /// <param name="domain">the domain to lookup in </param>
        /// <param name="name">the fully qualified logger name to look for</param>
        /// <returns>The logger found,or null</returns>
        public static IMyLog Exists(string domain,string name)
        {
            return WrapLogger(LoggerManager.Exists(domain, name));
        }
        
        /// <summary>
        /// 如果name的logger存在，那就返回
        /// </summary>
        /// <param name="assembly">the assembly to use to lookup the domain</param>
        /// <param name="name">The fully qualified logger name to look for</param>
        /// <returns>The logger found,or null</returns>
        public static IMyLog Exists(Assembly assembly, string name)
        {
            return WrapLogger(LoggerManager.Exists(assembly, name));
        }

        /// <summary>
        /// Returns all the currently defined loggers in the default domain.
        /// </summary>
        /// <returns></returns>
        public static IMyLog[] GetCurrentLoggers()
        {
            return GetCurrentLoggers(Assembly.GetCallingAssembly());
        }
        /// <summary>
        /// Returns all the currently defined loggers in the specified domain.
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public static IMyLog[] GetCurrentLoggers(string domain)
        {
            return WrapLoggers(LoggerManager.GetCurrentLoggers(domain));
        }
        /// <summary>
        /// Returns all the currently defined loggers in the specified assembly's domain.
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static IMyLog[] GetCurrentLoggers(Assembly assembly)
        {
            return WrapLoggers(LoggerManager.GetCurrentLoggers(assembly));
        }
        /// <summary>
        /// 返回logger，如果name的logger存在就返回，不存在就创建
        /// </summary>
        /// <param name="name">Retrieve a logger named as the <paramref name="name"/></param>
        /// <returns></returns>
        public static IMyLog GetLogger(string name)
        {
            return GetLogger(Assembly.GetCallingAssembly(), name);
        }
        /// <summary>
        /// 返回logger，如果name的logger存在就返回，不存在就创建
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IMyLog GetLogger(string domain, string name)
        {
            return WrapLogger(LoggerManager.GetLogger(domain, name));
        }
        /// <summary>
        /// Retrieve or create a named logger.
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IMyLog GetLogger(Assembly assembly, string name)
        {

            return WrapLogger(LoggerManager.GetLogger(assembly, name));

        }
        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IMyLog GetLogger(Type type)
        {

            return GetLogger(Assembly.GetCallingAssembly(), type.FullName);

        }
        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IMyLog GetLogger(string domain, Type type)
        {

            return WrapLogger(LoggerManager.GetLogger(domain, type));

        }
        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IMyLog GetLogger(Assembly assembly, Type type)
        {

            return WrapLogger(LoggerManager.GetLogger(assembly, type));

        }
        #endregion

        #region Extension Handlers

        private static IMyLog WrapLogger(ILogger logger)
        {
            return (IMyLog)s_wrapperMap.GetWrapper(logger);
        }

        private static IMyLog[] WrapLoggers(ILogger[] loggers)
        {
            IMyLog[] results = new IMyLog[loggers.Length];
            for (int i = 0; i < loggers.Length; i++)
            {
                results[i] = WrapLogger(loggers[i]);
            }
            return results;
        }

        private static ILoggerWrapper WrapperCreationHandler(ILogger logger)
        {

            return new MyLogImpl(logger);

        }

        #endregion
    }
}
