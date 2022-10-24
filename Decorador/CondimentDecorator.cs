using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public override abstract string getDescription();
    }
}
