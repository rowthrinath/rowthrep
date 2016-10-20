Feature: Your Details
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to TPR

@Integration
Scenario: Check the correct questions are displayed on the Your Details accordion
	Then I should see 6 questions on the current accordion
	And the following questions should be displayed
		| Question       |
		| Title          |
		| FirstName      |
		| Surname        |
		| Email          |
		| HomePhone      |
		| AlternatePhone |

@Integration
Scenario: Check the Your Details Title question is mandatory
	When I populate the following questions
		| Question  | Comments                             |
		| FirstName | Could these use a default attribute? |
		| Surname   |                                      |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question |
		| Title    |

@Integration
Scenario: Check the Your Details First Name question is mandatory
	When I populate the following questions
		| Question | Comments                             |
		| Title    | Could these use a default attribute? |
		| Surname  |                                      |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question  |
		| FirstName |

@Integration
Scenario: Check the Your Details Surname question is mandatory
	When I populate the following questions
		| Question  | Comments                             |
		| Title     | Could these use a default attribute? |
		| FirstName |                                      |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question |
		| Surname  |

@Integration
Scenario: Check the Your Details Email question is mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question |
		| Email    |

@Integration
Scenario Outline: Check the Your Details questions have to correct format validation
	When I complete the form
	And I populate the following questions
         | Question   | Data   |
         | <Question> | <Data> |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
         | Question   |
         | <Question> |
	
	Examples: 
		| Question       | Data       |
		| Email          | open@gi    |
		| HomePhone      | 012345678  |
		| HomePhone      | 1234567890 |
		| AlternatePhone | 012345678  |
		| AlternatePhone | 1234567890 |

@Integration
Scenario: Check the Your Details Home Phone question is mandatory
	When I click Next expecting no accordion transition
	Then the following questions should be displayed
		| Question  |
		| HomePhone |

@Integration
Scenario: Check completing the Your Details accordion moves to the Further Information accordion
	When I complete the form
	And I click Next expecting an accordion transition
	Then I should move to the Further Information accordion
