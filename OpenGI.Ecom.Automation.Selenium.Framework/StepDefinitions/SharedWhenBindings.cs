using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions
{
    [Binding]
    public class WhenBindings : BindingsBase 
    {
        public WhenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }


        [When(@"I clear the current form")]
        public void GivenIClearTheCurrentForm()
        {
            foreach (var p in (ScenarioContext["page"] as BaseDataCapturePage).GetQuestions())
            {
                if (StepDefinitionHelpers.IsIWebElementQuestion(p.Name, ScenarioContext))
                {
                    var question = StepDefinitionHelpers.GetQuestion(p.Name, ScenarioContext) as IWebElement;
                    
                    // Dates aren't editable
                    if (question != null && question.Displayed && question.TagName != "div" && question.GetAttribute("type") != "date")
                    {
                        question.SendKeys(Keys.Delete);
                    }
                }
                else if (StepDefinitionHelpers.IsSelectElementQuestion(p.Name, ScenarioContext))
                {
                    (StepDefinitionHelpers.GetQuestion(p.Name, ScenarioContext) as SelectElement).SelectByValue(string.Empty);
                }
                else if (StepDefinitionHelpers.IsRadioButtonQuestion(p.Name, ScenarioContext))
                {
                    var findsByUsing = PageObjectHelpers.GetFindsByUsing(
                        StepDefinitionHelpers.GetQuestionCustomAttributes(p.Name, ScenarioContext));

                    if (findsByUsing != null && findsByUsing.How == How.Name && !string.IsNullOrEmpty(findsByUsing.Using))
                    {
                        SeleniumContext.WebDriver.RunJavascript(
                            string.Format(
                                "$('input[name={0}]').removeAttr('checked');",
                                findsByUsing.Using));
                    }
                }
            }
        }

		[When(@"I select the following questions")]
        public void WhenISelectTheFollowingQuestions(Table table)
        {
            StepDefinitionHelpers.SelectListDataForTable(table, ScenarioContext);
        }

        [When(@"I click the following buttons")]
        public void WhenIClickTheFollowingButtons(Table table)
        {
            StepDefinitionHelpers.SelectButtonDataForTable(table, ScenarioContext);
        }



        [When(@"I populate the following questions")]
        public void WhenIPopulateTheFollowingQuestions(Table table)
        {
            StepDefinitionHelpers.PopulateDataForTable(table,ScenarioContext);
        }

        [When(@"I complete the form")]
        public void WhenICompleteTheForm()
        {
            (ScenarioContext["page"] as ICompletable).CompletePage();
        }

        [When(@"I click Next expecting no accordion transition")]
        public void WhenIClickNextExpectingNoAccordionTransition()
        {
            ClickNext(false);
        }

        [When(@"I click Next expecting an accordion transition")]
        public void WhenIClickNextExpectingAnAccordionTransition()
        {
            ClickNext(true);
        }



        [When(@"I click Get Quote")]
        public void WhenIClickGetQuote()
        {
            ScenarioContext["page"] = (ScenarioContext["page"] as IQuotable).ClickSubmit();
        }

        [When(@"I click the ""(.*)"" button (.*) times")]
        public void WhenIClickTheButtonTimes(string buttonName, int timesToClick)
        {
            
            //PageObjectHelpers.GetWait(10).Until(d => StepDefinitionHelpers.GetQuestion(buttonName, ScenarioContext) as IWebElement!=null);
            while (timesToClick > 0)
            {
                    (StepDefinitionHelpers.GetQuestion(buttonName, ScenarioContext) as IWebElement).Click();
                timesToClick--;
            }
        }

        [When(@"I click the ""(.*)"" button")]
        public void WhenIClickTheButton(string buttonName)
        {
            PageObjectHelpers.GetWait(10).Until(d => StepDefinitionHelpers.GetQuestion(buttonName, ScenarioContext) as IWebElement);
			Thread.Sleep(2000);
            WhenIClickTheButtonTimes(buttonName, 1);
        }

        [When(@"I click the ""(.*)"" autocomplete item")]
        public void WhenIClickTheAutocompleteItem(string requestedItem)
        {
            var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;

            baseDataCapturePage.AutocompleteItems.Single(x => x.Text == requestedItem).Click();
        }

        [When(@"I click the Cant Find Address button")]
        public void WhenIClickTheCantFindAddressButton()
        {
            (ScenarioContext["page"] as IAddressLookup).ClickCantFindButton();
        }

        [When(@"I click the Get Address button")]
        public void WhenIClickTheGetAddressButton()
        {
            (ScenarioContext["page"] as IAddressLookup).ClickGetAddressButton();
        }

        private void ClickNext(bool expectedNextPage)
        {
            ScenarioContext["page"] = (ScenarioContext["page"] as BaseDataCapturePage)
                .ClickNext(expectedNextPage);
        }


        [When(@"I click Back expecting an accordion transition")]
        public void WhenIClickBackExpectingAnAccordionTransition()
        {
            ScenarioContext["page"] = (ScenarioContext["page"] as BaseDataCapturePage)
                .ClickBack(true);
        }


        [When(@"I click quote")]
        public void WhenIGetAQuote()
        {
            if (ScenarioContext["page"] is IQuotable)
            {
                ScenarioContext["page"] =
                    (ScenarioContext["page"] as IQuotable).ClickSubmit();
            }
        }

        [When(@"I complete my details")]
        public void WhenICompleteMyDetails()
        {
            for (var i = 0; i < 5; i++)
            {
                (ScenarioContext["page"] as ICompletable).CompletePage();

                if (!(ScenarioContext["page"] is IQuotable))
                {
                    ScenarioContext["page"] =
                        (ScenarioContext["page"] as BaseDataCapturePage).ClickNext(true);
                }
            }
        }

        [When(@"I hover over the help text icon for ""(.*)""")]
        public void WhenIHoverOverTheHelpTextIconFor(string questionName)
        {
            var question = StepDefinitionHelpers.GetQuestion(questionName, ScenarioContext) as IWebElement;
            question.Hover(ScenarioContext,questionName);
        }

        [When(@"I select the first available item from the autocomplete list")]
        public void WhenISelectTheFirstAvailableItemFromTheAutocompleteList(Table table)
        {
            var autoCompleteListItemsCount = StepDefinitionHelpers.PopulateAutoCompleteList(table, ScenarioContext);
            if (autoCompleteListItemsCount > 0)
            {
                var baseDataCapturePage = ScenarioContext["page"] as BaseDataCapturePage;
                PageObjectHelpers.GetWait().Until(d => baseDataCapturePage.AutocompleteWrapper != null);
                baseDataCapturePage.AutocompleteItems.First().Click();
            }
        }

        [When(@"I populate the autocomplete list for following questions")]
        public void WhenIPopulateTheAutocompleteListForFollowingQuestions(Table table)
        {
            StepDefinitionHelpers.PopulateAutoCompleteList(table, ScenarioContext);
        }

    }
}
