using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbsctractFactory.ConCreateClass
{
    class ExecutiveAsset : Asset
    {
        public ExecutiveAsset()
        {
            mobile = new IPhone();
            system = new Mac();
            Console.WriteLine("Apple laptop and Iphone assgined");
        }
    }
}
