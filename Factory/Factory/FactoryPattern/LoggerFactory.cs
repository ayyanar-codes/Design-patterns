using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractMethod.FactoryPattern
{
    internal class LoggerFactory
    {
        public static ILogger GetLogger()
        {
            ILogger logger;
            string LoggerType = Convert.ToString(ConfigurationSettings.AppSettings["Logger"]);

            switch (LoggerType)
            {
                case "DB":
                    logger = new DBLogger();
                    break;
                case "FILE":
                    logger = new FileLogger();
                    break;
                case "EV":
                    logger = new EventViewLogger();
                    break;
                default:
                    logger = new DBLogger();
                    break;
            }
            return logger;
        }
}

    
}
