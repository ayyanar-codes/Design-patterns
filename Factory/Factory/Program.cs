using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryAbstractMethod.FactoryPattern;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.GetLogger();
            logger.WriteMessage("Hi all");
            Console.ReadKey();
        }
    }
}
