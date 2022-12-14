using CashMastersPOS.Logic;

namespace TestProject1
{
    [TestFixture]
    public class UnitTestLogic
    {        
        [Test]
        public void USChange_Total499Payed500_ReturnsListWith1Dollar()
        {
            //Arrange

            ProcessChange USChangeOperation = new ProcessChange();
            double totalToPay = 499.00;
            double totalPayedWith = 500.00;

            //Act
            USChangeOperation.calculateUS(totalToPay, totalPayedWith);
            var listofChange = USChangeOperation.USChange;



            //Assert
            Assert.IsTrue(listofChange.ContainsKey(1.ToString()));
        }

        [Test]
        public void USChange_Total499Payed500_ReturnsListWith50centsTrue()
        {
            //Arrange

            ProcessChange USChangeOperation = new ProcessChange();
            double totalToPay = 499.00;
            double totalPayedWith = 500.00;

            //Act
            USChangeOperation.calculateUS(totalToPay, totalPayedWith);
            var listofChange = USChangeOperation.USChange;



            //Assert
            Assert.IsTrue(listofChange.ContainsKey(10.ToString()));
        }

        [Test]
        public void USChange_Total499Payed500_ReturnsListWith99centsTrue()
        {
            //Arrange

            ProcessChange USChangeOperation = new ProcessChange();
            double totalToPay = 49.01;
            double totalPayedWith = 50.00;

            //Act
            USChangeOperation.calculateUS(totalToPay, totalPayedWith);
            var listofChange = USChangeOperation.USChange;



            //Assert
            Assert.IsTrue(listofChange.ContainsKey(0.01.ToString()) && listofChange.ContainsKey(0.05.ToString()));
        }
    }
}