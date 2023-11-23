using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbsctractFactory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asset asset = AssetFactory.GetAsset("FT");
            Console.ReadKey();
        }
    }
}
