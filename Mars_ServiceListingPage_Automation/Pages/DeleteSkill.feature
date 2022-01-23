Feature: Manage Listings
	In order to be able to manage existing listings
	As a user
	I want to delete a existing skill
	
@mytag
Scenario: Delete a skill
	Given I have logged in my account
	And I have navigated to Listing management page
	When I press delete icon of a selected skill
    And I click on Yes
	Then the selected skill should be deleted
