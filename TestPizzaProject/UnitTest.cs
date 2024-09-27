using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaApp;

namespace TestPizzaProject
{
    [TestClass]
    public class TestDecorator
    {
        [TestMethod]
        public void TestPizzaMargaritta()
        {
            //Arrange
            PizzaMargaritta pm = new PizzaMargaritta();

            //Act: No action

            //Assert
            Assert.AreEqual(pm.Price, 50);
            Assert.AreEqual(pm.Ingredients, "Tomatoes and cheese");
            Assert.AreEqual($"{pm}", "Pizza with Tomatoes and cheese");
        }

        [TestMethod]
        public void TestWithOneDecorator()
        {
            //Arrange
            PizzaMargaritta pm = new PizzaMargaritta();
            BaconDecorator bd = new BaconDecorator(pm);

            //Act: No action

            //Assert
            Assert.AreEqual(pm.Price, 50);
            Assert.AreEqual(pm.Ingredients, "Tomatoes and cheese");
            Assert.AreEqual($"{pm}", "Pizza with Tomatoes and cheese");

            Assert.AreEqual(bd.Price, 57);
            Assert.AreEqual(bd.Ingredients, "Tomatoes and cheese and Bacon");
            Assert.AreEqual($"{bd}", "Pizza with Tomatoes and cheese and Bacon");
        }

        [TestMethod]
        public void TestWithMoreDecorators()
        {
            //Arrange
            PizzaMargaritta pm = new PizzaMargaritta();
            BaconDecorator bd = new BaconDecorator(pm);
            ChilliDecorator cd = new ChilliDecorator(bd);
            PepperoniDecorator pd = new PepperoniDecorator(cd);

            //Act: No specific

            //Assert
            Assert.AreEqual(pm.Price, 50);
            Assert.AreEqual(pm.Ingredients, "Tomatoes and cheese");
            Assert.AreEqual($"{pm}", "Pizza with Tomatoes and cheese");

            Assert.AreEqual(bd.Price, 57);
            Assert.AreEqual(bd.Ingredients, "Tomatoes and cheese and Bacon");
            Assert.AreEqual($"{bd}", "Pizza with Tomatoes and cheese and Bacon");

            Assert.AreEqual(cd.Price, 62);
            Assert.AreEqual(cd.Ingredients, "Tomatoes and cheese and Bacon and Chilli");
            Assert.AreEqual($"{cd}", "Pizza with Tomatoes and cheese and Bacon and Chilli");

            Assert.AreEqual(pd.Price, 67);
            Assert.AreEqual(pd.Ingredients, "Tomatoes and cheese and Bacon and Chilli and Pepperoni");
            Assert.AreEqual($"{pd}", "Pizza with Tomatoes and cheese and Bacon and Chilli and Pepperoni");
        }
    }

    [TestClass]
    public class TestFactory
    {
        [TestMethod]
        public void TestWithNullAdditionals()
        {
            //Arrange
            PizzaFactory pf = new PizzaFactory();
            string[] additionals = null;

            //Act
            AbstractPizza pizza = pf.MakePizza(additionals);

            //Assert
            Assert.AreEqual(pizza.Price, 50);
            Assert.AreEqual(pizza.Ingredients, "Tomatoes and cheese");
            Assert.AreEqual($"{pizza}", "Pizza with Tomatoes and cheese");
        }

        [TestMethod]
        public void TestWithNoAdditionals()
        {
            //Arrange
            PizzaFactory pf = new PizzaFactory();
            string[] additionals = new string[0];

            //Act
            AbstractPizza pizza = pf.MakePizza(additionals);

            //Assert
            Assert.AreEqual(pizza.Price, 50);
            Assert.AreEqual(pizza.Ingredients, "Tomatoes and cheese");
            Assert.AreEqual($"{pizza}", "Pizza with Tomatoes and cheese");
        }

        [TestMethod]
        public void TestWithOneAdditional()
        {
            //Arrange
            PizzaFactory pf = new PizzaFactory();
            string[] additionals = { "Bacon" };

            //Act
            AbstractPizza pizza = pf.MakePizza(additionals);

            //Assert
            Assert.AreEqual(pizza.Price, 57);
            Assert.AreEqual(pizza.Ingredients, "Tomatoes and cheese and Bacon");
            Assert.AreEqual($"{pizza}", "Pizza with Tomatoes and cheese and Bacon");
        }

        [TestMethod]
        public void TestWithMoreAdditionals()
        {
            //Arrange
            PizzaFactory pf = new PizzaFactory();
            string[] additionals = { "Bacon", "Chilli", "Pepperoni" };

            //Act
            AbstractPizza pizza = pf.MakePizza(additionals);

            //Assert
            Assert.AreEqual(pizza.Price, 67);
            Assert.AreEqual(pizza.Ingredients, "Tomatoes and cheese and Bacon and Chilli and Pepperoni");
            Assert.AreEqual($"{pizza}", "Pizza with Tomatoes and cheese and Bacon and Chilli and Pepperoni");
        }
    }
}
