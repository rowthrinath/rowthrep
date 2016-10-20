Feature: Declarations
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to TPR
	And I have shown the Declarations accordion

@Integration
Scenario: Check the correct questions are displayed on the Declarations accordion
	Then I should see 7 questions on the current accordion
	And the following questions should be displayed
		| Question                               |
		| HasNonMotoringConviction               |
		| HasEverBeenBankrupt                    |
		| HasCCJs                                |
		| HasEverBeenRefusedOrDeclinedInsurance  |
		| HasEverHadInsuranceCancelled           |
		| HasBeenDisqualifiedAsDirector          |
		| AnyIncidentsLeadingToAllegationOrClaim |

@Integration
Scenario: Check the Declarations questions are mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question                               |
		| HasNonMotoringConviction               |
		| HasEverBeenBankrupt                    |
		| HasCCJs                                |
		| HasEverBeenRefusedOrDeclinedInsurance  |
		| HasEverHadInsuranceCancelled           |
		| HasBeenDisqualifiedAsDirector          |
		| AnyIncidentsLeadingToAllegationOrClaim |

@Integration
Scenario: Check completing the Declarations accordion moves to the Your Business accordion
	When I complete the form
	And I click Next expecting an accordion transition
	Then I should move to the Your Business accordion
