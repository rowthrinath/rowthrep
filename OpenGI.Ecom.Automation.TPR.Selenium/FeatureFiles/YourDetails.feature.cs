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
namespace OpenGI.Ecom.Automation.TPR.Selenium.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Your Details")]
    public partial class YourDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "YourDetails.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Your Details", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
#line 7
 testRunner.Given("I have launched in to TPR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the correct questions are displayed on the Your Details accordion")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheCorrectQuestionsAreDisplayedOnTheYourDetailsAccordion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the correct questions are displayed on the Your Details accordion", new string[] {
                        "Integration"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
 testRunner.Then("I should see 6 questions on the current accordion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table1.AddRow(new string[] {
                        "Title"});
            table1.AddRow(new string[] {
                        "FirstName"});
            table1.AddRow(new string[] {
                        "Surname"});
            table1.AddRow(new string[] {
                        "Email"});
            table1.AddRow(new string[] {
                        "HomePhone"});
            table1.AddRow(new string[] {
                        "AlternatePhone"});
#line 12
 testRunner.And("the following questions should be displayed", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details Title question is mandatory")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheYourDetailsTitleQuestionIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details Title question is mandatory", new string[] {
                        "Integration"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Comments"});
            table2.AddRow(new string[] {
                        "FirstName",
                        "Could these use a default attribute?"});
            table2.AddRow(new string[] {
                        "Surname",
                        ""});
#line 23
 testRunner.When("I populate the following questions", ((string)(null)), table2, "When ");
#line 27
 testRunner.And("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table3.AddRow(new string[] {
                        "Title"});
#line 28
 testRunner.Then("the following questions should have an error displayed", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details First Name question is mandatory")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheYourDetailsFirstNameQuestionIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details First Name question is mandatory", new string[] {
                        "Integration"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Comments"});
            table4.AddRow(new string[] {
                        "Title",
                        "Could these use a default attribute?"});
            table4.AddRow(new string[] {
                        "Surname",
                        ""});
#line 34
 testRunner.When("I populate the following questions", ((string)(null)), table4, "When ");
#line 38
 testRunner.And("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table5.AddRow(new string[] {
                        "FirstName"});
#line 39
 testRunner.Then("the following questions should have an error displayed", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details Surname question is mandatory")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheYourDetailsSurnameQuestionIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details Surname question is mandatory", new string[] {
                        "Integration"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Comments"});
            table6.AddRow(new string[] {
                        "Title",
                        "Could these use a default attribute?"});
            table6.AddRow(new string[] {
                        "FirstName",
                        ""});
#line 45
 testRunner.When("I populate the following questions", ((string)(null)), table6, "When ");
#line 49
 testRunner.And("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table7.AddRow(new string[] {
                        "Surname"});
#line 50
 testRunner.Then("the following questions should have an error displayed", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details Email question is mandatory")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheYourDetailsEmailQuestionIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details Email question is mandatory", new string[] {
                        "Integration"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 56
 testRunner.When("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table8.AddRow(new string[] {
                        "Email"});
#line 57
 testRunner.Then("the following questions should have an error displayed", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details questions have to correct format validation")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        [NUnit.Framework.TestCaseAttribute("Email", "open@gi", new string[0])]
        [NUnit.Framework.TestCaseAttribute("HomePhone", "012345678", new string[0])]
        [NUnit.Framework.TestCaseAttribute("HomePhone", "1234567890", new string[0])]
        [NUnit.Framework.TestCaseAttribute("AlternatePhone", "012345678", new string[0])]
        [NUnit.Framework.TestCaseAttribute("AlternatePhone", "1234567890", new string[0])]
        public virtual void CheckTheYourDetailsQuestionsHaveToCorrectFormatValidation(string question, string data, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Integration"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details questions have to correct format validation", @__tags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 63
 testRunner.When("I complete the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Data"});
            table9.AddRow(new string[] {
                        string.Format("{0}", question),
                        string.Format("{0}", data)});
#line 64
 testRunner.And("I populate the following questions", ((string)(null)), table9, "And ");
#line 67
 testRunner.And("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table10.AddRow(new string[] {
                        string.Format("{0}", question)});
#line 68
 testRunner.Then("the following questions should have an error displayed", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the Your Details Home Phone question is mandatory")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckTheYourDetailsHomePhoneQuestionIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the Your Details Home Phone question is mandatory", new string[] {
                        "Integration"});
#line 81
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 82
 testRunner.When("I click Next expecting no accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question"});
            table11.AddRow(new string[] {
                        "HomePhone"});
#line 83
 testRunner.Then("the following questions should be displayed", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check completing the Your Details accordion moves to the Further Information acco" +
            "rdion")]
        [NUnit.Framework.CategoryAttribute("Integration")]
        public virtual void CheckCompletingTheYourDetailsAccordionMovesToTheFurtherInformationAccordion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check completing the Your Details accordion moves to the Further Information acco" +
                    "rdion", new string[] {
                        "Integration"});
#line 88
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 89
 testRunner.When("I complete the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.And("I click Next expecting an accordion transition", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("I should move to the Further Information accordion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
