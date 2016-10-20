using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.Vanilla.Selenium.PageObjects
{
    public class TabOne : VanillaBaseDataCapturePage, ICompletable
    {
        public TabOne(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, null)
        { }

        [ErrorPanel("panel_Person-Title_1")]
        [FindsBy(How = How.Name, Using = "Person-Title_1")]
        [HelpText(How = How.CssSelector, Using = "#helpIcon_Person-Title_1 > a > img")]
        public IWebElement Title { get; set; }

        [ErrorPanel("panel_Person-FirstName_1")]
        [FindsBy(How = How.Name, Using = "Person-FirstName_1")]
        [Label(How = How.CssSelector, Using = "#wording_Person-FirstName_1 > label", Wording = "First name")]
        public IWebElement FirstName { get; set; }

        [ErrorPanel("panel_Person-ShowAnotherQuestion_1")]
        [FindsBy(How = How.Name, Using = "Person-ShowAnotherQuestion_1")]
        public IList<IWebElement> ShowAnotherQuestion { get; set; }

        [ErrorPanel("panel_Person-AnotherQuestion_1")]
        [FindsBy(How = How.Name, Using = "Person-AnotherQuestion_1")]
        [Label(How = How.CssSelector, Using = "#wording_Person-ShowAnotherQuestion_1 > label", Wording = "Do you want to show another question?")]
        public IWebElement AnotherQuestion { get; set; }

        [ErrorPanel("panel_Person-RevealCrossTabQuestion_1")]
        [FindsBy(How = How.Name, Using = "Person-RevealCrossTabQuestion_1")]
        public IList<IWebElement> RevealCrossTabQuestion { get; set; }

        [ErrorPanel("panel_Vehicle-AgedOver_1")]
        [FindsBy(How = How.Name, Using = "Vehicle-AgedOver_1")]
        [Label(How = How.CssSelector, Using = "#wording_Vehicle-AgedOver_1 > label", Wording = "Aged over")]
        public IWebElement VehicleAgedOver { get; set; }

        [ErrorPanel("panel_Person-eQuotesList_1")]
        [FindsBy(How = How.Name, Using = "Person-eQuotesList_1")]
        public IWebElement EQuotesList { get; set; }

        [ErrorPanel("panel_Person-DriverStatus_1")]
        [FindsBy(How = How.Name, Using = "Person-DriverStatus_1")]
        public IWebElement DriverStatus { get; set; }

        [ErrorPanel("panel_Person-InternalCustomList_1")]
        [FindsBy(How = How.Name, Using = "Person-InternalCustomList_1")]
        public IWebElement InternalCustomList { get; set; }

        [ErrorPanel("panel_Person-SecurityImageKey_1")]
        [FindsBy(How = How.Name, Using = "Person-SecurityImageKey_1")]
        public IWebElement CaptchaText { get; set; }

        [FindsBy(How = How.Id, Using = "Person-AutomatedTestSegment_1")]
        public IWebElement AutomatedTestSegment { get; set; }

        [FindsBy(How = How.Name, Using = "Person-IfExistTP_1")]
        private IWebElement _tab2TemplatePopulator { get; set; }

        public SelectElement Tab2TemplatePopulator
        {
            get
            {
                return new SelectElement(_tab2TemplatePopulator);
            }
        }

        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;
            jse.ExecuteScript("scroll(0,250)");

            NextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var tabTwo = new TabTwo(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, tabTwo);

                return tabTwo;
            }
            else
            {
                SeleniumContext.WebDriver.WaitForValidation();
            }

            return this;
        }

        public override void Visit()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "&cs=true");

            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.CssSelector("form#frmCQMain")));

            base.Visit();
        }

        public void CompletePage()
        {
            var titleSelectElement = new SelectElement(Title);
            titleSelectElement.ClickRandomOption();

            FirstName.Clear();
            FirstName.SendKeys(Guid.NewGuid().ToString());

            ShowAnotherQuestion.ClickRadioButton(false);

            RevealCrossTabQuestion.ClickRadioButton(true);

            var eQuotesSelectElement = new SelectElement(EQuotesList);
            eQuotesSelectElement.ClickRandomOption();

            var driverStatusSelectElement = new SelectElement(DriverStatus);
            driverStatusSelectElement.ClickRandomOption();

            var customSelectElement = new SelectElement(InternalCustomList);
            customSelectElement.ClickRandomOption();

            CaptchaText.SendKeys("iRobot");

            VehicleAgedOver.Clear();
            VehicleAgedOver.SendKeys("18");


        }
    }
}
