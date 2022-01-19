using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_ServiceListingPage_Automation.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver = new ChromeDriver();

        public static void Close()
        {
            driver.Quit();
        }

    }
}
