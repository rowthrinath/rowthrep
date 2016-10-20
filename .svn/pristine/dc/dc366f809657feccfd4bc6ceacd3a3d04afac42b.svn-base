using NUnit.Framework;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Ecom.Automation.Vanilla.Selenium.PageObjects;
using OpenGI.Selenium.Extensions;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using System.Text.RegularExpressions;
using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;

namespace OpenGI.Ecom.Automation.Vanilla.Selenium.StepDefinitions
{
    [Binding]
    public class ThenBindings : BindingsBase
    {
        public ThenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        [Then(@"tab (.*) should be highlighted")]
        public void ThenTabShouldBeHighlighted(int tabNumber)
        {
            var baseDataCapturePage = ScenarioContext["page"] as VanillaBaseDataCapturePage;

            for (var i = 0; i < baseDataCapturePage.Tabs.Count; i++)
            {
                // Is this the tab we are expecting to be active
                if (tabNumber == (i + 1))
                {
                    Assert.That(
                        baseDataCapturePage.Tabs[i].GetParent().GetAttribute("class"),
                        Is.EqualTo("resp_crumb"));
                }
                else
                {
                    Assert.That(
                        baseDataCapturePage.Tabs[i].GetParent().GetAttribute("class").Contains("faded_resp_crumb"),
                        Is.EqualTo(true));
                }
            }

            
        }

        [Then(@"The maxlength attribute should be present and enforced")]
        public void ThenTheMaxlengthAttributeShouldBePresentAndEnforced(Table table)
        {
            StepDefinitionHelpers.PopulateDataForTable(table,ScenarioContext);

            foreach (var row in table.Rows)
            {
                var question = StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement;
                var maxLength = row["MaxLength"];
                Assert.That(question.GetAttribute("value").Length == Int32.Parse(maxLength));
            }
        }

        [Then(@"Following questions should have Corresponding Width")]
        public void ThenFollowingQuestionsShouldHaveCorrespondingWidth(Table table)
        {
            foreach (var row in table.Rows)
            {
                var question = StepDefinitionHelpers.GetQuestion(row["Question"], ScenarioContext) as IWebElement;

                var qWidth = question.GetCssValue("width");
                var minWidth = question.GetCssValue("min-width");
                
                Assert.That(!string.IsNullOrEmpty(qWidth));

                if (!string.IsNullOrEmpty(minWidth))
                {
                    var minWidthInt = string.Join(string.Empty, Regex.Matches(minWidth, @"\d+").OfType<Match>().Select(m => m.Value));
                    if (Int32.Parse(minWidthInt) > 0)
                        continue;
                }    

                var intValueWidth = string.Join(string.Empty, Regex.Matches(qWidth, @"\d+").OfType<Match>().Select(m => m.Value));
                var unit = qWidth.Substring(intValueWidth.ToString().Length);
                
                Assert.That(intValueWidth == row["Width"]);
                Assert.That(unit == row["Unit"]);
            }
        }

        [Then(@"The Following questions should have no error displayed")]
        public void ThenTheFollowingQuestionsShouldHaveNoErrorDisplayed(Table table)
        {
            foreach (var row in table.Rows)
            {
                var errorPanelAttr = StepDefinitionHelpers.GetQuestionPropertyInfo(row["Question"], ScenarioContext).GetCustomAttributes(typeof(ErrorPanelAttribute), false).FirstOrDefault() as ErrorPanelAttribute;
                Assert.IsFalse(StepDefinitionHelpers.GetDriver(ScenarioContext).HasError(errorPanelAttr.By));
            }
        }
    }
}
