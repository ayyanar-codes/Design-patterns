using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbsctractFactory.ConCreateClass;

namespace AbstractFactory.AbsctractFactory
{
    internal class AssetFactory
    {
        public static Asset GetAsset(string employeeTye)
        {
            Asset asset;
            switch(employeeTye)
            {
                case "Ft":
                    asset = new ExecutiveAsset();
                    break;
                case "CT":
                    asset=new SeniorAsset();
                    break;
                case "JR":
                    asset = new JuniorAsset();
                    break;
                default:
                    asset = new ExecutiveAsset();
                    break;
            }
            return asset;
        }
    }
}
