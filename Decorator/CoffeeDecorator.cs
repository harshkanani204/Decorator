/******************************************************************************
 * Filename    = CoffeeDecorator.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Decorator
 *
 * Description = CoffeeDecorator is here.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// CoffeeDecorator implements ICoffee interface. It has Constructor and to the constructor, we need to pass the coffee object which we want to decorate.
    /// </summary>
    public abstract class CoffeeDecorator : ICoffee
    {
        
        protected ICoffee coffee;

        /// <summary>
        /// Constructor for CoffeeDecorator
        /// </summary>
        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        /// <summary>
        /// Implements the methods of the Interface.
        /// </summary>
        public virtual string MakeCoffee()
        {
            return coffee.MakeCoffee();
        }

    }
}
