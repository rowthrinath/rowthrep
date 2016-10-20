Feature: Tab One
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to Vanilla
	#When I clear the current form

@Integration
Scenario: Check the correct questions are displayed on the First Tab
	Then I should see 10 questions on the current accordion
	And the following questions should be displayed
		| Question               |
		| Title                  |
		| FirstName              |
		| ShowAnotherQuestion    |
		| RevealCrossTabQuestion |
		| VehicleAgedOver        |

@Integration
Scenario: Check the Show Another Question question shows another question
	Then I should see 10 questions on the current accordion
	When I populate the following questions
		 | Question            | Data |
		 | ShowAnotherQuestion | yes  |
	Then I should see 11 questions on the current accordion
	And the following questions should be displayed
         | Question            |
         | Title               |
         | FirstName           |
         | ShowAnotherQuestion |
         | AnotherQuestion     |
		 | RevealCrossTabQuestion |
		 | VehicleAgedOver        |
	When I populate the following questions
		 | Question            | Data |
		 | ShowAnotherQuestion | no   |
	Then I should see 10 questions on the current accordion
	And the following questions should be displayed
         | Question            |
         | Title               |
         | FirstName           |
         | ShowAnotherQuestion |
		 | RevealCrossTabQuestion |
		 | VehicleAgedOver        |

@Integration
Scenario: Check the Show Another Question question shows another mandatory question
	When I populate the following questions
	| Question            | Data |
	| ShowAnotherQuestion | yes  |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
	| Question            |
	| Title               |
	| FirstName           |
	| AnotherQuestion     |

@Integration
Scenario: Check the Tab One questions are mandatory
	When I click Next expecting no accordion transition
	Then the following questions should have an error displayed
	| Question            |
	| Title               |
	| FirstName           |
	| ShowAnotherQuestion |

@Integration
Scenario: Check if question wording is displayed correctly
	Then the following questions should have the right wording
	| Question			|
	| FirstName			|
	| AnotherQuestion   |
	| VehicleAgedOver   |

@Integration
Scenario: Check if help text can be displayed
	When I hover over the help text icon for "Title"
	Then I should see the help wording

@Integration
Scenario: Check Max Length is enforced
	Then The maxlength attribute should be present and enforced
	| Question  | MaxLength | Data				   |
	| FirstName | 20	    |123456789012345678901 |

@Integration	
Scenario: Check if a question validates using Validator class
	When I complete the form
	And I populate the following questions
	| Question        | Data |
	| VehicleAgedOver | 16   |
	And I click Next expecting no accordion transition
	Then the following questions should have an error displayed
	| Question        |
	| VehicleAgedOver |

@Integration
Scenario: Check Input Width matches Specifed Value
	Then Following questions should have Corresponding Width
	| Question  | Width | Unit | 
	| Title     | 80    | px   |           
	| FirstName | 149   | px   |           
	
@Integration
Scenario: Check if Cross Tab Question Visibility is Triggered
When I complete the form
And I populate the following questions
	| Question               | Data |
	| RevealCrossTabQuestion | yes   |
And I click Next expecting an accordion transition
Then the following questions should be displayed
	| Question     |
	| ContactEmail |


@Integration
Scenario: Check if email format validation is triggered
When I complete the form
And I populate the following questions
	| Question               | Data |
	| RevealCrossTabQuestion | yes   |
And I click Next expecting an accordion transition
And I populate the following questions
	| Question             | Data       |
	| ContactEmail	       | abcdefghij |
	| RepeatQuestion1      | abcd       | 
And I click Next expecting no accordion transition
Then the following questions should have an error displayed
    |		Question		|
    |    ContactEmail      |
When I populate the following questions
	| Question     | Data       |
	| ContactEmail | abc@xyz.com |
And I click Next expecting no accordion transition
Then The Following questions should have no error displayed
| Question     |
| ContactEmail |

@Integration
Scenario: Check if items in dropdown exist from internal using display list overide (hide main list = true)
Then The question "Title" dropdown list should have the following items
| Data  |
| Mr    |
| Mrs   |
| Ms    |
| Miss  |
| Dr    |

@Integration
Scenario: Check if items in dropdown exist from internal using display list overide (hide main list = false)
Then The question "DriverStatus" dropdown list should have the following items
| Data		   |
| MyMain	   |
| MyFrequent   |
| Casual	   |
| Non Driving  |

@Integration
Scenario: Check if items in dropdown exist from internal using custom list
Then The question "InternalCustomList" dropdown list should have the following items
| Data		  |
| ListItem1	  |
| ListItem2	  |
| ListItem3	  |

@Integration
Scenario: Check if items in dropdown exist from eQuotes
Then The question "EQuotesList" dropdown list should have the following items
| Data |
| Yes  |
| No   |

@Integration
Scenario: Check if Captcha validation is triggered
When I complete the form
And I populate the following questions
| Question    | Data |
| CaptchaText | abcd |
And I click Next expecting no accordion transition
Then the following questions should have an error displayed
| Question    | 
| CaptchaText |
When I populate the following questions
| Question    | Data	|
| CaptchaText | iRobot  |
And I click Next expecting an accordion transition
Then tab 2 should be highlighted

@Integration
Scenario: Check if Page Segments are included onto the Page
Then the following questions should be displayed
         | Question             |
         | AutomatedTestSegment |

@Integration
Scenario: Check if Tempalte Populator populates First name
When I complete the form
And I populate the following questions
| Question  | Data     |
| FirstName | Selenium |
And I click Next expecting an accordion transition
Then the following questions should have the following information
| Question    | Data     |
| TestSegment | Selenium |

@Integration
Scenario: Check if Template Populator populates conditional statements
When I complete the form
And I populate the following questions
| Question              | Data |
| Tab2TemplatePopulator | Mr   |
And I click Next expecting an accordion transition
Then the following questions should have the following information
         | Question           | Data       |
         | ConditionalSegment | it exists! |

@Integration
Scenario: Check if Template Populator populates conditional statements (negative test)
When I complete the form
And I click Next expecting an accordion transition
Then the following questions should have the following information
         | Question           | Data               |
         | ConditionalSegment | it does not exist! |
 

