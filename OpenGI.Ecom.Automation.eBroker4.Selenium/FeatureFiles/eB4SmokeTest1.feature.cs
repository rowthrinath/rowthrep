﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OpenGI.Ecom.Automation.eBrokerDemo.Selenium.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("eBroker4 SmokeTest")]
    public partial class EBroker4SmokeTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "eB4SmokeTest.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "eBroker4 SmokeTest", "This test will be run to make a quick check on eBroker4 application to check if a" +
                    "n user can generate a quote", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
testRunner.Given("I have launched in to eBrokerDemo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("I should see 4 tabs on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Tab"});
            table1.AddRow(new string[] {
                        "POLICY"});
            table1.AddRow(new string[] {
                        "VEHICLE"});
            table1.AddRow(new string[] {
                        "DRIVER"});
            table1.AddRow(new string[] {
                        "QUOTE"});
#line 8
 testRunner.And("I should see the following tabs", ((string)(null)), table1, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Fill in all pages and get to Summary page")]
        [NUnit.Framework.CategoryAttribute("eBroker4SmokeTest")]
        public virtual void _01FillInAllPagesAndGetToSummaryPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Fill in all pages and get to Summary page", new string[] {
                        "eBroker4SmokeTest"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 18
testRunner.Then("I should be on the POLICY tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table2.AddRow(new string[] {
                        "TitleButton",
                        "Mr"});
#line 19
testRunner.When("I click the following buttons", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table3.AddRow(new string[] {
                        "FirstName",
                        "Test"});
            table3.AddRow(new string[] {
                        "Surname",
                        "Test"});
            table3.AddRow(new string[] {
                        "ContactNumber",
                        "012347566"});
            table3.AddRow(new string[] {
                        "CoverStartDate",
                        "11/11/2016"});
            table3.AddRow(new string[] {
                        "PrimaryEmail",
                        "test@test.com"});
#line 22
testRunner.When("I populate the following questions", ((string)(null)), table3, "When ");
#line 29
testRunner.When("I click Next expecting an accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.Then("I should be on the VEHICLE tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table4.AddRow(new string[] {
                        "Are_you_the_owner_and_keeper_Button",
                        "Yes"});
#line 32
testRunner.When("I click the following buttons", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table5.AddRow(new string[] {
                        "When_was_your_car_purchased_DateInput",
                        "01/01/2001"});
#line 35
testRunner.When("I populate the following questions", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table6.AddRow(new string[] {
                        "Where_do_you_park_your_car_overnight_Button",
                        "Other"});
#line 38
testRunner.When("I click the following buttons", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table7.AddRow(new string[] {
                        "Where_do_you_park_your_car_overnight_SelectOther",
                        "UnlockedBuilding"});
#line 41
testRunner.When("I select the following questions", ((string)(null)), table7, "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table8.AddRow(new string[] {
                        "Your_Level_Of_Cover_Button",
                        "Comprehensive"});
#line 44
testRunner.When("I click the following buttons", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table9.AddRow(new string[] {
                        "Do_You_Require_Windscreen_Button",
                        "Yes"});
#line 47
testRunner.When("I click the following buttons", ((string)(null)), table9, "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table10.AddRow(new string[] {
                        "Your_Voluntary_Excess_Select",
                        "£50"});
            table10.AddRow(new string[] {
                        "Your_NCB_Select",
                        "3"});
#line 50
testRunner.When("I select the following questions", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table11.AddRow(new string[] {
                        "Would_you_protect_your_NCB_Button",
                        "Yes"});
#line 54
testRunner.When("I click the following buttons", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table12.AddRow(new string[] {
                        "Where_Did_you_earn_your_NCB_Select",
                        "United Kingdom"});
#line 57
testRunner.When("I select the following questions", ((string)(null)), table12, "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table13.AddRow(new string[] {
                        "What_type_of_car_did_you_earn_NCB_Select",
                        "Private Car"});
#line 60
testRunner.When("I select the following questions", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table14.AddRow(new string[] {
                        "Who_will_be_insured_to_drive_the_car_Select",
                        "Insured Only"});
#line 63
testRunner.When("I select the following questions", ((string)(null)), table14, "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table15.AddRow(new string[] {
                        "Additional_drivers_Button",
                        "Zero"});
#line 66
testRunner.When("I click the following buttons", ((string)(null)), table15, "When ");
#line 69
testRunner.When("I click Next expecting an accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
testRunner.Then("I should be on the DRIVER tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table16.AddRow(new string[] {
                        "DateOfBirth_Input",
                        "01/01/1977"});
#line 72
testRunner.When("I populate the following questions", ((string)(null)), table16, "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table17.AddRow(new string[] {
                        "MaritalStatus_Button",
                        "Married"});
#line 75
testRunner.When("I click the following buttons", ((string)(null)), table17, "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table18.AddRow(new string[] {
                        "HowLongLiveUK_Input",
                        "15"});
#line 78
testRunner.When("I populate the following questions", ((string)(null)), table18, "When ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table19.AddRow(new string[] {
                        "YourPolicyStatus_Button",
                        "Frequent"});
#line 81
testRunner.When("I click the following buttons", ((string)(null)), table19, "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table20.AddRow(new string[] {
                        "YourLicenceType_Button",
                        "Other"});
#line 84
testRunner.When("I click the following buttons", ((string)(null)), table20, "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table21.AddRow(new string[] {
                        "YourLicenceType_Other_Option",
                        "Never Held"});
            table21.AddRow(new string[] {
                        "WhereWasLicenceIssued_Option",
                        "United Kingdom"});
#line 87
testRunner.When("I select the following questions", ((string)(null)), table21, "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table22.AddRow(new string[] {
                        "HowLongHeldYourLicence_Input",
                        "5"});
#line 91
testRunner.When("I populate the following questions", ((string)(null)), table22, "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table23.AddRow(new string[] {
                        "HowLongHeldYourLicence_Button",
                        "Years"});
            table23.AddRow(new string[] {
                        "Do_you_drive_another_vehicle_Button",
                        "Yes"});
#line 94
testRunner.When("I click the following buttons", ((string)(null)), table23, "When ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table24.AddRow(new string[] {
                        "Do_you_drive_Company_vehicle_Button",
                        "Yes"});
            table24.AddRow(new string[] {
                        "Are_you_the_only_one_drives_Company_vehicle_Button",
                        "Yes"});
#line 98
testRunner.When("I click the following buttons", ((string)(null)), table24, "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table25.AddRow(new string[] {
                        "How_long_have_been_driving_company_vehicle_Input",
                        "5"});
#line 102
testRunner.When("I populate the following questions", ((string)(null)), table25, "When ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table26.AddRow(new string[] {
                        "Have_you_had_any_accidents_Button",
                        "Yes"});
            table26.AddRow(new string[] {
                        "Accidents_was_the_accident_your_fault_Button",
                        "Yes"});
#line 106
testRunner.When("I click the following buttons", ((string)(null)), table26, "When ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table27.AddRow(new string[] {
                        "What_type_of_incident_occured_Option",
                        "Accident"});
            table27.AddRow(new string[] {
                        "What_were_the_details_of_accident_Option",
                        "Hit TP in Front"});
#line 110
testRunner.When("I select the following questions", ((string)(null)), table27, "When ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table28.AddRow(new string[] {
                        "Which_policy_was_the_accident_against_Button",
                        "Company"});
            table28.AddRow(new string[] {
                        "Was_your_NCB_lost_Button",
                        "Yes"});
            table28.AddRow(new string[] {
                        "Did_Accident_cause_bodily_injury_Button",
                        "Yes"});
#line 114
testRunner.When("I click the following buttons", ((string)(null)), table28, "When ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table29.AddRow(new string[] {
                        "What_was_the_value_of_personal_injury_settlement_Input",
                        "1000"});
            table29.AddRow(new string[] {
                        "When_did_accident_occur_Input",
                        "01/01/2000"});
            table29.AddRow(new string[] {
                        "Cost_recovered_from_third_party_Input",
                        "800"});
            table29.AddRow(new string[] {
                        "Total_value_of_claim_Input",
                        "1500"});
#line 119
testRunner.When("I populate the following questions", ((string)(null)), table29, "When ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table30.AddRow(new string[] {
                        "Has_this_claim_been_settled_Button",
                        "Yes"});
#line 125
testRunner.When("I click the following buttons", ((string)(null)), table30, "When ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table31.AddRow(new string[] {
                        "Have_you_had_any_convictions_in_5years_Button",
                        "Yes"});
#line 128
testRunner.When("I click the following buttons", ((string)(null)), table31, "When ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table32.AddRow(new string[] {
                        "What_was_the_date_of_conviction_Input",
                        "01/01/2010"});
            table32.AddRow(new string[] {
                        "Fine_Input",
                        "1000"});
            table32.AddRow(new string[] {
                        "Points_Input",
                        "6"});
            table32.AddRow(new string[] {
                        "Period_of_disqualification_Input",
                        "3"});
            table32.AddRow(new string[] {
                        "Offence_code_number_Input",
                        "22"});
#line 131
testRunner.When("I populate the following questions", ((string)(null)), table32, "When ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table33.AddRow(new string[] {
                        "Period_of_disqualification_units_Button",
                        "Months"});
#line 138
testRunner.When("I click the following buttons", ((string)(null)), table33, "When ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table34.AddRow(new string[] {
                        "Offence_code_Option",
                        "AC"});
#line 141
testRunner.When("I select the following questions", ((string)(null)), table34, "When ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table35.AddRow(new string[] {
                        "Do_you_suffer_from_medical_condition_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Do_you_more_than_one_disability_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Are_you_restricted_only_drive_automatic_vehicle_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Do_you_require_modified_hand_controls_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Do_you_require_wheel_knob_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Do_you_suffer_from_diabetes_Button",
                        "Yes"});
            table35.AddRow(new string[] {
                        "Do_you_have_history_of_diabetes_attacks_coma_Button",
                        "Yes"});
#line 144
testRunner.When("I click the following buttons", ((string)(null)), table35, "When ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table36.AddRow(new string[] {
                        "How_is_your_diabetes_controlled_Option",
                        "1-30 Units Insulin"});
#line 153
testRunner.When("I select the following questions", ((string)(null)), table36, "When ");
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table37.AddRow(new string[] {
                        "When_did_your_diabetes_start_Input",
                        "01/01/2000"});
            table37.AddRow(new string[] {
                        "When_did_your_diabetes_become_stable_Input",
                        "01/01/2001"});
#line 156
testRunner.When("I populate the following questions", ((string)(null)), table37, "When ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table38.AddRow(new string[] {
                        "Do_you_suffer_from_hearingsightloss_Button",
                        "Yes"});
#line 160
testRunner.When("I click the following buttons", ((string)(null)), table38, "When ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table39.AddRow(new string[] {
                        "When_did_your_sight_loss_begin_Input",
                        "01/01/2002"});
            table39.AddRow(new string[] {
                        "Percentage_loss_in_left_eye_Input",
                        "15"});
            table39.AddRow(new string[] {
                        "Percentage_loss_in_right_eye_Input",
                        "15"});
#line 163
testRunner.When("I populate the following questions", ((string)(null)), table39, "When ");
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table40.AddRow(new string[] {
                        "Is_your_sight_problem_disease_Button",
                        "Yes"});
#line 168
testRunner.When("I click the following buttons", ((string)(null)), table40, "When ");
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table41.AddRow(new string[] {
                        "When_did_your_hearing_loss_begin_Input",
                        "01/01/2003"});
            table41.AddRow(new string[] {
                        "Percentage_loss_in_left_ear_Input",
                        "2"});
            table41.AddRow(new string[] {
                        "Percentage_loss_in_right_ear_Input",
                        "2"});
#line 171
testRunner.When("I populate the following questions", ((string)(null)), table41, "When ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table42.AddRow(new string[] {
                        "Is_your_hearing_disease_related_Button",
                        "Yes"});
#line 176
testRunner.When("I click the following buttons", ((string)(null)), table42, "When ");
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table43.AddRow(new string[] {
                        "Have_you_lost_a_limb_Button",
                        "Yes"});
#line 179
testRunner.When("I click the following buttons", ((string)(null)), table43, "When ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table44.AddRow(new string[] {
                        "When_did_you_lose_your_arm_Button",
                        "01/01/2014"});
#line 182
testRunner.When("I populate the following questions", ((string)(null)), table44, "When ");
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table45.AddRow(new string[] {
                        "Which_arm_is_affected_Button",
                        "Both"});
            table45.AddRow(new string[] {
                        "Is_the_problem_with_your_arm_disease_related_Button",
                        "Yes"});
#line 185
testRunner.When("I click the following buttons", ((string)(null)), table45, "When ");
#line hidden
            TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table46.AddRow(new string[] {
                        "When_did_you_lose_your_leg_Button",
                        "01/01/2015"});
#line 189
testRunner.When("I populate the following questions", ((string)(null)), table46, "When ");
#line hidden
            TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table47.AddRow(new string[] {
                        "Which_leg_is_affected_Button",
                        "Both"});
            table47.AddRow(new string[] {
                        "Is_the_problem_with_your_leg_disease_related_Button",
                        "Yes"});
            table47.AddRow(new string[] {
                        "Do_you_suffer_from_another_illness_Button",
                        "Yes"});
#line 192
testRunner.When("I click the following buttons", ((string)(null)), table47, "When ");
#line hidden
            TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table48.AddRow(new string[] {
                        "Type_of_illness_Option",
                        "Alcoholism"});
#line 197
testRunner.When("I select the following questions", ((string)(null)), table48, "When ");
#line hidden
            TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table49.AddRow(new string[] {
                        "When_did_the_illness_start_Input",
                        "01/01/1990"});
            table49.AddRow(new string[] {
                        "When_did_the_illness_become_stable_Input",
                        "01/01/2000"});
#line 200
testRunner.When("I populate the following questions", ((string)(null)), table49, "When ");
#line hidden
            TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table50.AddRow(new string[] {
                        "What_will_you_be_using_car_for_Button",
                        "Business Use"});
#line 204
testRunner.When("I click the following buttons", ((string)(null)), table50, "When ");
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table51.AddRow(new string[] {
                        "Private_mileage_Input",
                        "10000"});
            table51.AddRow(new string[] {
                        "Business_mileage_Input",
                        "10000"});
#line 207
testRunner.When("I populate the following questions", ((string)(null)), table51, "When ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table52.AddRow(new string[] {
                        "Has_anyone_on_policy_ever_been_refused_insurance_Button",
                        "Yes"});
            table52.AddRow(new string[] {
                        "Have_you_ever_held_insurance_before_Button",
                        "Yes"});
            table52.AddRow(new string[] {
                        "Have_you_ever_held_insurance_before_Button",
                        "Yes"});
#line 211
testRunner.When("I click the following buttons", ((string)(null)), table52, "When ");
#line hidden
            TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table53.AddRow(new string[] {
                        "Who_was_your_previous_insurer_Option",
                        "Admiral Insurance"});
#line 216
testRunner.When("I select the following questions", ((string)(null)), table53, "When ");
#line hidden
            TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table54.AddRow(new string[] {
                        "How_long_since_your_previous_insurer_Input",
                        "4"});
#line 219
testRunner.When("I populate the following questions", ((string)(null)), table54, "When ");
#line 222
testRunner.When("I click Next expecting an accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 223
testRunner.Then("I should be on the QUOTE tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion