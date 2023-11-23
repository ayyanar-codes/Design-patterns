using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbsctractFactory.ConCreateClass
{
    internal class SeniorAsset : Asset
    {
        public SeniorAsset() 
        {
            mobile = new Samsung();
            system=new Mac();
            Console.WriteLine("Mac laptp and samsung mobile assigned");
        }
    }
}
