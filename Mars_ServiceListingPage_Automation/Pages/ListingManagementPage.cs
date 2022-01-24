using System;
using Mars_ServiceListingPage_Automation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_ServiceListingPage_Automation.Pages
{
    public class ListingManagermentPage
    {
        public void assertTitleIsDisplayed(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "Xpath", "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]", 2);
            IWebElement titleText = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            Assert.IsTrue(titleText.Displayed);//Assert whether the title text is displayed

        }

        public void deleteSkill(IWebDriver driver)
        {
            IWebElement deleteIcon = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
            deleteIcon.Click();
            IWebElement yesIcon = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]/i"));
            yesIcon.Click();

        }

        public void assertConfirmationIsDisplayed(IWebDriver driver)
        {
            IWebElement deletionText = driver.FindElement(By.XPath(""));
            Assert.IsTrue(deletionText.Displayed);//Assert whether "You do not have any service listings!" is displayed
        }

        public void editSkill(IWebDriver driver)
        {
            
            IWebElement editIcon = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            editIcon.Click();
        }

        public void assertNewDescriptionIsDisplayed(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "Xpath", "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[4]", 2);
            IWebElement DescriptionText = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
            Assert.IsTrue(DescriptionText.Displayed);//Assert whether new description is displayed
        }
    }
}
