using System;
using Mars_ServiceListingPage_Automation.Utilities;
using OpenQA.Selenium;

namespace Mars_ServiceListingPage_Automation.Pages
{
    public class ProfilePage
    {
        public void gotoServiceListing(IWebDriver driver)
        {
            
            IWebElement shareskillBTN = driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a"));
            shareskillBTN.Click();//Click share skill button

            Wait.WaitToBeClickable(driver, "Xpath", "///*[@id='requiredField']/text()", 2);

        }
    }
}
