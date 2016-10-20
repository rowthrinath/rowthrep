using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.TPR.Selenium.PageObjects
{
    /// <summary>
    /// Your business page object
    /// </summary>
    /// <seealso cref="OpenGI.Ecom.Automation.TPR.Selenium.PageObjects.BaseDataCapturePage" />
    /// <seealso cref="OpenGI.Selenium.Infrastructure.IDataCapturePage" />
    public class YourBusinessPage : BaseDataCapturePage, IDataCapturePage, ICompletable, IJumpableTo
    {
        public YourBusinessPage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, "pnlYourBusiness_content")
        { }

        [FindsBy(How = How.Name, Using = "YourBusinessButtonNext")]
        private IWebElement _nextButton;

        [ErrorPanel("panel_Policy-CompanyPolicy_1")]
        [FindsBy(How = How.Name, Using = "Policy-CompanyPolicy_1")]
        public IList<IWebElement> IsLimitedCompany { get; set; }

        [ErrorPanel("panel_Person-OutsideUK_1")]
        [FindsBy(How = How.Name, Using = "Person-OutsideUK_1")]
        public IList<IWebElement> WorksOutsideUK { get; set; }

        [ErrorPanel("panel_Person-BasedInUK_1")]
        [FindsBy(How = How.Name, Using = "Person-BasedInUK_1")]
        public IList<IWebElement> BasedInUK { get; set; }

        [ErrorPanel("panel_Person-OwnPropertyOutsideUK_1")]
        [FindsBy(How = How.Name, Using = "Person-OwnPropertyOutsideUK_1")]
        public IList<IWebElement> OwnsPropertiesOutsideUK { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name*='Policy-CoverDate_1']")]
        private IList<IWebElement> _coverStartDateMultiple;

        [FindsBy(How = How.Name, Using = "Policy-CoverDate_1")]
        private IWebElement _coverStartDateSingle;

        [ErrorPanel("panel_Policy-CoverDate_1")]
        public IList<IWebElement> CoverStartDate
        {
            get
            {
                if (_coverStartDateMultiple != null)
                {
                    return _coverStartDateMultiple;
                }
                else if (_coverStartDateSingle != null)
                {
                    return _coverStartDateSingle as IList<IWebElement>;
                }

                return null;
            }
        }

        /// <summary>
        /// Clicks the next.
        /// </summary>
        /// <param name="expectNextPage">if set to <c>true</c> [expect next page].</param>
        /// <returns></returns>
        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            _nextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var businessActivitiesPage = new BusinessActivitiesPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, businessActivitiesPage);

                SeleniumContext.WebDriver.WaitForAccordionTransition(businessActivitiesPage);

                return businessActivitiesPage;
            }
            else
            {
                SeleniumContext.WebDriver.WaitForValidation();
            }

            return this;
        }

        /// <summary>
        /// Completes the page.
        /// </summary>
        public void CompletePage()
        {
            IsLimitedCompany.ClickRadioButtonLabel(false, Driver);

            WorksOutsideUK.ClickRadioButtonLabel(false, Driver);
        }

        /// <summary>
        /// Jumps to accordion.
        /// </summary>
        public void JumpToAccordion()
        {
            SeleniumContext.WebDriver.RunJavascript(
               string.Format(
                   "$('.questionPnlContent').addClass('hrhidden'); $('#{0}').removeClass('hrhidden');",
                   PanelId));

            base.Visit();
        }
    }
}
