using MediCareInClass;

namespace MedicareTest
{
    [TestClass]
    public class MediTest
    {
        [TestMethod]
        public void SubsidisedExpense_0_1045()
        {
            //Arrange

            MediCare m = new MediCare();
            double expense = 500;
            double expectedResult = 0;

            //Act
            double result = m.SubsidisedExpense(expense);

            //Assert
            Assert.AreEqual(expectedResult, result, 0.05);
        }


        [TestMethod]
        public void SubsidisedExpense_belowZero()
        {
            //Arrange

            MediCare m = new MediCare();
            double expense = -1;
            

            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                m.SubsidisedExpense(expense);
            });
        }

    }
}