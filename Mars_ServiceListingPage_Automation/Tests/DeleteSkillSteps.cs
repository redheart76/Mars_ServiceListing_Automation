using System;
using Mars_ServiceListingPage_Automation.Pages;
using Mars_ServiceListingPage_Automation.Utilities;
using TechTalk.SpecFlow;

namespace Mars_ServiceListingPage_Automation.Tests
{
    [Binding]
    public class DeleteSkillSteps : CommonDriver
    {
        
            private readonly ScenarioContext _scenarioContext;

            public DeleteSkillSteps(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I login my account")]
            public void GivenILoginMyAccount()
            {
            HomePage homepageObj = new HomePage();
            homepageObj.loginSteps(driver);
        }

            [Given(@"I will go to listing management page")]
            public void GivenIWillGoToListingManagementPage()
            {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.gotoListingManagementPage(driver);
        }

            [When(@"I press delete icon and accept")]
            public void WhenIPressDeleteIconAndAccept()
            {
            ListingManagermentPage listingManagermentPageObj = new ListingManagermentPage();
            listingManagermentPageObj.deleteSkill(driver);
            }

            [Then(@"the selected skill will be deleted")]
            public void ThenTheSelectedSkillWillBeDeleted()
            {
            ListingManagermentPage listingManagermentPageObj = new ListingManagermentPage();
            listingManagermentPageObj.assertDeletion(driver);
            driver.Close();
        }
    }
}
