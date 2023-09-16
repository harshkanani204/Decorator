/******************************************************************************
 * Filename    = ICoffee.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Decorator
 *
 * Description = Interface for the Coffee.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Interface for the Coffee.
    /// </summary>
    public interface ICoffee
    {
        /// <summary>
        /// Interface contains one function MakeCoffee which will make a coffee. It has to be implemented.
        /// </summary>
        string MakeCoffee();
    }
}
