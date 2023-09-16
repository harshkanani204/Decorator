/******************************************************************************
 * Filename    = UnitTest1.cs
 *
 * Author      = Harsh Kanani
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = UnitTests
 *
 * Description = Unit tests for the decorator pattern.
 *****************************************************************************/

using Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDecorator
{
    /// <summary>
    /// Unit Test for the Decorator pattern.
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Method for Testing the Decorator pattern.
        /// </summary>
        /// It contains different cases where MilkDecorator or SugarDecorator or both are called and checked if the output matches.
        [TestMethod]
        public void TestMethod1()
        {
            BlackCoffee coffeeObject = new();

            /// Checking MakeCoffee()
            string blackCoffee = coffeeObject.MakeCoffee();
            Assert.AreEqual(blackCoffee, "Black Coffee");
            Console.WriteLine("Black Coffee was made\n");

            /// Checking MilkDecorator
            CoffeeDecorator milkCoffeeDecorator = new MilkDecorator(coffeeObject);
            string milkCoffee = milkCoffeeDecorator.MakeCoffee();
            Assert.AreEqual("Black Coffee, Milk added", milkCoffee);
            Console.WriteLine("Milk Coffee was made using MilkCoffeeDecorator\n");

            /// Checking SugarDecorator
            CoffeeDecorator sugarCoffeeDecorator = new SugarDecorator(coffeeObject);
            string sugarCoffee = sugarCoffeeDecorator.MakeCoffee();
            Assert.AreEqual(sugarCoffee, "Black Coffee, Sugar added");
            Console.WriteLine("Sugar Coffee was made using SugarCoffeeDecorator\n");

            /// Checking SugarDecorator and MilkDecorator together
            CoffeeDecorator sugarAndMilkCoffeeDecorator = new SugarDecorator(milkCoffeeDecorator);
            string sugarAndMilkCoffee = sugarAndMilkCoffeeDecorator.MakeCoffee();
            Assert.AreEqual(sugarAndMilkCoffee, "Black Coffee, Milk added, Sugar added");
            Console.WriteLine("Sugar And Milk Coffee was made using SugarCoffeeDecorator And MilkCoffeeDecorator\n");
        }
    }
}
