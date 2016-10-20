using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.TPR.Selenium.PageObjects
{
    /// <summary>
    /// Your details page object
    /// </summary>
    /// <seealso cref="OpenGI.Ecom.Automation.TPR.Selenium.PageObjects.BaseDataCapturePage" />
    /// <seealso cref="OpenGI.Selenium.Infrastructure.IDataCapturePage" />
    public class YourDetailsPage : BaseDataCapturePage, IDataCapturePage, ICompletable
    {
        public YourDetailsPage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, "pnlAboutYou_content")
        { }

        [FindsBy(How = How.Name, Using = "Person-Title_1")]
        private IWebElement _title;

        [FindsBy(How = How.Name, Using = "AboutYouButtonNext")]
        private IWebElement _nextButton;

        [ErrorPanel("panel_Person-FullName_1")]
        public SelectElement Title
        {
            get
            {
                return new SelectElement(_title);
            }
        }

        [ErrorPanel("panel_Person-FullName_1")]
        [FindsBy(How = How.Name, Using = "Person-FirstName_1")]
        public IWebElement FirstName { get; set; }

        [ErrorPanel("panel_Person-FullName_1")]
        [FindsBy(How = How.Name, Using = "Person-Surname_1")]
        public IWebElement Surname { get; set; }

        [ErrorPanel("panel_Person-ContactEmail_1")]
        [FindsBy(How = How.Name, Using = "Person-ContactEmail_1")]
        public IWebElement Email { get; set; }

        [ErrorPanel("panel_Person-ContactTelephone_1")]
        [FindsBy(How = How.Name, Using = "Person-ContactTelephone_1")]
        public IWebElement HomePhone { get; set; }

        [ErrorPanel("panel_Person-ContactAlternatePhone_1")]
        [FindsBy(How = How.Name, Using = "Person-ContactAlternatePhone_1")]
        public IWebElement AlternatePhone { get; set; }

        /// <summary>
        /// Completes the page.
        /// </summary>
        public void CompletePage()
        {
            Title.ClickRandomOption();

            FirstName.Clear();
            FirstName.SendKeys(Guid.NewGuid().ToString());

            Surname.Clear();
            Surname.SendKeys(Guid.NewGuid().ToString());

            Email.Clear();
            Email.SendKeys("open@gi.co.uk");

            HomePhone.Clear();
            HomePhone.SendKeys("01234567890");
        }

        /// <summary>
        /// Clicks the next.
        /// </summary>
        /// <param name="expectNextPage">if set to <c>true</c> [expect next page].</param>
        /// <returns></returns>
        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            _nextButton.Click();

            if (expectNextPage)
            {
                var furtherInformationPage = new FurtherInformationPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, furtherInformationPage);

                SeleniumContext.WebDriver.WaitForAccordionTransition(furtherInformationPage);

                return furtherInformationPage;
            }
            else
            {
                SeleniumContext.WebDriver.WaitForValidation();
            }

            return this;
        }

        /// <summary>
        /// Visits this instance.
        /// </summary>
        public override void Visit()
        {
            Driver.Navigate().GoToUrl(BaseUrl + "&cs=true");

            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.CssSelector("form#frmCQMain")));

            base.Visit();
        }
    }
}
