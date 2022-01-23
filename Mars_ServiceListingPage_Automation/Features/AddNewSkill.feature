Feature: Share Skill
	In order to trade my skill with other people
	
	I want to add my skills to allow the users to view
	
@mytag
Scenario: Add New Skill
	Given I have logged in my account
	And I have navigatored to the Service Listing page
    And I add the detais of my skill
	When I press Save button
	Then the new skill will be saved
