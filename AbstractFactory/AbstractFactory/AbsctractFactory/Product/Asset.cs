using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbsctractFactory
{
    abstract class Asset
    {
        public IMobile mobile;
        public ISystem system;
    }
}
