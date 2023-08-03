using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using System.IO;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            driver.Value = new ChromeDriver(options);
        }

        public static void CloseDriver()
        {
            driver.Value.Quit();
        }

        internal static void OpenUrl(string url)
        {
            driver.Value.Url = url;
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }
        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
