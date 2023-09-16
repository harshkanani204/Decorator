using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override string MakeCoffee()
        {
            return coffee.MakeCoffee() + AddSugar();
        }
        private string AddSugar()
        {
            return ", Sugar added";
        }
    }
    
}
