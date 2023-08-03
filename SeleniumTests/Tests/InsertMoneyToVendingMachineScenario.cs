using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;
namespace SeleniumTests.Tests
{
    internal class InsertMoneyToVendingMachineScenario : BaseTest
    {
      
        [Test]

        public void CheckAmountAddedToAllDenominations()
        {
            string fiveEurosAmount = "1";
            string twoEurosAmount = "2";
            string oneEuroAmount = "2";
            string tenCentsAmount = "1";
            double totalAmount = 5 * double.Parse(fiveEurosAmount) + 2 * double.Parse(twoEurosAmount) + 1 * double.Parse(oneEuroAmount) + 0.1 * double.Parse(tenCentsAmount);
            string expectedResults = totalAmount.ToString("0.00").Replace(',', '.');

            VendingMachinePage.Open();
            VendingMachinePage.InsertFiveEurosAmount(fiveEurosAmount);
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.InsertOneEuroAmount(oneEuroAmount);
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            string actualResults = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}
