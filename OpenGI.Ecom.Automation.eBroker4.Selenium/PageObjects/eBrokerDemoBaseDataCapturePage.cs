using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.eBroker.Selenium.PageObjects
{
    public abstract class eBrokerDemoBaseDataCapturePage : BaseDataCapturePage, IDataCapturePage
    {
        public eBrokerDemoBaseDataCapturePage(IWebDriver driver, ScenarioContext scenarioContext, string panelId)
            : base(driver, scenarioContext, panelId)
        { }

        [IgnoreWebElement]
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > button.cmp-select-one-button:nth-child(1)")]
        private IList<IWebElement> _selectLists;

        [FindsBy(How = How.CssSelector, Using = "div > button.cmp-select-one-button:nth-child(1)")]
        private IWebElement SelectTitle { get; set; }

        public override IList<IWebElement> AllInputs
        {
            get
            {
                return base.AllInputs.Concat(_selectLists).ToList();
            }
        }


        public override By HelpTextWordingQtipSelector
        {
            get
            {
                return By.CssSelector("md-tooltip > div > span");
            }
        }

    }
}
