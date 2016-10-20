using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using System.Configuration;
using OpenGI.Selenium.Infrastructure;
using OpenGI.Selenium.Helpers;

namespace OpenGI.Ecom.Automation.Vanilla.Selenium.PageObjects
{
    class TabTwo : VanillaBaseDataCapturePage
    {
        public TabTwo(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, null)
        { }

        [ErrorPanel("panel_Person-ContactEmail_1")]
        [FindsBy(How = How.Name, Using = "Person-ContactEmail_1")]
        public IWebElement ContactEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Person-AutomatedTestSegment_2")]
        public IWebElement TestSegment { get; set; }

        [FindsBy(How = How.Id, Using = "Person-TitleExists_1")]
        public IWebElement ConditionalSegment { get; set; }

        [FindsBy(How = How.Id, Using = "control_Person-Trade-Repeat_1-1")]
        public IWebElement RepeatQuestion1 { get; set; }

        [FindsBy(How = How.Id, Using = "control_Person-Trade-Repeat_1-2")]
        [Label(How = How.XPath, Using = "//*[@id=\"wording_Person-Trade-Repeat_1-2\"]/label", Wording = "Question Repeat 2")]
        public IWebElement RepeatQuestion2 { get; set; }

        [FindsBy(How = How.Id, Using = "control_Person-Trade-Repeat_1-3")]
        [Label(How = How.XPath, Using = "//*[@id=\"wording_Person-Trade-Repeat_1-3\"]/label", Wording = "Question Repeat 3")]
        public IWebElement RepeatQuestion3 { get; set; }

        [FindsBy(How = How.Id, Using = "control_Person-Trade-Repeat_1-4")]
        [Label(How = How.XPath, Using = "//*[@id=\"wording_Person-Trade-Repeat_1-4\"]/label", Wording = "Question Repeat 4")]
        public IWebElement RepeatQuestion4 { get; set; }

        [FindsBy(How = How.ClassName, Using = "addRepeatAdd")]
        private IList<IWebElement> _addRepeatQuestionButtons;

        public IWebElement AddRepeatQuestionButton
        {
            get
            {
                return _addRepeatQuestionButtons.SingleOrDefault(x => x.Displayed);
            }
        }

        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            NextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));
            return this;

        }

        public override void Visit()
        {
            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.CssSelector("form#frmCQMain")));

            base.Visit();
        }

    }
}
