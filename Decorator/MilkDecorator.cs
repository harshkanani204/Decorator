/******************************************************************************
 * Filename    = MilkDecorator.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Decorator
 *
 * Description = MilkDecorator adds functionalities to the Coffee i.e. adds milk
 *****************************************************************************/
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// MilkDecorator inherits CoffeeDecorator and adds functionalities to the base i.e. Milk
    /// </summary>
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        /// <summary>
        /// MilkDecorator overrides MakeCoffee method and adds milk to original MakeCoffee method.
        /// </summary>
        public override string MakeCoffee()
        {
            return coffee.MakeCoffee() + AddMilk();
        }

        /// <summary>
        /// Function to add Milk.
        /// </summary>
        private string AddMilk()
        {
            return ", Milk added";
        }
    }
}
