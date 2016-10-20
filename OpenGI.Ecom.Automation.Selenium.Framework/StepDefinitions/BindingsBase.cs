using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium;

namespace OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions
{
    /// <summary>
    /// Step definition base class - all binding classes should inherit from this
    /// </summary>
    [Binding]
    public class BindingsBase
    {
        public FeatureContext FeatureContext { get; private set; }
        public ScenarioContext ScenarioContext { get; private set; }


        public BindingsBase(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            FeatureContext = featureContext;
            ScenarioContext = scenarioContext;
        }
    }
}
