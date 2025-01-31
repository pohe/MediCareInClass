using MediCareInClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicareTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestClass]
        public class CalculatorTests
        {
            [TestMethod]
            public void TestAdd()
            {
                Calculator calc = new Calculator();
                Assert.AreEqual(5, calc.Add(2, 3));
            }

            [TestMethod]
            public void TestSubtract()
            {
                Calculator calc = new Calculator();
                Assert.AreEqual(1, calc.Subtract(3, 2));
            }

            [TestMethod]
            public void TestMultiply()
            {
                Calculator calc = new Calculator();
                Assert.AreEqual(6, calc.Multiply(2, 3));
            }

            [TestMethod]
            public void TestDivide()
            {
                Calculator calc = new Calculator();
                Assert.AreEqual(2, calc.Divide(6, 3));
            }
        }



        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act 
            calc.Divide(6, 0);

            //Assert
        }
    }
}
