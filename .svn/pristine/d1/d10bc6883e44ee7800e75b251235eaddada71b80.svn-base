using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Selenium.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions
{
    [Binding]
    public class GivenBindings : BindingsBase
    {
        public GivenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        [Given(@"I close the browser")]
        public void GivenICloseTheBrowser()
        {
            SeleniumContext.WebDriver.Quit();
            SeleniumContext.WebDriver = null;
        }
    }
}
