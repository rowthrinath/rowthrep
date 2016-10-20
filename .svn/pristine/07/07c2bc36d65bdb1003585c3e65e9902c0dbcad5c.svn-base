using OpenGI.Ecom.Automation.eBroker.Selenium.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Selenium.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace OpenGI.Ecom.Automation.eBroker.Selenium.StepDefinitions
{
    [Binding]
    public class GivenBindings : BindingsBase
    {
        public GivenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        private eBrokerDemoBaseDataCapturePage tab;
        

        [Given(@"I have launched in to eBrokerDemo")]
        public void GivenIHaveLaunchedInToEBrokerDemo()
        {
            tab = new PolicyPage(SeleniumContext.WebDriver, ScenarioContext);            
            tab.Visit();
         
        }

        [Given(@"I have moved to Tab Two")]
        public void GivenIHaveMovedToTabTwo()
        {
            ((ICompletable)tab).CompletePage();
            tab = (eBrokerDemoBaseDataCapturePage)tab.ClickNext(true);
            tab.Visit();
        }

        
    }
}
