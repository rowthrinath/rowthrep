using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.PageObjects
{
    public class BasePage
    {
        public BasePage(IWebDriver driver, ScenarioContext scenarioContext)
        {
            BaseUrl = ConfigurationManager.AppSettings["baseUrl"];
            
            Driver = driver;

            ScenarioContext = scenarioContext;
        }

        public string BaseUrl { get; private set; }

        public IWebDriver Driver { get; private set; }

        public ScenarioContext ScenarioContext { get; private set; }
    }
}
