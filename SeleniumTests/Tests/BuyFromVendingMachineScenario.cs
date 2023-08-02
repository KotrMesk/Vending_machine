using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    internal class BuyFromVendingMachineScenario : BaseTest
    {
        [Test]
        public void CheckBuyingTwixWithMoneyInsertedInAllDenominations()
        {
            string fiveEurosAmount = "1";
            string twoEurosAmount = "2";
            string oneEuroAmount = "2";
            string tenCentsAmount = "1";
            double moneyReturned = (5 * double.Parse(fiveEurosAmount) + 2 * double.Parse(twoEurosAmount) + 1 * double.Parse(oneEuroAmount) + 0.1 * double.Parse(tenCentsAmount)) - 2;
            string expectedMessageResults = $"Twix has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";
            string expectedTotalAmount = "0.00";

            VendingMachinePage.Open();
            VendingMachinePage.InsertFiveEurosAmount(fiveEurosAmount);
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.InsertOneEuroAmount(oneEuroAmount);
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            VendingMachinePage.ClickTwixButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingChocolateWithMoneyInsertedInAllDenominations()
        {
            string fiveEurosAmount = "1";
            string twoEurosAmount = "2";
            string oneEuroAmount = "2";
            string tenCentsAmount = "1";
            double moneyReturned = (5 * double.Parse(fiveEurosAmount) + 2 * double.Parse(twoEurosAmount) + 1 * double.Parse(oneEuroAmount) + 0.1 * double.Parse(tenCentsAmount)) - 2;
            string expectedMessageResults = $"Chocolate has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";
            string expectedTotalAmount = "0.00";

            VendingMachinePage.Open();
            VendingMachinePage.InsertFiveEurosAmount(fiveEurosAmount);
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.InsertOneEuroAmount(oneEuroAmount);
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            VendingMachinePage.ClickChocolateButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingBrownieWithMoneyInsertedInAllDenominations()
        {
            string fiveEurosAmount = "1";
            string twoEurosAmount = "2";
            string oneEuroAmount = "2";
            string tenCentsAmount = "1";
            double moneyReturned = (5 * double.Parse(fiveEurosAmount) + 2 * double.Parse(twoEurosAmount) + 1 * double.Parse(oneEuroAmount) + 0.1 * double.Parse(tenCentsAmount)) - 2;
            string expectedMessageResults = $"Brownie has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";
            string expectedTotalAmount = "0.00";

            VendingMachinePage.Open();
            VendingMachinePage.InsertFiveEurosAmount(fiveEurosAmount);
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.InsertOneEuroAmount(oneEuroAmount);
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            VendingMachinePage.ClickBrownieButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }


        [Test]
        public void CheckBuyingTwixWithTwoEurosInserted()
        {
            string twoEurosAmount = "1";
            string expectedTotalAmount = "0.00";
            double moneyReturned = 2 * double.Parse(twoEurosAmount) - 2;
            string expectedMessageResults = $"Twix has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";

            VendingMachinePage.Open();
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.ClickTwixButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingChocolateWithTwoEurosInserted()
        {
            string twoEurosAmount = "1";
            string expectedTotalAmount = "0.00";
            double moneyReturned = 2 * double.Parse(twoEurosAmount) - 2;
            string expectedMessageResults = $"Chocolate has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";

            VendingMachinePage.Open();
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.ClickChocolateButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingBrownieWithTwoEurosInserted()
        {
            string twoEurosAmount = "1";
            string expectedTotalAmount = "0.00";
            double moneyReturned = 2 * double.Parse(twoEurosAmount) - 2;
            string expectedMessageResults = $"Brownie has been bought. €{moneyReturned.ToString("0.00").Replace(',', '.')} returned.";

            VendingMachinePage.Open();
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.ClickBrownieButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingTwixWithNotEnoughMoney()
        {
            string tenCentsAmount = "5";
            double totalAmount = 0.1 * double.Parse(tenCentsAmount);
            string expectedTotalAmount = totalAmount.ToString("0.00").Replace(',', '.');
            string expectedMessageResults = "You have not paid enough. €0.00 has been returned.";
            
            VendingMachinePage.Open();
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            VendingMachinePage.ClickTwixButton();
            string actualMessageResults = VendingMachinePage.GetMessageWithMoneyAmountReturned();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingTwixWithoutMoney()
        {
            string expectedTotalAmount = "0.00";
            string expectedMessageResults = "Please insert the right amount of money";

            VendingMachinePage.Open();
            VendingMachinePage.ClickTwixButton();
            string actualMessageResults = VendingMachinePage.GetMessage();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingChocolateWithoutMoney()
        {
            string expectedTotalAmount = "0.00";
            string expectedMessageResults = "Please insert the right amount of money";

            VendingMachinePage.Open();
            VendingMachinePage.ClickChocolateButton();
            string actualMessageResults = VendingMachinePage.GetMessage();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }

        [Test]
        public void CheckBuyingBrownieWithoutMoney()
        {
            string expectedTotalAmount = "0.00";
            string expectedMessageResults = "Please insert the right amount of money";

            VendingMachinePage.Open();
            VendingMachinePage.ClickBrownieButton();
            string actualMessageResults = VendingMachinePage.GetMessage();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }
    }
}
