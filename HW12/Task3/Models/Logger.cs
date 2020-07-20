using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace Task3
{
    public static class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger(typeof(Logger));
        private static readonly ILoggerRepository Repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

        public static void InitLogger()
        {
            XmlConfigurator.Configure(Repository, new FileInfo("log4net.config"));
        }
    }
}
