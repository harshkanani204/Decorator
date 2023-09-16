/******************************************************************************
 * Filename    = BlackCoffee.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Decorator
 *
 * Description = It implements the ICoffee interface's methods.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// BlackCoffee class implements ICoffee interface.
    /// </summary>
    public class BlackCoffee : ICoffee
    {
        /// <summary>
        /// When MakeCoffee() is called it'll return a string saying "Black Coffee".
        /// </summary>
        public string MakeCoffee()
        {
            return "Black Coffee";
        }
    }
}
