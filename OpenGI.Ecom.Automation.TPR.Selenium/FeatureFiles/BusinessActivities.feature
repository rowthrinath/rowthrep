Feature: Business Activities
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to TPR
	And I have shown the Business Activities accordion

@Integration
Scenario: Check the correct questions are displayed on the Business Activities accordion
	Then I should see 4 questions on the current accordion
	And the following questions should be displayed
		| Question                                 |
		| QualificationRequired                    |
		| MemberOfProfessionalAssociation          |
		| DoYouRequireCoverForAdditionalActivities |
		| AccreditedTraining                       |

@Integration
Scenario: Check the Business Activities questions are mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question                                 |
		| QualificationRequired                    |
		| MemberOfProfessionalAssociation          |
		| DoYouRequireCoverForAdditionalActivities |
		| AccreditedTraining                       |

@Integration
Scenario: Check answering the Qualification Required question with a yes displays the Are You Qualified question
	When I populate the following questions
         | Question              | Data |
         | QualificationRequired | yes  |
	Then I should see 5 questions on the current accordion
	And the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | AreYouQualified                          |
         | MemberOfProfessionalAssociation          |
         | DoYouRequireCoverForAdditionalActivities |
         | AccreditedTraining                       |

@Integration
Scenario: Check the Are You Qualified question is mandatory when displayed
	When I populate the following questions
         | Question              | Data |
         | QualificationRequired | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question        |
		| AreYouQualified |

@Integration
Scenario: Check answering the Business Activities Are You A Member Of A Professional Association question with a no displays the What Is Your Main Profession question
	When I populate the following questions
         | Question                        | Data |
         | MemberOfProfessionalAssociation | no   |
	Then I should see 5 questions on the current accordion
	And the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | MemberOfProfessionalAssociation          |
         | WhatIsYourMainProfession                 |
         | DoYouRequireCoverForAdditionalActivities |
         | AccreditedTraining                       |

@Integration
Scenario: Check the Business Activities What Is Your Main Profession Question is mandatory when displayed
	When I populate the following questions
         | Question                        | Data |
         | MemberOfProfessionalAssociation | no   |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question                 |
		| WhatIsYourMainProfession |

@Integration
Scenario: Check answering the Business Activities Are You A Member Of A Professional Association question with a yes displays the two additional Professional Association questions
	When I populate the following questions
         | Question                        | Data |
         | MemberOfProfessionalAssociation | yes  |
	Then I should see 6 questions on the current accordion
	And the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | MemberOfProfessionalAssociation          |
         | ProfessionalAssociation                  |
         | ProfessionalAssociationMemberNumber      |
         | DoYouRequireCoverForAdditionalActivities |
         | AccreditedTraining                       |

@Integration
Scenario: Check the Business Activities Professional Association question is mandatory when displayed
	When I populate the following questions
         | Question                        | Data |
         | MemberOfProfessionalAssociation | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question                |
		| ProfessionalAssociation |

@Integration
Scenario: Check I can search for Professions from the autocomplete list
	When I populate the following questions
         | Question                        | Data |
         | MemberOfProfessionalAssociation | no   |
	And I populate the autocomplete list for following questions
		| Question              |
		| WhatIsYourMainProfession |
	Then The autocomplete list should be non-empty
	

@Integration
Scenario: Check I can select a Profession from the autocomplete list
	When I populate the following questions
         | Question                        | Data    |
         | MemberOfProfessionalAssociation | no      |
         | WhatIsYourMainProfession        | unicorn |
	Then I should see the autocomplete list
	When I click the "Unicorn Healing" autocomplete item
	Then the following questions should have the following information
		 | Question                 | Data            |
		 | WhatIsYourMainProfession | Unicorn Healing |

@Integration
Scenario: Check answering the Business Activities Do You Require Cover For Additional Activities question with a yes displays the Additional Activities question
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	Then I should see 5 questions on the current accordion
	And the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | MemberOfProfessionalAssociation          |
         | DoYouRequireCoverForAdditionalActivities |
         | AdditionalActivityOne                    |
         | AccreditedTraining                       |

@Integration
Scenario: Check the Business Activities accordion only allows you to add ten Additional Activities
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	And I click the "AddAdditionalActivityButton" button 8 times
	Then the "AddAdditionalActivityButton" button should be visible
	When I click the "AddAdditionalActivityButton" button
	Then the "AddAdditionalActivityButton" button should not be visible
	Then I should see 14 questions on the current accordion
	And the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | MemberOfProfessionalAssociation          |
         | DoYouRequireCoverForAdditionalActivities |
         | AdditionalActivityOne                    |
         | AdditionalActivityTwo                    |
         | AdditionalActivityThree                  |
         | AdditionalActivityFour                   |
         | AdditionalActivityFive                   |
         | AdditionalActivitySix                    |
         | AdditionalActivitySeven                  |
         | AdditionalActivityEight                  |
         | AdditionalActivityNine                   |
         | AdditionalActivityTen                    |
         | AccreditedTraining                       |

@Integration
Scenario: Check the Business Activities accordion allows you to add Additional Activities when you remove the tenth additional activity
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	And I click the "AddAdditionalActivityButton" button 9 times
	Then the "AddAdditionalActivityButton" button should not be visible
	When I click the "RemoveAdditionalActivityTenButton" button
	Then the "AddAdditionalActivityButton" button should be visible

@Integration
Scenario: Check the Business Activities Additional Activities questions are mandatory if displayed
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	And I click the "AddAdditionalActivityButton" button
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		 | Question              |
		 | AdditionalActivityOne |
		 | AdditionalActivityTwo |

@Integration
Scenario: Check I can search for Additional Activities from the autocomplete list
	When I populate the following questions
         | Question                                 | Data  |
         | DoYouRequireCoverForAdditionalActivities | yes   |
	And I populate the autocomplete list for following questions
	| Question              |
	| AdditionalActivityOne |
	Then The autocomplete list should be non-empty
	
	
@Integration
Scenario: Check I can select an Additional Activity from the autocomplete list
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	And I click the "AddAdditionalActivityButton" button
	And I select the first available item from the autocomplete list
		 | Question              | 
		 | AdditionalActivityOne | 
	Then the following questions should have the following information
		 | Question              | Data         |
		 | AdditionalActivityOne | <RandomText> |
		 | AdditionalActivityTwo |              |

@Integration
Scenario: Check removing an Additional Activity keeps the other Additional Activities
	When I populate the following questions
         | Question                                 | Data |
         | DoYouRequireCoverForAdditionalActivities | yes  |
	And I click the "AddAdditionalActivityButton" button 2 times
	And I populate the following questions
		 | Question              | Data            |
		 | AdditionalActivityOne | Unicorn Healing |
	Then I should see the autocomplete list
	When I populate the following questions
         | Question                | Data          |
         | AdditionalActivityThree | Egg Cleansing |
	Then I should see the autocomplete list
	And  the following questions should have the following information
         | Question                | Data            |
         | AdditionalActivityOne   | Unicorn Healing |
         | AdditionalActivityTwo   |                 |
         | AdditionalActivityThree | Egg Cleansing   |
	When I click the "RemoveAdditionalActivityTwoButton" button
	Then the following questions should have the following information
         | Question              | Data            |
         | AdditionalActivityOne | Unicorn Healing |
         | AdditionalActivityTwo | Egg Cleansing   |


@Integration
Scenario: Check answering the qualification required question shows the required qualifications? question
	When I populate the following questions
         | Question              | Data |
         | QualificationRequired | yes  |
	Then the following questions should be displayed
         | Question                                 |
         | QualificationRequired                    |
         | AreYouQualified                          |
         | MemberOfProfessionalAssociation          |
         | DoYouRequireCoverForAdditionalActivities |
         | AccreditedTraining                       |

@Integration
Scenario: Check the required qualifications? question is mandatory when it is shown
	When I populate the following questions
         | Question              | Data |
         | QualificationRequired | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
		| Question        |
		| AreYouQualified |

@Integration
Scenario: Check completing the Business Activities accordion moves back to the Your Details accordion
	When I complete the form
	And I click Next expecting an accordion transition
	Then I should move to the Your Details accordion


#	Scenario: Check that the Professional Association list is correct
#	When I select Yes for 'Are you a member of a professional association?'
#	And The Professional Association list is displayed
#	Then I should see the following items
#         | Data |
#         |   Clerksroom   |

#Scenario: Check I can search for Professional Associations from the dropdown list
#	When I populate the following questions
#         | Question                                 | Data  |
#         | AreYouAMemberofAProfessionalAssociation | yes   |
#	Then I should see the dropdown list
#	And I should see 40 items in the list
#	And I should see the following items
#		 | Item                |
#		 | Home Tutors      |
#		 | Clerksroom   |
#		 | Private Tutor  |
		