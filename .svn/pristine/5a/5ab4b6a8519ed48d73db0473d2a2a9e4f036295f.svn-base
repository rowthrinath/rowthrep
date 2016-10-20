using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Ecom.Automation.TPR.Selenium.PageObjects;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.TPR.Selenium.StepDefinitions
{
    /// <summary>
    /// Given bindings
    /// </summary>
    /// <seealso cref="OpenGI.Ecom.Automation.TPR.Selenium.StepDefinitions.BindingsBase" />
    [Binding]
    public sealed class GivenBindings : BindingsBase
    {
        public GivenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        [Given(@"I have launched in to TPR")]
        public void GivenIHaveLaunchedInToTPR()
        {
            // Todo: this is shit, do better
            ////if (SeleniumContext.WebDriver.HasAlert())
            ////{
            ////    SeleniumContext.WebDriver.CloseAlert();
            ////}

            new YourDetailsPage(SeleniumContext.WebDriver, ScenarioContext).Visit();
        }

        [Given(@"I have shown the Declarations accordion")]
        public void GivenIHaveShownTheDeclarationsAccordion()
        {
            new DeclarationsPage(SeleniumContext.WebDriver, ScenarioContext).JumpToAccordion();
        }

        [Given(@"I have shown the Your Business accordion")]
        public void GivenIHaveShownTheYourBusinessAccordion()
        {
            new YourBusinessPage(SeleniumContext.WebDriver, ScenarioContext).JumpToAccordion();
        }

        [Given(@"I have shown the Business Activities accordion")]
        public void GivenIHaveShownTheBusinessActivitiesAccordion()
        {
            new BusinessActivitiesPage(SeleniumContext.WebDriver, ScenarioContext).JumpToAccordion();
        }

        [Given(@"I have shown the Further Information accordion")]
        public void GivenIHaveShownTheFurtherInformationAccordion()
        {
            new FurtherInformationPage(SeleniumContext.WebDriver, ScenarioContext).JumpToAccordion();
        }
    }
}
