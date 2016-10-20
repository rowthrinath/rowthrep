using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;

namespace OpenGI.Ecom.Automation.Vanilla.Selenium.PageObjects
{
    public abstract class VanillaBaseDataCapturePage : BaseDataCapturePage, IDataCapturePage
    {
        public VanillaBaseDataCapturePage(IWebDriver driver, ScenarioContext scenarioContext, string panelId)
            : base(driver, scenarioContext, panelId)
        { }

        [IgnoreWebElement]
        [FindsBy(How = How.Name, Using = "ButtonNext")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "step_title")]
        public IList<IWebElement> Tabs { get; set; }
    }
}
