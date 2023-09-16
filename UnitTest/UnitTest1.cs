using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BlackCoffee coffeeObject = new BlackCoffee();

            string blackCoffee = coffeeObject.MakeCoffee();
            Assert.AreEqual(blackCoffee, "Black Coffee");
            Console.WriteLine("Black Coffee was made\n");

            CoffeeDecorator milkCoffeeDecorator = new MilkDecorator(coffeeObject);
            string milkCoffee = milkCoffeeDecorator.MakeCoffee();
            Assert.AreEqual("Black Coffee, Milk Added", milkCoffee);
            Console.WriteLine("Milk Coffee was made using MilkCoffeeDecorator\n");

            CoffeeDecorator sugarCoffeeDecorator = new SugarDecorator(coffeeObject);
            string sugarCoffee = sugarCoffeeDecorator.MakeCoffee();
            Assert.AreEqual(sugarCoffee, "Black Coffee, Sugar Added");
            Console.WriteLine("Sugar Coffee was made using SugarCoffeeDecorator\n");

            CoffeeDecorator sugarAndMilkCoffeeDecorator = new SugarDecorator(milkCoffeeDecorator);
            string sugarAndMilkCoffee = sugarAndMilkCoffeeDecorator.MakeCoffee();
            Assert.AreEqual(sugarAndMilkCoffee, "Black Coffee, Milk Added, Sugar Added");
            Console.WriteLine("Sugar And Milk Coffee was made using SugarCoffeeDecorator And MilkCoffeeDecorator\n");

        }
    }
}