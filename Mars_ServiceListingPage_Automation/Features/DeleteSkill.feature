Feature: Delete a skill
	In order to delete a existing skill
	As an user
	I want to delete one of my skills form the list
	
@mytag
Scenario: Delete one of my skills
	Given I login my account
	And I will go to listing management page
	When I press delete icon and accept
	Then the selected skill will be deleted
