using NUnit.Framework;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions
{
    /// <summary>
    /// Hook bindings
    /// </summary>
    [Binding]
    public sealed class Hooks
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            if (featureContext == null)
            {
                throw new ArgumentNullException("featureContext");
            }

            if (scenarioContext == null)
            {
                throw new ArgumentNullException("scenarioContext");
            }

            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void ClearDownScreenshots()
        {
            ScreenshotHelper.ClearDownScreenshots();
        }

        [AfterFeature]
        public static void TearDown()
        {
            SeleniumContext.WebDriver.Quit();
            SeleniumContext.WebDriver = null;
        }

        [AfterScenario]
        public void AfterWebTest()
        {
            if (_scenarioContext.TestError != null && !(_scenarioContext.TestError is SuccessException))
            {
                ScreenshotHelper.TakeScreenshot(
                    SeleniumContext.WebDriver,
                    _featureContext.FeatureInfo.Title,
                    _scenarioContext.ScenarioInfo.Title);
            }
        }
    }
}
