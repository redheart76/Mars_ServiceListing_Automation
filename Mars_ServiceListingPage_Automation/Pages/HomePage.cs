using System;
using Mars_ServiceListingPage_Automation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_ServiceListingPage_Automation.Pages
{
    public class HomePage
    {
        public void loginSteps(IWebDriver driver)
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5000/"; //Launch Mars website
            IWebElement signinBTN = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinBTN.Click();//Click sign in button

            //Wait.WaitToBeClickable(driver, "Xpath" , "/html/body/div[2]/div/div/div[1]/div/div[1]/input)", 2);

            IWebElement userName = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            userName.SendKeys("redheart76@live.com");//Type in user name

            IWebElement passWord = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passWord.SendKeys("123123");//Type in password

            IWebElement loginBTN = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginBTN.Click();//Click on Login button

        }
    }
}
