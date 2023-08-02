using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests
{
    internal class CancelOrderScenario : BaseTest
    {
        [Test]

        public void CheckCancelOrderWithMoneyInserted()
        {
            string fiveEurosAmount = "1";
            string twoEurosAmount = "2";
            string oneEuroAmount = "2";
            string tenCentsAmount = "1";
            string expectedMessageResults = "First of all, you need to insert your money";
            string expectedTotalAmount = "0.00";

            VendingMachinePage.Open();
            VendingMachinePage.InsertFiveEurosAmount(fiveEurosAmount);
            VendingMachinePage.InsertTwoEurosAmount(twoEurosAmount);
            VendingMachinePage.InsertOneEuroAmount(oneEuroAmount);
            VendingMachinePage.InsertTenCentsAmount(tenCentsAmount);
            VendingMachinePage.ClickCancelButton();
            string actualMessageResults = VendingMachinePage.GetCancelOrderMessage();
            string actualTotalAmount = VendingMachinePage.GetTotalAmount();

            Assert.AreEqual(expectedMessageResults, actualMessageResults);
            Assert.AreEqual(expectedTotalAmount, actualTotalAmount);
        }
    }
}
