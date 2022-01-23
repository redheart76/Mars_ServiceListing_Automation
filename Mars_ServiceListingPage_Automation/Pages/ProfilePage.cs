using System;
using System.Threading;
using Mars_ServiceListingPage_Automation.Utilities;
using OpenQA.Selenium;

namespace Mars_ServiceListingPage_Automation.Pages
{
    public class ProfilePage
    {
        public void gotoServiceListing(IWebDriver driver)
        {
            
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);
            IWebElement shareskillBTN = driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a"));
            shareskillBTN.Click();//Click share skill button
            
        }

        public void gotoListingManagementPage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);
            IWebElement managerListingsTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[3]"));
            managerListingsTab.Click();//Click on manager listings tab
        }
    }
}
