Feature: Tab Tests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:
	Given I have launched in to Vanilla
	When I clear the current form

@Integration
Scenario: Check Tab One tab is highlighted when on tab one
	Then tab 1 should be highlighted
