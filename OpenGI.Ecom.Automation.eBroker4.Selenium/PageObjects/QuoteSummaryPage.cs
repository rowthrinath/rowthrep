using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.eBroker.Selenium.PageObjects
{
    public class QuoteSummaryPage : eBrokerDemoBaseDataCapturePage
    {
        public QuoteSummaryPage(IWebDriver driver, ScenarioContext scenarioContext) : base(driver, scenarioContext, null)
        { }


        [ErrorPanel(How.CssSelector, "cmp-input-info:nth-child(1) > div")]
        [FindsBy(How = How.CssSelector, Using = "cmp-input-info:nth-child(1) > div")]
        public IWebElement Tab_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.person.dateOfBirth.value'] input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.dateOfBirth.value'] input")]
        public IWebElement DateOfBirth_Input { get; set; }

        public override OpenGI.Selenium.Infrastructure.IDataCapturePage ClickNext(bool expectNextPage)
        {
            
            throw new NotImplementedException();
        }


        public override void Visit()
        {
            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.XPath("//*[@id=\"main\"]/div/div/span")).Text.Trim() == "Your Car Details");

            base.Visit();
        }

        public override IDataCapturePage ClickBack(bool expectPreviousPage)
        {
            var tabOne = new PolicyPage(Driver, ScenarioContext);

            PageFactory.InitElements(Driver, tabOne);

            return tabOne;
        }


    }
}
