using System;
using OpenQA.Selenium;

namespace Mars_ServiceListingPage_Automation.Pages
{
    public class ServiceListingPage
    {
        
       public void newSkill(IWebDriver driver)
       {

            IWebElement title = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            title.SendKeys("Web Design");//Type in new Title

            IWebElement description = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            description.SendKeys("Design and build the website from scratch.");//Type in description

            IWebElement category = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div > select"));
            category.Click();//Click on category drop down menu
            IWebElement categorySelection = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select/option[2]"));
            categorySelection.Click();//Select Graphics & Design
            IWebElement subCategory = driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select"));
            subCategory.Click();//Click on Subcategory
            IWebElement subcategorySelection = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[6]"));
            subCategory.Click();//Select Search & Display Marketing

            IWebElement newTag = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            newTag.SendKeys("A");//Add a new tag

            IWebElement serviceType = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            serviceType.Click();//Select service type

            IWebElement locationType = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationType.Click();//Select location type

            IWebElement startDate = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.SendKeys("01052022");//Select available start date
            IWebElement endDate = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.SendKeys("04052022");//Select available end date

            IWebElement availableDay = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            availableDay.Click();//Select available day

            IWebElement startTime = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
            startTime.SendKeys("0800am");//Select available start time
            IWebElement endTime = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
            endTime.SendKeys("0500pm");//Select available end time

            IWebElement skillTrades = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTrades.Click();

            //Add file

            IWebElement activeStatus = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            activeStatus.Click();//Select active status

            IWebElement saveBTN = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            saveBTN.Click();//Click on the save button to save the changes


        }
     }
}
