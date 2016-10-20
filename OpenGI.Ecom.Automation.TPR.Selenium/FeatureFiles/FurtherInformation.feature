Feature: FurtherInformation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to TPR
	And I have shown the Further Information accordion

@Integration
Scenario: Check the correct questions are displayed on the Your Details accordion
	Then I should see 3 questions on the current accordion
	And the following questions should be displayed
		| Question          |
		| HouseNumberOrName |
		| Postcode          |
		| MarketingQuestion |

@Integration
Scenario: Check the Further Information questions are mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question          |
		| HouseNumberOrName |
		| Postcode          |
		| MarketingQuestion |

@Integration
@GridRun
Scenario: Check the Further Information Get Address button displays a popup message if no postcode is entered
	When I click the Get Address button
	Then a popup message should be displayed with the text "Please supply a complete postcode."

@Integration
Scenario: Check the Further Information Get Address button returns a list of addresses if no house number or name is entered
	When I populate the following questions
         | Question | Data    |
         | Postcode | WR2 6NJ |
	And I click the Get Address button
	Then I should see 4 questions on the current accordion
	And the following questions should be displayed
         | Question          |
         | HouseNumberOrName |
         | Postcode          |
		 | AddressList       |
         | MarketingQuestion |
	And the Address Lookup should have more than one item

@Integration
Scenario: Check the Further Information Get Address button returns only one address if the house number or name are entered
	When I populate the following questions
         | Question          | Data    |
         | HouseNumberOrName | 3       |
         | Postcode          | WR2 6NJ |
	And I click the Get Address button
	Then I should see 3 questions on the current accordion
	And the Address Lookup should have only one item
	And the Selected Address should start "Bridgehouse Property Consultants"
	When I click the Cant Find Address button
	Then I should see 7 questions on the current accordion
	And the following questions should have the following information
         | Question          | Data                          | Comments                                         |
         | HouseNumberOrName |                               | This should get cleared when you click cant find |
         | AddressLineOne    | Unit 3, Elgar Business Centre |                                                  |
         | AddressLineTwo    | Moseley Road, Hallow          |                                                  |
         | AddressLineThree  | Worcester                     |                                                  |
         | AddressLineFour   | Worcestershire                |                                                  |

@Integration
Scenario: Check the Further Information Cant Find Address button displays the manual address fields
	When I click the Cant Find Address button
	Then I should see 7 questions on the current accordion
	And the following questions should be displayed
         | Question          |
         | HouseNumberOrName |
         | Postcode          |
         | AddressLineOne    |
         | AddressLineTwo    |
         | AddressLineThree  |
         | AddressLineFour   |
         | MarketingQuestion |

@Integration
Scenario: Check completing the Further Information accordion moves you to the Declarations accordion
	When I complete the form
	And I click Next expecting an accordion transition
	Then I should move to the Declarations accordion
