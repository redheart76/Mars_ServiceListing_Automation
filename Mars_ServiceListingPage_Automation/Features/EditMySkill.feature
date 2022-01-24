Feature: Edit my existing skill
	In order to edit a skill in the listing
	As an user
	I want to edit the skill details
	
@mytag
Scenario: Edit my skill details
	Given I logged in my account
	And I have navigated to listing management page
    And I have navigated to edit skill details
	When I press save
	Then the result change will be saved
