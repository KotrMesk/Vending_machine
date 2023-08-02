using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }
        internal static void SendKeys(string locator, string fiveEurosAmount)
        {
            GetElement(locator).SendKeys(fiveEurosAmount);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }
    }
}
