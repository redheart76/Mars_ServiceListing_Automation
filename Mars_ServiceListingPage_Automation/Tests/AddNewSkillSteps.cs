using System;
using Mars_ServiceListingPage_Automation.Pages;
using Mars_ServiceListingPage_Automation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_ServiceListingPage_Automation.Tests
{
    [Binding]
    public class AddNewSkillSteps : CommonDriver
    {
            private readonly ScenarioContext _scenarioContext;

            public AddNewSkillSteps(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }


            [Given(@"I have logged in my account")]
            public void GivenIHaveLoggedInMyAccount()
            {

            HomePage homepageObj = new HomePage();
            homepageObj.loginSteps(driver);
            }

            [Given(@"I have navigatored to the Service Listing page")]
            public void GivenIHaveNavigatoredToTheServiceListingPage()
            {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.gotoServiceListing(driver);
            }

            [Given(@"I add the detais of my skill")]
            public void GivenIAddTheDetaisOfMySkill()
            {
            ServiceListingPage serviceListingPageObj = new ServiceListingPage();
            serviceListingPageObj.newSkill(driver);

        }

            [When(@"I press Save button")]
            public void WhenIPressSaveButton()
            {
            ServiceListingPage serviceListingPageObj = new ServiceListingPage();
            serviceListingPageObj.saveSkill(driver);
        }

            [Then(@"the new skill will be saved")]
            public void ThenTheNewSkillWillBeSaved()
            {

            ListingManagermentPage listingManagermentPageObj = new ListingManagermentPage();
            listingManagermentPageObj.assertTitleIsDisplayed(driver);
            driver.Close();
            }
        }
    }
