using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.eBroker.Selenium.PageObjects
{
    public class Driver1Page : eBrokerDemoBaseDataCapturePage
    {
        public Driver1Page(IWebDriver driver, ScenarioContext scenarioContext) : base(driver, scenarioContext, null)
        { }


        [ErrorPanel(How.CssSelector, "[model='vm.data.person.dateOfBirth.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.dateOfBirth.value'] label")]
        public IWebElement DateOfBirth_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.dateOfBirth.value'] input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.dateOfBirth.value'] input")]
        public IWebElement DateOfBirth_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.maritalStatus.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model = 'vm.data.person.maritalStatus.vt'] label")]
        public IWebElement MaritalStatus_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.maritalStatus.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.maritalStatus.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.maritalStatus.vt'] div.cmpInputButtonGroup button")]
        public IWebElement MaritalStatus_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.resPeriod.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.resPeriod.value'] label")]
        public IWebElement HowLongLiveUK_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.resPeriod.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.resPeriod.value'] Input")]
        public IWebElement HowLongLiveUK_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.drvStatus.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.drvStatus.vt'] label")]
        public IWebElement YourPolicyStatus_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.drvStatus.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.drvStatus.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.drvStatus.vt'] div.cmpInputButtonGroup button")]
        public IWebElement YourPolicyStatus_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licType.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licType.vt'] label")]
        public IWebElement YourLicenceType_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licType.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licType.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licType.vt'] div.cmpInputButtonGroup button")]
        public IWebElement YourLicenceType_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model = 'vm.data.person.licType.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model = 'vm.data.person.licType.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement YourLicenceType_Other_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licCountry.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licCountry.vt'] label")]
        public IWebElement WhereWasLicenceIssued_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licCountry.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licCountry.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement WhereWasLicenceIssued_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licHeld.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licHeld.value'] label")]
        public IWebElement HowLongHeldYourLicence_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licHeld.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licHeld.value'] Input")]
        public IWebElement HowLongHeldYourLicence_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.licUnit.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licUnit.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.licUnit.vt'] div.cmpInputButtonGroup button")]
        public IWebElement HowLongHeldYourLicence_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.driveOthVehicles.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.driveOthVehicles.vt'] label")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.driveOthVehicles.vt'] label")]
        public IWebElement Do_you_drive_another_vehicle_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.driveOthVehicles.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.driveOthVehicles.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.driveOthVehicles.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_drive_another_vehicle_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.otherCompanyVehInd.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehInd.vt'] label")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehInd.vt'] label")]
        public IWebElement Do_you_drive_Company_vehicle_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.otherCompanyVehInd.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehInd.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehInd.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_drive_Company_vehicle_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.otherCompanyVehSoleUse.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehSoleUse.vt'] label")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehSoleUse.vt'] label")]
        public IWebElement Are_you_the_only_one_drives_Company_vehicle_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.otherCompanyVehSoleUse.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehSoleUse.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehSoleUse.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Are_you_the_only_one_drives_Company_vehicle_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.otherCompanyVehYears.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.otherCompanyVehYears.value'] Input")]
        public IWebElement How_long_have_been_driving_company_vehicle_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hasAccidents.vt')] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.numberOfPeople.value')] label")]
        public IWebElement Have_you_had_any_accidents_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hasAccidents.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hasAccidents.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hasAccidents.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Have_you_had_any_accidents_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.atFault.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.atFault.vt'] label")]
        public IWebElement Accidents_was_the_accident_your_fault_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.atFault.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.atFault.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.atFault.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Accidents_was_the_accident_your_fault_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.clmType.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.clmType.vt'] label")]
        public IWebElement What_type_of_incident_occured_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.clmType.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.clmType.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement What_type_of_incident_occured_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.incidentType.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.incidentType.vt'] label")]
        public IWebElement What_were_the_details_of_accident_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.incidentType.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.incidentType.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement What_were_the_details_of_accident_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.incidentPolicy.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.incidentPolicy.vt'] label")]
        public IWebElement Which_policy_was_the_accident_against_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.incidentPolicy.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.incidentPolicy.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.incidentPolicy.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Which_policy_was_the_accident_against_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.nCBAff.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.nCBAff.vt'] label")]
        public IWebElement Was_your_NCB_lost_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.nCBAff.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.nCBAff.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.nCBAff.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Was_your_NCB_lost_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.bodilyInj.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.bodilyInj.vt'] label")]
        public IWebElement Did_Accident_cause_bodily_injury_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.bodilyInj.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.bodilyInj.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.bodilyInj.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Did_Accident_cause_bodily_injury_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.tPSettlement.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.tPSettlement.value'] Input")]
        public IWebElement What_was_the_value_of_personal_injury_settlement_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.date.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.date.value'] Input")]
        public IWebElement When_did_accident_occur_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.percentRecovered.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.percentRecovered.value'] Input")]
        public IWebElement Cost_recovered_from_third_party_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.claimValue.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.claimValue.value'] Input")]
        public IWebElement Total_value_of_claim_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.claimSettled.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.claimSettled.vt'] label")]
        public IWebElement Has_this_claim_been_settled_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.claimSettled.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.claimSettled.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.claimSettled.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Has_this_claim_been_settled_Button { get; set; }

        [ErrorPanel(How.XPath, "//*[@id='main']/div/form/div[1]/cmp-input-info[3]/div/md-content/md-content/div/div[2]/button")]
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/div/form/div[1]/cmp-input-info[3]/div/md-content/md-content/div/div[2]/button")]
        [SelectorFindsBy(How = How.XPath, Using = "//*[@id='main']/div/form/div[1]/cmp-input-info[3]/div/md-content/md-content/div/div[2]/button")]
        public IWebElement Add_Accident_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hasConvictions.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hasConvictions.vt'] label")]
        public IWebElement Have_you_had_any_convictions_in_5years_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hasConvictions.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hasConvictions.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hasConvictions.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Have_you_had_any_convictions_in_5years_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.convictionDate.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.convictionDate.value'] label")]
        public IWebElement What_was_the_date_of_conviction_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.convictionDate.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.convictionDate.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.convictionDate.value'] Input")]
        public IWebElement What_was_the_date_of_conviction_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.fine.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.fine.value'] label")]
        public IWebElement Fine_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.fine.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.fine.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.fine.value'] Input")]
        public IWebElement Fine_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.points.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.points.value'] label")]
        public IWebElement Points_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.points.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.points.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.points.value'] Input")]
        public IWebElement Points_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.disqualificationPeriod.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.disqualificationPeriod.value'] label")]
        public IWebElement Period_of_disqualification_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.disqualificationPeriod.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.disqualificationPeriod.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.disqualificationPeriod.value'] Input")]
        public IWebElement Period_of_disqualification_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.disqualificationPeriodUnit.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.disqualificationPeriodUnit.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.disqualificationPeriodUnit.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Period_of_disqualification_units_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.offenceCode.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.offenceCode.vt'] label")]
        public IWebElement Offence_code_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.offenceCode.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.offenceCode.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Offence_code_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.offenceCodeNumber.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.offenceCodeNumber.value'] label")]
        public IWebElement Offence_code_number_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.offenceCodeNumber.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.offenceCodeNumber.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.offenceCodeNumber.value'] Input")]
        public IWebElement Offence_code_number_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.infInd.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.infInd.vt'] label")]
        public IWebElement Do_you_suffer_from_medical_condition_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.infInd.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.infInd.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.infInd.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_suffer_from_medical_condition_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.multipleDisabilities.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.multipleDisabilities.vt'] label")]
        public IWebElement Do_you_more_than_one_disability_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.multipleDisabilities.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.multipleDisabilities.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.multipleDisabilities.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_more_than_one_disability_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.autosOnly.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.autosOnly.vt'] label")]
        public IWebElement Are_you_restricted_only_drive_automatic_vehicle_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.autosOnly.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.autosOnly.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.autosOnly.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Are_you_restricted_only_drive_automatic_vehicle_Button { get; set; }


        [ErrorPanel(How.CssSelector, "[model='dModel.handControls.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.handControls.vt'] label")]
        public IWebElement Do_you_require_modified_hand_controls_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.handControls.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.handControls.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.handControls.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_require_modified_hand_controls_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.wheelKnob.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.wheelKnob.vt'] label")]
        public IWebElement Do_you_require_wheel_knob_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.wheelKnob.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.wheelKnob.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.wheelKnob.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_require_wheel_knob_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.isDiabetic.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.isDiabetic.vt'] label")]
        public IWebElement Do_you_suffer_from_diabetes_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.isDiabetic.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.isDiabetic.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.isDiabetic.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_suffer_from_diabetes_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabAttacks.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabAttacks.vt'] label")]
        public IWebElement Do_you_have_history_of_diabetes_attacks_coma_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabAttacks.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabAttacks.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.diabAttacks.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_have_history_of_diabetes_attacks_coma_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabControl.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabControl.vt'] label")]
        public IWebElement How_is_your_diabetes_controlled_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabControl.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabControl.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement How_is_your_diabetes_controlled_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabDSO.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSO.value'] label")]
        public IWebElement When_did_your_diabetes_start_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabDSO.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSO.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSO.value'] Input")]
        public IWebElement When_did_your_diabetes_start_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabDSS.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSS.value'] label")]
        public IWebElement When_did_your_diabetes_become_stable_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.diabDSS.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSS.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.diabDSS.value'] Input")]
        public IWebElement When_did_your_diabetes_become_stable_Input { get; set; }


        [ErrorPanel(How.CssSelector, "[model='dModel.hearingSightLoss.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingSightLoss.vt'] label")]
        public IWebElement Do_you_suffer_from_hearingsightloss_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingSightLoss.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingSightLoss.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hearingSightLoss.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_suffer_from_hearingsightloss_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeDSO.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDSO.value'] label")]
        public IWebElement When_did_your_sight_loss_begin_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeDSO.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDSO.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDSO.value'] Input")]
        public IWebElement When_did_your_sight_loss_begin_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeLeft.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeLeft.value'] label")]
        public IWebElement Percentage_loss_in_left_eye_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeLeft.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeLeft.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.eyeLeft.value'] Input")]
        public IWebElement Percentage_loss_in_left_eye_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeRight.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeRight.value'] label")]
        public IWebElement Percentage_loss_in_right_eye_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeRight.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeRight.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.eyeRight.value'] Input")]
        public IWebElement Percentage_loss_in_right_eye_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeDisease.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDisease.vt'] label")]
        public IWebElement Is_your_sight_problem_disease_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeDisease.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDisease.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.eyeDisease.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Is_your_sight_problem_disease_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingDSO.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDSO.value'] label")]
        public IWebElement When_did_your_hearing_loss_begin_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingDSO.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDSO.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDSO.value'] Input")]
        public IWebElement When_did_your_hearing_loss_begin_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.eyeLeft.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.eyeLeft.value'] label")]
        public IWebElement Percentage_loss_in_left_ear_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingLeft.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingLeft.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hearingLeft.value'] Input")]
        public IWebElement Percentage_loss_in_left_ear_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingRight.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingRight.value'] label")]
        public IWebElement Percentage_loss_in_right_ear_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingRight.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingRight.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hearingRight.value'] Input")]
        public IWebElement Percentage_loss_in_right_ear_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingDisease.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDisease.vt'] label")]
        public IWebElement Is_your_hearing_disease_related_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.hearingDisease.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDisease.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.hearingDisease.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Is_your_hearing_disease_related_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armLegLoss.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armLegLoss.vt'] label")]
        public IWebElement Have_you_lost_a_limb_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armLegLoss.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armLegLoss.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.armLegLoss.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Have_you_lost_a_limb_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armDSO.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armDSO.value'] label")]
        public IWebElement When_did_you_lose_your_arm_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armDSO.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armDSO.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.armDSO.value'] Input")]
        public IWebElement When_did_you_lose_your_arm_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.whichArm.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.whichArm.vt'] label")]
        public IWebElement Which_arm_is_affected_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.whichArm.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.whichArm.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.whichArm.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Which_arm_is_affected_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armDisease.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armDisease.vt'] label")]
        public IWebElement Is_the_problem_with_your_arm_disease_related_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.armDisease.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.armDisease.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.armDisease.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Is_the_problem_with_your_arm_disease_related_Button { get; set; }


        [ErrorPanel(How.CssSelector, "[model='dModel.legDSO.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.legDSO.value'] label")]
        public IWebElement When_did_you_lose_your_leg_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.legDSO.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.legDSO.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.legDSO.value'] Input")]
        public IWebElement When_did_you_lose_your_leg_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.whichLeg.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.whichLeg.vt'] label")]
        public IWebElement Which_leg_is_affected_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.whichLeg.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.whichLeg.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.whichLeg.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Which_leg_is_affected_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.legDisease.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.legDisease.vt'] label")]
        public IWebElement Is_the_problem_with_your_leg_disease_related_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.legDisease.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.legDisease.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.legDisease.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Is_the_problem_with_your_leg_disease_related_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.otherInf.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.otherInf.vt'] label")]
        public IWebElement Do_you_suffer_from_another_illness_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.otherInf.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.otherInf.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.otherInf.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_you_suffer_from_another_illness_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscInfirmity.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscInfirmity.vt'] label")]
        public IWebElement Type_of_illness_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscInfirmity.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscInfirmity.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Type_of_illness_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscDateSinceOnset.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscDateSinceOnset.value'] label")]
        public IWebElement When_did_the_illness_start_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscDateSinceOnset.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscDateSinceOnset.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.miscDateSinceOnset.value'] Input")]
        public IWebElement When_did_the_illness_start_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscDSS.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscDSS.value'] label")]
        public IWebElement When_did_the_illness_become_stable_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='dModel.miscDSS.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='dModel.miscDSS.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='dModel.miscDSS.value'] Input")]
        public IWebElement When_did_the_illness_become_stable_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.carUsage'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.carUsage'] label")]
        public IWebElement What_will_you_be_using_car_for_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.carUsage'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.carUsage'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.carUsage'] div.cmpInputButtonGroup button")]
        public IWebElement What_will_you_be_using_car_for_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.privateMileage.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.privateMileage.value'] label")]
        public IWebElement Private_mileage_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.privateMileage.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.privateMileage.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.privateMileage.value'] Input")]
        public IWebElement Private_mileage_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.businessMileage.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.businessMileage.value'] label")]
        public IWebElement Business_mileage_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.businessMileage.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.businessMileage.value'] Input")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.person.businessMileage.value'] Input")]
        public IWebElement Business_mileage_Input { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.insRefused.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.insRefused.vt'] label")]
        public IWebElement Has_anyone_on_policy_ever_been_refused_insurance_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.insRefused.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.insRefused.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.insRefused.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Has_anyone_on_policy_ever_been_refused_insurance_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.everInsured.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.everInsured.vt'] label")]
        public IWebElement Have_you_ever_held_insurance_before_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.everInsured.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.everInsured.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.everInsured.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Have_you_ever_held_insurance_before_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.prevInsurer.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.prevInsurer.vt'] label")]
        public IWebElement Who_was_your_previous_insurer_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.prevInsurer.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.prevInsurer.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Who_was_your_previous_insurer_Option { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.periodSinceInsurance.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.periodSinceInsurance.value'] label")]
        public IWebElement How_long_since_your_previous_insurer_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.periodSinceInsurance.value'] Input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.periodSinceInsurance.value'] Input")]
        public IWebElement How_long_since_your_previous_insurer_Input { get; set; }

        [ErrorPanel(How.CssSelector, "md-toolbar > button:nth-child(2)")]
        [FindsBy(How = How.CssSelector, Using = "md-toolbar > button:nth-child(2)")]
        [SelectorFindsBy(How = How.CssSelector, Using = "md-toolbar > button:nth-child(2)")]
        public IWebElement Driver_Next_Button { get; set; }

        public override void Visit()
        {
            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.XPath("//*[@id=\"main\"]/div/div/span")).Text.Trim() == "Your Car Details");

            base.Visit();
        }
        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            Driver_Next_Button.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var QuoteSummary = new QuoteSummaryPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, QuoteSummary);

                return QuoteSummary;
            }

            return this;

        }
        public override IDataCapturePage ClickBack(bool expectPreviousPage)
        {
            var tabOne = new PolicyPage(Driver, ScenarioContext);

            PageFactory.InitElements(Driver, tabOne);

            return tabOne;
        }
   
}
}
