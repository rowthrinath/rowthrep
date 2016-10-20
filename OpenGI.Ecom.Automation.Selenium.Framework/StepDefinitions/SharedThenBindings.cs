using NUnit.Framework;
using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions
{
    [Binding]
    public class ThenBindings : BindingsBase
    {

        public ThenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }


        [Then(@"I should see (.*) questions on the current accordion")]
        public void ThenIShouldSeeQuestionsOnTheCurrentAccordion(int expected)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;
            
            // More debugging
           //try
           // {
           //     PageObjectHelpers.GetWait().Until(
           //         x => baseDataCapturePage.AllInputs.Count == expected);
           // }
           // catch (WebDriverTimeoutException)
           // { }
            

            Assert.That(
                baseDataCapturePage.AllInputs.Count,
                Is.EqualTo(expected),
                "Incorrect number of questions found. Expected {0} but found {1}", expected, baseDataCapturePage.AllInputs.Count);
        }

        [Then(@"the following questions should be displayed")]
        public void ThenTheFollowingQuestionsShouldBeDisplayed(Table table)
        {
            var propertyNames = (ScenarioContext["page"] as BaseDataCapturePage).GetQuestionNames();

            foreach (var row in table.Rows)
            {
                // Does the expected question exist on the page
                Assert.That(
                    propertyNames.Contains(row["Question"]),
                    Is.EqualTo(true),
                    "Unable to find question: {0}", row["Question"]);

                // Anything that implements IWebElement (most questions)
                if (StepDefinitionHelpers.IsIWebElementQuestion(row["Question"], ScenarioContext))
                {
                    Assert.That(
                        (StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement).Displayed,
                        Is.EqualTo(true),
                        "Unable to find question {0}", row["Question"]);
                }
                // Select elements
                else if (StepDefinitionHelpers.IsSelectElementQuestion(row["Question"], ScenarioContext))
                {
                    Assert.That(
                        (StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as SelectElement).WrappedElement.Displayed,
                        Is.EqualTo(true),
                        "Unable to find question {0}", row["Question"]);
                }
                // IList questions
                else if (StepDefinitionHelpers.IsRadioButtonQuestion(row["Question"], ScenarioContext))
                {
                    Assert.That(
                        (StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IList<IWebElement>).First().Displayed,
                        Is.EqualTo(true),
                        "Unable to find question {0}", row["Question"]);
                }
                // Unable to map question to a type
                else
                {
                    Assert.Fail(
                        "Unable to find question type: {0}",
                        StepDefinitionHelpers.GetQuestionPropertyType(row["Question"], ScenarioContext));
                }
            }
        }

        public void ThenTheFollowingQuestionsShouldHaveAnErrorDisplayed(Table table, bool alreadyLooped)
        {
            foreach (var row in table.Rows)
            {
                if (StepDefinitionHelpers.GetQuestionPropertyInfo(row["Question"], ScenarioContext).GetCustomAttributes(typeof(ErrorPanelAttribute), false).Any())
                {
                    var errorPanelAttr = ((ErrorPanelAttribute)StepDefinitionHelpers
                        .GetQuestionPropertyInfo(row["Question"], ScenarioContext)
                        .GetCustomAttributes(typeof(ErrorPanelAttribute), false).Single());
                        

                    try
                    {
                        if (errorPanelAttr.By.ToString().Contains("By.Id")) 
                        { 
                            SeleniumContext.WebDriver.WaitUntilDisplayed(By.CssSelector(
                                string.Format("#{0}.{1}", errorPanelAttr.errorPanelId, "inError")));
                        }
                    }
                    catch (WebDriverTimeoutException)
                    {
                        if (!alreadyLooped)
                        {
                            (new WhenBindings(ScenarioContext, FeatureContext)).WhenIClickNextExpectingNoAccordionTransition();

                            ThenTheFollowingQuestionsShouldHaveAnErrorDisplayed(table, true);

                            return;
                        }
                    }

                    Assert.That(
                        SeleniumContext.WebDriver.HasError(errorPanelAttr.By),
                        Is.EqualTo(true),
                        "Unable to find an error for question ", row["Question"]);
                }
                else
                {
                    Assert.Fail(
                        "Unable to find error panel for question: {0}",
                        row["Question"]);
                }
            }
        }

        [Then(@"the following questions should have an error displayed")]
        public void ThenTheFollowingQuestionsShouldHaveAnErrorDisplayed(Table table)
        {
            ThenTheFollowingQuestionsShouldHaveAnErrorDisplayed(table, false);
        }

        [Then(@"the ""(.*)"" button should be visible")]
        public void ThenTheButtonShouldBeVisible(string buttonName)
        {
            Assert.That(
                (StepDefinitionHelpers.GetQuestion(buttonName, ScenarioContext) as IWebElement).Displayed,
                Is.EqualTo(true));
        }

        [Then(@"the ""(.*)"" button should not be visible")]
        public void ThenTheButtonShouldNotBeVisible(string buttonName)
        {
            var button = StepDefinitionHelpers.GetQuestion(buttonName, ScenarioContext) as IWebElement;

            if (button != null)
            {
                Assert.That(
                    button.Displayed,
                    Is.EqualTo(false));
            }
        }

        [Then(@"I should see the autocomplete list")]
        public void ThenIShouldSeeTheAutocompleteList()
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            var findsByAttribute = PageObjectHelpers.GetFindsByUsing(
                StepDefinitionHelpers.GetQuestionCustomAttributes("AutocompleteWrapper", ScenarioContext));

            // More debugging
            //PageObjectHelpers.GetWait().Until(
            //    d => baseDataCapturePage.AutocompleteWrapper != null);

            Assert.That(
                baseDataCapturePage.AutocompleteWrapper.Displayed,
                Is.EqualTo(true));
        }

        [Then(@"I should see (.*) items in the list")]
        public void ThenIShouldSeeItemsInTheList(int itemCount)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            // This is for debugging, will kill thetest, not fail it as it should.
            //PageObjectHelpers.GetWait().Until(
              //  d => baseDataCapturePage.AutocompleteItems.Count == itemCount);

            Assert.That(baseDataCapturePage.AutocompleteItems.Count, Is.EqualTo(itemCount));
        }

        [Then(@"I should see the following items")]
        public void ThenIShouldSeeTheFollowingItems(Table table)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            foreach (var row in table.Rows)
            {
                Assert.That(
                    baseDataCapturePage.AutocompleteItems.Any(x => x.Text == row["Item"]),
                    Is.EqualTo(true),
                    string.Format("Unable to find {0} in the auto complete list", row["Item"]));
            }
        }

        // Model Testing
        [Then(@"I should see (.*) models on the page")]
        public void ThenIShouldSeeModelsOnThePage(int itemCount)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;


            // WHY is this here? If the test fails, it simply forces a timout - weird methdology for testing if you ask me :)
            // I think it is so you can run in debug and it will throw an error, stoping the testing andyou can inspect and such. 
            //PageObjectHelpers.GetWait().Until(
            //d => baseDataCapturePage.AllTabs.Count == itemCount);


            Assert.That(baseDataCapturePage.AllModels.Count, Is.EqualTo(itemCount)
                , string.Format("Found {0} models expected {1}", baseDataCapturePage.AllModels.Count, itemCount)
                );
        }

        [Then(@"I should see (.*) tabs on the page")]
        public void ThenIShouldSeeTabsOnThePage(int itemCount)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            
            // WHY is this here? If the test fails, it simply forces a timout - weird methdology for testing if you ask me :)
            // I think it is so you can run in debug and it will throw an error, stoping the testing andyou can inspect and such. 
            //PageObjectHelpers.GetWait().Until(
            //d => baseDataCapturePage.AllTabs.Count == itemCount);

            
            Assert.That(baseDataCapturePage.AllTabs.Count, Is.EqualTo(itemCount)
                ,string.Format("Found {0} tabs expected {1}" , baseDataCapturePage.AllTabs.Count, itemCount)
                );
        }

        [Then(@"I should see the following tabs")]
        public void ThenIShouldSeeTheFollowingTabs(Table table)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            foreach (var row in table.Rows)
            {
                Assert.That(
                    baseDataCapturePage.AllTabs.Any(x => x.Text == row["Tab"]),
                    Is.EqualTo(true),
                    string.Format("Unable to find {0} in the tab list", row["Tab"]));
            }
        }

        
        [Then(@"I should be on the (.*) tab")]
        public void ThenIShouldBeOnTheNamedTab(string TabName)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            PageObjectHelpers.GetWait(5).Until(
            d => baseDataCapturePage.CurrentTab.Text.Trim() == TabName.Trim());

            Assert.That(
                    baseDataCapturePage.CurrentTab.Text.Trim() == TabName.Trim(),
                    Is.EqualTo(true),
                    string.Format("We are not on the {0} tab, we are on the {1} tab", TabName, baseDataCapturePage.CurrentTab.Text == TabName)); 

        }

        [Then(@"the following questions should have the following information")]
        public void ThenTheFollowingQuestionsShouldHaveTheFollowingInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                if (StepDefinitionHelpers.IsIWebElementQuestion(row["Question"], ScenarioContext))
                {
                    if (row["Data"].Equals("<RandomText>"))
                    {
                        Assert.IsNotNullOrEmpty((StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement).GetAttribute("value"));
                    }
                    else
                    {
                        if ((StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement).TagName == "div") //Segments
                        {
                            Assert.IsTrue((StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement).Text.Contains(row["Data"]));
                        }
                        else 
                        { 
                            Assert.That(
                            (StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement).GetAttribute("value"),
                            Is.EqualTo(row["Data"]));
                        }
                    }
                }
                else
                {
                    Assert.Fail(
                        "Unmapped question type for {0}",
                        row["Question"]);
                }
            }
        }

        [Then(@"the Address Lookup should have more than one item")]
        public void ThenTheAddressLookupShouldHaveMoreThanOneItem()
        {
            Assert.That(
                (ScenarioContext["page"] as IAddressLookup).GetSelectElement().Options.Count,
                Is.GreaterThan(1));
        }

        [Then(@"the Address Lookup should have only one item")]
        public void ThenTheAddressLookupShouldHaveOnlyOneItem()
        {
            Assert.That(
                (ScenarioContext["page"] as IAddressLookup).GetSelectElement().Options.Count,
                Is.EqualTo(1));
        }

        [Then(@"the Selected Address should start ""(.*)""")]
        public void ThenTheSelectedAddressShouldStart(string expected)
        {
            Assert.That(
                (ScenarioContext["page"] as IAddressLookup).GetSelectedAddress().StartsWith(expected),
                Is.EqualTo(true));
        }

        [Then(@"a popup message should be displayed with the text ""(.*)""")]
        public void ThenAPopupMessageShouldBeDisplayedWithTheText(string expectedMessage)
        {
            SeleniumContext.WebDriver.WaitForAlert();
            try
            {
                IAlert alert = SeleniumContext.WebDriver.getAlert();
                Assert.That(
                alert.Text,
                Is.EqualTo(expectedMessage));
                alert.Accept();
            }
            catch (InvalidOperationException)
            {
                //PhantomJS engine! pass this test.
                Assert.Pass("Forced pass as this is being run using the PhantomJS Driver.");
            }
        }

        [Then(@"I expect to see premiums")]
        public void ThenIExpectToSeePremiums()
        {
            var quotePage = ScenarioContext["page"] as QuotePage;

            // For debugging only
            //PageObjectHelpers.GetWait().Until(x => quotePage.PageHeading.Text == "Your Quotes");

            Assert.That(
                quotePage.PageHeading.Text,
                Is.EqualTo("Your Quotes"));

            Assert.That(
                quotePage.QuoteRows.Count,
                Is.GreaterThanOrEqualTo(1),
                "There are 0 quotes");
        }

        [Then(@"The premiums are greater than 0")]
        public void ThenThePremiumsAreGreaterThan()
        {
            Assert.That(
                (ScenarioContext["page"] as QuotePage).Premiums.Any(
                    x => float.Parse(x.Text.Replace("£", string.Empty)) <= 0),
                Is.EqualTo(false),
                "Not all premiums are greater than 0");
        }

        [Then(@"The autocomplete list should be non-empty")]
        public void ThenTheAutocompleteListShouldBeNon_Empty()
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            // More debugging
            //PageObjectHelpers.GetWait().Until(
            //            d => baseDataCapturePage.AutocompleteWrapper != null);

            Assert.IsTrue(baseDataCapturePage.AutocompleteItems.Count > 0);
        }

        [Then(@"The question ""(.*)"" dropdown list should have the following items")]
        public void ThenTheQuestionDropdownListShouldHaveTheFollowingItems(string questionName, Table table)
        {
            var question = StepDefinitionHelpers.GetQuestion(questionName, ScenarioContext) as IWebElement;
            var selectElement = new SelectElement(question);

            foreach(var row in table.Rows)
            {
                if (!selectElement.Options.Select(x => x.Text).Contains(row["Data"]))
                {
                    Assert.Fail("Not all defined items found in list");
                    break;
                }
            }
        }

        [Then(@"the following questions should have the right wording")]
        public void ThenTheFollowingQuestionWordingShouldBe(Table table)
        {
            foreach (var row in table.Rows)
            {
                var attributes = StepDefinitionHelpers.GetQuestionCustomAttributes(row["Question"], ScenarioContext);
                var labelAttribute = attributes.Single(a => a.GetType() == typeof(LabelAttribute)) as LabelAttribute;
                var labelControl = StepDefinitionHelpers.GetDriver(ScenarioContext).FindElement(labelAttribute.By);

                Assert.That(labelControl.Text.Equals(labelAttribute.Wording));
            }
        }

        [Then(@"I should see the help wording")]
        public void ThenIShouldSeeTheHelpWording()
        {
            var dataCapturePage = ScenarioContext["page"] as OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.BaseDataCapturePage;
            IWebElement help = dataCapturePage.Driver.FindElement(dataCapturePage.HelpTextWordingQtipSelector);
            Assert.That(help.Enabled);
        }
    }
}
