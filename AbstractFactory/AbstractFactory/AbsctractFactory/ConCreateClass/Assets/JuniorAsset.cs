using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbsctractFactory.ConCreateClass
{
    internal class JuniorAsset : Asset
    {
        public JuniorAsset()
        {
            mobile = new Samsung();
            system = new Dell();
            Console.WriteLine("Dell laptop and samsung assigned");
        }
    }
}
