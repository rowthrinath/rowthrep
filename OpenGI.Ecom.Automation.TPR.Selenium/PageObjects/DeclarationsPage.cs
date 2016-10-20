using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Configuration;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.TPR.Selenium.PageObjects
{
    /// <summary>
    /// Declarations page object
    /// </summary>
    /// <seealso cref="PageObjects.BaseDataCapturePage" />
    /// <seealso cref="OpenGI.Selenium.Infrastructure.IDataCapturePage" />
    public class DeclarationsPage : BaseDataCapturePage, IDataCapturePage, ICompletable, IJumpableTo
    {
        public DeclarationsPage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, "pnlDeclarations_content")
        { }

        [FindsBy(How = How.Name, Using = "DeclarationsButtonNext")]
        private IWebElement _nextButton;

        [ErrorPanel("panel_Person-HasNonMotorConv_1")]
        [FindsBy(How = How.Name, Using = "Person-HasNonMotorConv_1")]
        public IList<IWebElement> HasNonMotoringConviction { get; set; }

        [ErrorPanel("panel_Policy-Bankrupt_1")]
        [FindsBy(How = How.Name, Using = "Policy-Bankrupt_1")]
        public IList<IWebElement> HasEverBeenBankrupt { get; set; }

        [ErrorPanel("panel_Person-CCJs_1")]
        [FindsBy(How = How.Name, Using = "Person-CCJs_1")]
        public IList<IWebElement> HasCCJs { get; set; }

        [ErrorPanel("panel_Person-EverRefused_1")]
        [FindsBy(How = How.Name, Using = "Person-EverRefused_1")]
        public IList<IWebElement> HasEverBeenRefusedOrDeclinedInsurance { get; set; }

        [ErrorPanel("panel_Policy-ImposedTerms_1")]
        [FindsBy(How = How.Name, Using = "Policy-ImposedTerms_1")]
        public IList<IWebElement> HasEverHadInsuranceCancelled { get; set; }

        [ErrorPanel("panel_Person-EverDisqualified_1")]
        [FindsBy(How = How.Name, Using = "Person-EverDisqualified_1")]
        public IList<IWebElement> HasBeenDisqualifiedAsDirector { get; set; }

        [ErrorPanel("panel_Person-HasClaims_1")]
        [FindsBy(How = How.Name, Using = "Person-HasClaims_1")]
        public IList<IWebElement> AnyIncidentsLeadingToAllegationOrClaim { get; set; }

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
                var yourBusinessPage = new YourBusinessPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, yourBusinessPage);

                SeleniumContext.WebDriver.WaitForAccordionTransition(yourBusinessPage);

                return yourBusinessPage;
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
            HasNonMotoringConviction.ClickRadioButtonLabel(false, Driver);

            HasEverBeenBankrupt.ClickRadioButtonLabel(false, Driver);

            HasCCJs.ClickRadioButtonLabel(false, Driver);

            HasEverBeenRefusedOrDeclinedInsurance.ClickRadioButtonLabel(false, Driver);

            HasEverHadInsuranceCancelled.ClickRadioButtonLabel(false, Driver);

            HasBeenDisqualifiedAsDirector.ClickRadioButtonLabel(false, Driver);

            AnyIncidentsLeadingToAllegationOrClaim.ClickRadioButtonLabel(false, Driver);
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
