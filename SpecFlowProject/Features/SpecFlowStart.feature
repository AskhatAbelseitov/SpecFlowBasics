Feature: SpecFlow documentation find
As a Specflow framework user
In order to easily find needed information about product
I want to be able to navigate to searching tab and find docs

@search
Scenario: Open 'Documentation' tab
	Given I am on the Main Page
    When Open 'SpecFlow' section on 'Docs' tab
    And Open 'SpecFlow Documentation' page
    And Enter keyword in the 'Search' field
    Then I can click on the any result title



