using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Selenium.Framework.PageObjects
{
    public class QuotePage : BasePage
    {
        public QuotePage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext)
        { }

        [FindsBy(How = How.Id, Using = "displayText_PageHeading")]
        public IWebElement PageHeading { get; set; }

        [FindsBy(How = How.ClassName, Using = "quoteRowWrapper")]
        public IList<IWebElement> QuoteRows { get; set; }

        public IList<IWebElement> Premiums
        {
            get
            {
                return QuoteRows.Select(
                    x => x.FindElement(By.ClassName("qpgSumPremFull"))).ToList();
            }
        }
    }
}
