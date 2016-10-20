using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Ecom.Automation.Vanilla.Selenium.PageObjects;
using OpenGI.Selenium.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Vanilla.Selenium.StepDefinitions
{
    [Binding]
    public class GivenBindings : BindingsBase
    {
        public GivenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        private VanillaBaseDataCapturePage tab;

        [Given(@"I have launched in to Vanilla")]
        public void GivenIHaveLaunchedInToVanilla()
        {
            tab = new TabOne(SeleniumContext.WebDriver, ScenarioContext);
            tab.Visit();
        }

        [Given(@"I have moved to Tab Two")]
        public void GivenIHaveMovedToTabTwo()
        {
            ((ICompletable)tab).CompletePage();
            tab =  (VanillaBaseDataCapturePage) tab.ClickNext(true);
            tab.Visit();
        }
    }
}
