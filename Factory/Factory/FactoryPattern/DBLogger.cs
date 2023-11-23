﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstractMethod.FactoryPattern
{
    internal class DBLogger : ILogger
    {
        void ILogger.WriteMessage(string message)
        {
            Console.WriteLine("Informations are logged in Database: " + message);
        }
    }
}
