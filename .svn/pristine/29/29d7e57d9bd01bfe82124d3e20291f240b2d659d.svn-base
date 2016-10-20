Feature: Submit PolicyDetails 


Background: 
Given I have launched in to eBrokerDemo

@TestingModels
Scenario: 01 To Check  if the correct models are present
	Then I should see 4 models on the page
@PolicyDetails
Scenario: 01 To Check  if the correct tabs are present
	Then I should see 4 tabs on the page
	And I should see the following tabs
	| Tab     |
	| POLICY  |
	| VEHICLE |
	| DRIVER  |
	| QUOTE   |	

@PolicyDetails
Scenario: 02 To Check if correct questions are displayed
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
Scenario: 03 Fill in all details and submit policy details
When I click the "MrButton" button
Then the "MrButton" button should be visible
When I populate the following questions
         | Question       | Data          |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
		 | CoverStartDate | 01/01/2017    |
         | PrimaryEmail   | test@test.com |
      #  | Postcode       | WR49SR        |

Then the following questions should have the following information
         | Question | Data |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
         | PrimaryEmail   | test@test.com |
      #   | Postcode       | WR49SR        |
        | CoverStartDate | 01/01/2017    |


When I click Next expecting an accordion transition

Then the following questions should be displayed
         | Question       |
         | OwnerAndUse_Q1  |
         | OwnerAndUse_Q2 |
		 | OwnerAndUse_Q3 |
		 | OwnerAndUse_Q4 |
		 | OwnerAndUse_Q5 |
		 | CoverDetails_Q1 |
		 | CoverDetails_Q2 |
		 | CoverDetails_Q3 |
		 | CoverDetails_Q4 |
		 | AdditionalDrivers_Q1 |
When I click the "OwnerAndUse_OwnerYes" button
When I populate the following questions
         | Question | Data |
         |     OwnerAndUse_PurchaseDate     |   01/01/2001   |
Then the following questions should have the following information
         | Question                 | Data |
         | OwnerAndUse_PurchaseDate | 01/01/2001     |
When I click the "OwnerAndUse_WhoOwnsYourCar_CompanyDir" button

When I click the "OwnerAndUse_WhereDoYouPark_Other" button
When I select the following questions
        | Question                                | Data            |
         | OwnerAndUse_WhereDoYouPark_Other_Select | Public Road |
Then the following questions should have the following information
         | Question                 | Data |
         | OwnerAndUse_WhereDoYouPark_Other_Select | Public Road     |         
When I click the "CoverDetails_LevelOfCover_Comp" button
When I click the "CoverDetails_DoYouNeedWS" button
When I populate the following questions
         | Question        | Data         |
         | CoverDetails_Q2 | £50         |
         | CoverDetails_Q3 | 2            |
         | CoverDetails_Q4 | Insured Only |
Then the following questions should have the following information
         | Question | Data |
         | CoverDetails_Q2      | 50          |
         | CoverDetails_Q3        | 2          |
         | CoverDetails_Q4  | Insured Only     |
When I click the "AdditionalDrivers_Four" button
When I click the "Vehicle_Next_Button" button








		