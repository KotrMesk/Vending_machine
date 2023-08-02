using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class VendingMachinePage
    {
        public static void ClickBrownieButton()
        {
            string locator = "//*[@value='Brownie']";
            Common.ClickElement(locator);
        }

        public static void ClickCancelButton()
        {
            string locator = "//*[@value='cancel']";
            Common.ClickElement(locator);
        }

        public static void ClickChocolateButton()
        {
            string locator = "//*[@value='Chocolate']";
            Common.ClickElement(locator);
        }

        public static void ClickTwixButton()
        {
            string locator = "//*[@value='Twix']";
            Common.ClickElement(locator);
        }

        public static string GetCancelOrderMessage()
        {
            return Common.GetElementText("//*[@id='message']");
        }

        public static string GetMessage()
        {
            return Common.GetElementText("//*[@id='message']");
        }

        public static string GetMessageWithMoneyAmountReturned()
        {
            return Common.GetElementText("//*[@id='message']");
        }

        public static string GetTotalAmount()
        {
            return Common.GetElementText("//*[@id='Total']");
        }

        public static void InsertFiveEurosAmount(string fiveEurosAmount)
        {
            string locator = "//*[@name='5']";
            Common.SendKeys(locator, fiveEurosAmount);
        }

        public static void InsertOneEuroAmount(string oneEuroAmount)
        {
            string locator = "//*[@name='1']";
            Common.SendKeys(locator, oneEuroAmount);
        }

        public static void InsertTenCentsAmount(string tenCentsAmount)
        {
            string locator = "//*[@name='0.1']";
            Common.SendKeys(locator, tenCentsAmount);
        }

        public static void InsertTwoEurosAmount(string twoEurosAmount)
        {
            string locator = "//*[@name='2']";
            Common.SendKeys(locator, twoEurosAmount);
        }

        public static void Open()
        {
            Driver.OpenUrl("file:///C:/Users/varna/Desktop/vending%20machine/index.html");
        }
    }
}
