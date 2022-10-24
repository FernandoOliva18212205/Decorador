using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    public class Wip : CondimentDecorator
    {
        public Wip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Wip";
        }

        public override double cost()
        {
            return beverage.cost() + .30;
        }
    }
}
