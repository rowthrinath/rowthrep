Feature: eBroker4 SmokeTest
This test will be run to make a quick check on eBroker4 application to check if an user can generate a quote

Background: 
Given I have launched in to eBrokerDemo

	Then I should see 4 tabs on the page
	And I should see the following tabs
	| Tab     |
	| POLICY  |
	| VEHICLE |
	| DRIVER  |
	| QUOTE   |	

@eBroker4SmokeTest
Scenario:01 Fill in all pages and get to Summary page
###################################################
Then I should be on the POLICY tab
When I click the following buttons
		| Question    | Data |
		| TitleButton | Mr   |		
When I populate the following questions
         | Question       | Data          |
         | FirstName      | Test          |
         | Surname        | Test          |
         | ContactNumber  | 012347566     |
		 | CoverStartDate | 11/11/2016    |
         | PrimaryEmail   | test@test.com |
When I click Next expecting an accordion transition
###################################################
Then I should be on the VEHICLE tab
When I click the following buttons
		| Question                            | Data |
		| Are_you_the_owner_and_keeper_Button | Yes   |		
When I populate the following questions
         | Question                              | Data       |
         | When_was_your_car_purchased_DateInput | 01/01/2001 |		   
When I click the following buttons
		| Question                                    | Data  |
		| Where_do_you_park_your_car_overnight_Button | Other |		
When I select the following questions
        | Question                                         | Data             |
        | Where_do_you_park_your_car_overnight_SelectOther | UnlockedBuilding |		
When I click the following buttons
		| Question                   | Data          |
		| Your_Level_Of_Cover_Button | Comprehensive |		
When I click the following buttons
		| Question                         | Data |
		| Do_You_Require_Windscreen_Button | Yes  |		
When I select the following questions
         | Question                     | Data |
         | Your_Voluntary_Excess_Select | £50  |		 
         | Your_NCB_Select | 3            |          
When I click the following buttons
		| Question                          | Data |
		| Would_you_protect_your_NCB_Button | Yes  |		
When I select the following questions
         | Question                           | Data           |
         | Where_Did_you_earn_your_NCB_Select | United Kingdom |
When I select the following questions
         | Question                                 | Data        |
         | What_type_of_car_did_you_earn_NCB_Select | Private Car |		 
When I select the following questions
         | Question                                    | Data         |
         | Who_will_be_insured_to_drive_the_car_Select | Insured Only |		 
When I click the following buttons
		| Question                  | Data |
		| Additional_drivers_Button | Zero |		
When I click Next expecting an accordion transition
########################################################
Then I should be on the DRIVER tab
When I populate the following questions
         | Question          | Data       |
         | DateOfBirth_Input | 01/01/1977 |
When I click the following buttons
		| Question             | Data    |
		| MaritalStatus_Button | Married |		
When I populate the following questions
         | Question            | Data |
         | HowLongLiveUK_Input | 15   |
When I click the following buttons
		| Question                | Data     |
		| YourPolicyStatus_Button | Frequent |
When I click the following buttons
		| Question               | Data  |
		| YourLicenceType_Button | Other |		
When I select the following questions
         | Question                     | Data           |
         | YourLicenceType_Other_Option | Never Held     |
         | WhereWasLicenceIssued_Option | United Kingdom |
When I populate the following questions
         | Question                     | Data |
         | HowLongHeldYourLicence_Input | 5    |
When I click the following buttons
		| Question                      | Data  |
		| HowLongHeldYourLicence_Button | Years |	
		| Do_you_drive_another_vehicle_Button | Yes  |
When I click the following buttons
		| Question                            | Data |
		| Do_you_drive_Company_vehicle_Button | Yes  |		
 		| Are_you_the_only_one_drives_Company_vehicle_Button | Yes  |
When I populate the following questions
         | Question                                         | Data |
         | How_long_have_been_driving_company_vehicle_Input | 5    |

When I click the following buttons
		| Question                                     | Data |
		| Have_you_had_any_accidents_Button            | Yes  |
		| Accidents_was_the_accident_your_fault_Button | Yes  |	
When I select the following questions
         | Question                                 | Data            |
         | What_type_of_incident_occured_Option     | Accident        |
         | What_were_the_details_of_accident_Option | Hit TP in Front |
When I click the following buttons
		| Question                                     | Data    |
		| Which_policy_was_the_accident_against_Button | Company |
		| Was_your_NCB_lost_Button                     | Yes     |
		| Did_Accident_cause_bodily_injury_Button      | Yes     |
When I populate the following questions
         | Question                                               | Data       |
         | What_was_the_value_of_personal_injury_settlement_Input | 1000       |
         | When_did_accident_occur_Input                          | 01/01/2000 |
         | Cost_recovered_from_third_party_Input                  | 800        |
         | Total_value_of_claim_Input                             | 1500       |
When I click the following buttons
		| Question                                     | Data |
		| Has_this_claim_been_settled_Button           | Yes  |
When I click the following buttons
		| Question                                      | Data         |
		| Have_you_had_any_convictions_in_5years_Button | Yes          |
When I populate the following questions
         | Question                              | Data       |
         | What_was_the_date_of_conviction_Input | 01/01/2010 |
         | Fine_Input                            | 1000       |
         | Points_Input                          | 6          |
         | Period_of_disqualification_Input      | 3          |
         | Offence_code_number_Input             | 22         |
When I click the following buttons
		| Question                                | Data   |
		| Period_of_disqualification_units_Button | Months |
When I select the following questions
         | Question            | Data |
         | Offence_code_Option | AC   |
When I click the following buttons
		| Question                                               | Data |
		| Do_you_suffer_from_medical_condition_Button            | Yes  |
		| Do_you_more_than_one_disability_Button                 | Yes  |
		| Are_you_restricted_only_drive_automatic_vehicle_Button | Yes  |
		| Do_you_require_modified_hand_controls_Button           | Yes  |
		| Do_you_require_wheel_knob_Button                       | Yes  |
		| Do_you_suffer_from_diabetes_Button                     | Yes  |
		| Do_you_have_history_of_diabetes_attacks_coma_Button    | Yes  |
When I select the following questions
         | Question                               | Data               |
         | How_is_your_diabetes_controlled_Option | 1-30 Units Insulin |
When I populate the following questions
         | Question                                   | Data       |
         | When_did_your_diabetes_start_Input         | 01/01/2000 |
         | When_did_your_diabetes_become_stable_Input | 01/01/2001 |
When I click the following buttons
		| Question                                   | Data |
		| Do_you_suffer_from_hearingsightloss_Button | Yes  |
When I populate the following questions
         | Question                             | Data       |
         | When_did_your_sight_loss_begin_Input | 01/01/2002 |
         | Percentage_loss_in_left_eye_Input    | 15         |
         | Percentage_loss_in_right_eye_Input   | 15         |
When I click the following buttons
		| Question                             | Data |
		| Is_your_sight_problem_disease_Button | Yes  |
When I populate the following questions
         | Question                               | Data       |
         | When_did_your_hearing_loss_begin_Input | 01/01/2003 |
         | Percentage_loss_in_left_ear_Input      | 2          |
         | Percentage_loss_in_right_ear_Input     | 2          |				 		
When I click the following buttons
		| Question                               | Data |
		| Is_your_hearing_disease_related_Button | Yes  |
When I click the following buttons
		| Question                    | Data |
		| Have_you_lost_a_limb_Button | Yes  |
When I populate the following questions
         | Question                          | Data       |
         | When_did_you_lose_your_arm_Button | 01/01/2014 |		
When I click the following buttons
		| Question                                            | Data |
		| Which_arm_is_affected_Button                        | Both |
		| Is_the_problem_with_your_arm_disease_related_Button | Yes  |
When I populate the following questions
         | Question                          | Data       |
         | When_did_you_lose_your_leg_Button | 01/01/2015 |
When I click the following buttons
		| Question                                            | Data |
		| Which_leg_is_affected_Button                        | Both |
		| Is_the_problem_with_your_leg_disease_related_Button | Yes  |
		| Do_you_suffer_from_another_illness_Button           | Yes  |
When I select the following questions
         | Question               | Data       |
         | Type_of_illness_Option | Alcoholism |
When I populate the following questions
         | Question                                 | Data       |
         | When_did_the_illness_start_Input         | 01/01/1990 |
         | When_did_the_illness_become_stable_Input | 01/01/2000 |
When I click the following buttons
		| Question                              | Data         |
		| What_will_you_be_using_car_for_Button | Business Use |
When I populate the following questions
         | Question               | Data  |
         | Private_mileage_Input  | 10000 |
         | Business_mileage_Input | 10000 |
When I click the following buttons
		| Question                                                | Data |
		| Has_anyone_on_policy_ever_been_refused_insurance_Button | Yes  |
		| Have_you_ever_held_insurance_before_Button              | Yes  |
		| Have_you_ever_held_insurance_before_Button              | Yes  |
When I select the following questions
         | Question                             | Data              |
         | Who_was_your_previous_insurer_Option | Admiral Insurance |
When I populate the following questions
         | Question                                   | Data |
         | How_long_since_your_previous_insurer_Input | 4    |		 
When I click Next expecting an accordion transition		
Then I should be on the QUOTE tab