/******************************************************************************
 * Filename    = SugarDecorator.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Decorator
 *
 * Description = Similar to MilkDecorator, SugarDecorator adds functionalities to the Coffee i.e. adds sugar
 *****************************************************************************/
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// SugarDecorator inherits CoffeeDecorator and adds functionalities to the base i.e. Sugar
    /// </summary>
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        /// <summary>
        /// SugarDecorator overrides MakeCoffee method and adds sugar to original MakeCoffee method.
        /// </summary>
        public override string MakeCoffee()
        {
            return coffee.MakeCoffee() + AddSugar();
        }

        /// <summary>
        /// Function to add Sugar.
        /// </summary>
        private string AddSugar()
        {
            return ", Sugar added";
        }
    }
    
}
