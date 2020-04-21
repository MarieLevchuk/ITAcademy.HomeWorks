using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace HW11
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static ILog Log
        {
            get { return log; }
        }
        public static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }
    }
}
