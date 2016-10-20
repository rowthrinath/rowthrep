Feature: TabOne
	Check for things on Tab One for eBrokerDemo website

Background: 
Given I have launched in to eBrokerDemo


@IntegrationdeBroker
Scenario: Check the correct questions are displayed on the First Tab
	When I click on Get a Quote in open insurance page
	Then I should see 11 questions on the current accordion
	And the following questions should be displayed
	| Question			|
	| PromotionCode     |
	| Marketing         |
	| Title				|
	| FirstName         |
	| Surname			|
	| ContactNumber     |
	| PrimaryEmail      |
	| Postcode			|
	| CoverType         |
	| CoverStartDate    |


@Integration
Scenario: Check if email validation is trigerred
When I complete the form
And I populate the following questions
| Question     | Data |
| PrimaryEmail | abc  |
And I click Next expecting no accordion transition
Then the following questions should have an error displayed
| Question     |
| PrimaryEmail |

@Integration
Scenario: Check if help text can be displayed
	When I hover over the help text icon for "Marketing"
	Then I should see the help wording


@Integration
Scenario: Check if validation is trigerred for mandatory questions
When I click Next expecting no accordion transition
Then the following questions should have an error displayed
| Question      |
| Title         |
| FirstName     |
| Surname       |
| ContactNumber |
| PrimaryEmail  |
| Postcode      | 

@Integration
Scenario: Check if cover start date cannot be in the past