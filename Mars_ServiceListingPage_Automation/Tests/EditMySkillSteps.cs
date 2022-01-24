using System;
using Mars_ServiceListingPage_Automation.Pages;
using Mars_ServiceListingPage_Automation.Utilities;
using TechTalk.SpecFlow;

namespace Mars_ServiceListingPage_Automation.Tests
{
    [Binding]
    public class EdiMySkillSteps : CommonDriver
    {
        private readonly ScenarioContext _scenarioContext;

        public EdiMySkillSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I logged in my account")]
        public void GivenILoggedInMyAccount()
        {
            HomePage homepageObj = new HomePage();
            homepageObj.loginSteps(driver);
        }

        [Given(@"I have navigated to listing management page")]
        public void GivenIHaveNavigatedToListingManagementPage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.gotoListingManagementPage(driver);
        }

        [Given(@"I have navigated to edit skill details")]
        public void GivenIHaveNavigatedToEditSkillDetails()
        {
            ListingManagermentPage listingManagermentPageObj = new ListingManagermentPage();
            listingManagermentPageObj.editSkill(driver);
            ServiceListingPage serviceListingPageObj = new ServiceListingPage();
            serviceListingPageObj.editDescription(driver);

        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            ServiceListingPage serviceListingPageObj = new ServiceListingPage();
            serviceListingPageObj.saveSkill(driver);
        }

        [Then(@"the result change will be saved")]
        public void ThenTheResultChangeWillBeSaved()
        {
            ListingManagermentPage listingManagermentPageObj = new ListingManagermentPage();
            listingManagermentPageObj.assertNewDescriptionIsDisplayed(driver);
            driver.Close();
        }
    }
}
