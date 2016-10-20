Feature:	End to End smoke test
			- Cannot test all functionality for a single page in a single scenario - so want to use as many functions as we can, can add scenarios as required?
			- Complete Policy Page
			- Submit and Verify we are on Vehicle Page
			- Go back to Policy Page and verify entries are the same
			- Submit again and Complete Vehicle Page
			- Since scenarios MUST be able to run independantly, we have to fill out every preceding page to go to the necxt page (and/or back to the previous page)



Background: 
Given I have launched in to eBrokerDemo

@PolicyDetails
Scenario: 01 To Check if the current tab is correct
Then I should be on the POLICY tab


@PolicyDetails
Scenario: 02 To Check  if the correct tabs are present
	Then I should see 4 tabs on the page
	And I should see the following tabs
	| Tab     |
	| POLICY  |
	| VEHICLE |
	| DRIVER  |
	| QUOTE   |	

@PolicyDetails
Scenario: 03 To Check if correct questions are displayed
	Then I should see 6 questions on the current accordion
	And the following questions should be displayed
	| Question       |
	| Title          |
	| FirstName      |
	| Surname        |
	| ContactNumber  |
	| PrimaryEmail   |
   #| Postcode       |
	| CoverStartDate |

@PolicyDetails
Scenario: 04 Fill in all policy details and submit, then return to page
When I click the "MrButton" button
Then the "MrButton" button should be visible
When I populate the following questions
         | Question       | Data          |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
		 | PrimaryEmail   | test@test.com |
      #  | Postcode       | WR49SR        |
	     | CoverStartDate | 01/01/2017    | 

Then the following questions should have the following information
         | Question		  | Data		  |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
         | PrimaryEmail   | test@test.com |
      #  | Postcode       | WR49SR        |
         | CoverStartDate | 01/01/2017    |


When I click Next expecting an accordion transition

Then I should be on the VEHICLE tab

When I click Back expecting an accordion transition
Then the following questions should have the following information
		 | Question		  | Data		  |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
         | PrimaryEmail   | test@test.com |
      #  | Postcode       | WR49SR        |
         | CoverStartDate | 01/01/2017    |
         







		