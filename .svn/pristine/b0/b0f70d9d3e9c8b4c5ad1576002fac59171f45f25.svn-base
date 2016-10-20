using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OpenGI.Ecom.Automation.TPR.Selenium.PageObjects
{
    /// <summary>
    /// Business activities page object
    /// </summary>
    /// <seealso cref="OpenGI.Ecom.Automation.TPR.Selenium.PageObjects.BaseDataCapturePage" />
    /// <seealso cref="OpenGI.Selenium.Infrastructure.IDataCapturePage" />
    public class BusinessActivitiesPage : BaseDataCapturePage, IDataCapturePage, ICompletable, IJumpableTo, IQuotable
    {
        public BusinessActivitiesPage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, "pnlBusinessActivities_content")
        { }

        [FindsBy(How = How.Name, Using = "Person-ProfessionalAssociation_1")]
        private IWebElement _professionalAssociation;

        [FindsBy(How = How.Name, Using = "BusinessActivitiesButtonNext")]
        private IWebElement _nextButton;

        [FindsBy(How = How.ClassName, Using = "addRepeatAdd")]
        private IList<IWebElement> _addAdditionalActivityButtons;

        [ErrorPanel("panel_Person-QualificationRequired_1")]
        [FindsBy(How = How.Name, Using = "Person-QualificationRequired_1")]
        public IList<IWebElement> QualificationRequired { get; set; }

        [ErrorPanel("panel_Person-Qualified_1")]
        [FindsBy(How = How.Name, Using = "Person-Qualified_1")]
        public IList<IWebElement> AreYouQualified { get; set; }

        [ErrorPanel("panel_Person-MemberOfProfessionalAssociation_1")]
        [FindsBy(How = How.Name, Using = "Person-MemberOfProfessionalAssociation_1")]
        public IList<IWebElement> MemberOfProfessionalAssociation { get; set; }

        [ErrorPanel("panel_Person-MainActivity_1")]
        [FindsBy(How = How.Name, Using = "Person-MainActivity_1")]
        public IWebElement WhatIsYourMainProfession { get; set; }

        [ErrorPanel("panel_Person-ProfessionalAssociation_1")]
        [FindsBy(How = How.Name, Using = "Person-ProfessionalAssociation_1")]
        public IWebElement ProfessionalAssociation { get; set; }

        [FindsBy(How = How.Name, Using = "Person-ProfessionalAssociationMemberNumber_1")]
        public IWebElement ProfessionalAssociationMemberNumber { get; set; }

        [ErrorPanel("panel_Person-AditionalActivities_1")]
        [FindsBy(How = How.Name, Using = "Person-AditionalActivities_1")]
        public IList<IWebElement> DoYouRequireCoverForAdditionalActivities { get; set; }
        
        public IWebElement AddAdditionalActivityButton
        {
            get
            {
                return _addAdditionalActivityButtons.SingleOrDefault(x => x.Displayed);
            }
        }

        [ErrorPanel("panel_Person-Trade-Name_1-1")]
        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-1")]
        public IWebElement AdditionalActivityOne { get; set; }
        
        [ErrorPanel("panel_Person-Trade-Name_1-2")]
        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-2")]
        public IWebElement AdditionalActivityTwo { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-3")]
        public IWebElement AdditionalActivityThree { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-4")]
        public IWebElement AdditionalActivityFour { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-5")]
        public IWebElement AdditionalActivityFive { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-6")]
        public IWebElement AdditionalActivitySix { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-7")]
        public IWebElement AdditionalActivitySeven { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-8")]
        public IWebElement AdditionalActivityEight { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-9")]
        public IWebElement AdditionalActivityNine { get; set; }

        [FindsBy(How = How.Name, Using = "Person-Trade-Name_1-10")]
        public IWebElement AdditionalActivityTen { get; set; }

        [FindsBy(How = How.Id, Using = "addRepeatRemove-subTrade_1_2")]
        public IWebElement RemoveAdditionalActivityTwoButton { get; set; }

        [FindsBy(How = How.Id, Using = "addRepeatRemove-subTrade_1_10")]
        public IWebElement RemoveAdditionalActivityTenButton { get; set; }

        [ErrorPanel("panel_Person-AccreditedTraining_1")]
        [FindsBy(How = How.Name, Using = "Person-AccreditedTraining_1")]
        public IList<IWebElement> AccreditedTraining { get; set; }

        /// <summary>
        /// Clicks the next.
        /// </summary>
        /// <param name="expectNextPage">if set to <c>true</c> [expect next page].</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            _nextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var yourDetailsPage = new YourDetailsPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, yourDetailsPage);

                SeleniumContext.WebDriver.WaitForAccordionTransition(yourDetailsPage);

                return yourDetailsPage;
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
            MemberOfProfessionalAssociation.ClickRadioButtonLabel(true, Driver);

            ProfessionalAssociation.SendKeys("Scottish Mediation Network");

            QualificationRequired.ClickRadioButtonLabel(true, Driver);

            AreYouQualified.ClickRadioButtonLabel(true, Driver);

            DoYouRequireCoverForAdditionalActivities.ClickRadioButtonLabel(false, Driver);

            AccreditedTraining.ClickRandomRadioButtonLabel(Driver);
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

        public BasePage ClickSubmit()
        {
            _nextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            var quotePage = new QuotePage(Driver, ScenarioContext);

            PageFactory.InitElements(Driver, quotePage);

            return quotePage;
        }
    }
}
