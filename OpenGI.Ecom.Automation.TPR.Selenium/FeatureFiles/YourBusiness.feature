Feature: YourBusiness
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to TPR
	And I have shown the Your Business accordion

@Integration
Scenario: Check the correct questions are displayed on the Your Business accordion
	Then I should see 3 questions on the current accordion
	And the following questions should be displayed
		| Question         |
		| IsLimitedCompany |
		| WorksOutsideUK   |
		| CoverStartDate   |

@Integration
Scenario: Check the Your Business questions are mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question         |
		| IsLimitedCompany |
		| WorksOutsideUK   |

@Integration
Scenario: Check the Your Business Do You Work Outside The UK question displays the Are You Based In The UK question
	When I populate the following questions
         | Question       | Data | Comment                |
         | WorksOutsideUK | yes  |                        |
         | BasedInUK      | no   | Hack to reset the form |
	Then I should see 4 questions on the current accordion
	And the following questions should be displayed
         | Question         |
         | IsLimitedCompany |
         | WorksOutsideUK   |
         | BasedInUK        |
         | CoverStartDate   |

@Integration
Scenario: Check the Your Business Are You Based In The UK question is mandatory when displayed
	When I populate the following questions
         | Question       | Data |
         | WorksOutsideUK | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question  |
		| BasedInUK |

@Integration
Scenario: Check the Your Business Are You Based In The UK question displays the Do You Own Property In The Countries You Work In Other Than The UK question
	When I populate the following questions
         | Question       | Data |
         | WorksOutsideUK | yes  |
         | BasedInUK      | yes  |
	Then I should see 5 questions on the current accordion
	And the following questions should be displayed
         | Question                |
         | IsLimitedCompany        |
         | WorksOutsideUK          |
         | BasedInUK               |
         | OwnsPropertiesOutsideUK |
         | CoverStartDate          |

@Integration
Scenario: Check the Your Business Do You Own Property In The Countries You Work In Other Than The UK question is mandatory when displayed
	When I populate the following questions
         | Question       | Data |
         | WorksOutsideUK | yes  |
         | BasedInUK      | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question                |
		| OwnsPropertiesOutsideUK |

@Integration
Scenario: Check completing the Your Business accordion moves you to the Business Activities accordion
	When I complete the form
	And I click Next expecting an accordion transition
	Then I should move to the Business Activities accordion
