using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override string MakeCoffee()
        {
            return coffee.MakeCoffee() + AddMilk();
        }
        private string AddMilk()
        {
            return ", Milk added";
        }
    }
}
