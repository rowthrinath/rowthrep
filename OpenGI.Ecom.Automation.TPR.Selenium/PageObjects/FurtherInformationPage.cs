using System;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using System.Threading;
using OpenGI.Selenium.Helpers;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;

namespace OpenGI.Ecom.Automation.TPR.Selenium.PageObjects
{
    public class FurtherInformationPage : BaseDataCapturePage, IDataCapturePage, ICompletable, IJumpableTo, IAddressLookup
    {
        public FurtherInformationPage(IWebDriver driver, ScenarioContext scenarioContext)
            : base(driver, scenarioContext, "pnlFurtherInformation_content")
        { }

        [FindsBy(How = How.Name, Using = "FurtherInformationButtonNext")]
        private IWebElement _nextButton;

        [FindsBy(How = How.ClassName, Using = "AddressList")]
        private IWebElement _addressList;

        [FindsBy(How = How.Id, Using = "getAddr_Person-PostCode_1")]
        private IWebElement _getAddressButton;

        [FindsBy(How = How.Id, Using = "CantFindAddr_Person-PostCode_1")]
        private IWebElement _cantFindAddressButton;

        [FindsBy(How = How.Id, Using = "display_Person-AddressLine_1")]
        private IWebElement _addressSummary;

        [ErrorPanel("panel_Person-BuildingNameOrNumber_1")]
        [FindsBy(How = How.Name, Using = "Person-BuildingNameOrNumber_1")]
        public IWebElement HouseNumberOrName { get; set; }

        [ErrorPanel("panel_Person-PostCode_1")]
        [FindsBy(How = How.Name, Using = "Person-PostCode_1")]
        public IWebElement Postcode { get; set; }

        public SelectElement AddressList
        {
            get
            {
                return new SelectElement(_addressList);
            }
        }

        [ErrorPanel("panel_Person-Address1_1")]
        [FindsBy(How = How.Name, Using = "txtPerson-Address1_1")]
        public IWebElement AddressLineOne { get; set; }

        [FindsBy(How = How.Name, Using = "txtPerson-Address2_1")]
        public IWebElement AddressLineTwo { get; set; }

        [FindsBy(How = How.Name, Using = "txtPerson-Address3_1")]
        public IWebElement AddressLineThree { get; set; }

        [FindsBy(How = How.Name, Using = "txtPerson-Address4_1")]
        public IWebElement AddressLineFour { get; set; }

        [ErrorPanel("panel_Person-DataUsePermission_1")]
        [FindsBy(How = How.Name, Using = "Person-DataUsePermission_1")]
        public IList<IWebElement> MarketingQuestion { get; set; }

        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            _nextButton.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                // Todo: this could also return a quote page
                var declarationsPage = new DeclarationsPage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, declarationsPage);

                SeleniumContext.WebDriver.WaitForAccordionTransition(declarationsPage);

                return declarationsPage;
            }
            else
            {
                SeleniumContext.WebDriver.WaitForValidation();
            }

            return this;
        }

        public void CompletePage()
        {
            MarketingQuestion.ClickRandomRadioButtonLabel(SeleniumContext.WebDriver);

            HouseNumberOrName.Clear();
            HouseNumberOrName.SendKeys("3");

            Postcode.Clear();
            Postcode.SendKeys("WR2 6NJ");

            ClickGetAddressButton();
            
            PageObjectHelpers.GetWait().Until(
                x => _addressSummary.Text.StartsWith("Bridgehouse Property Consultants"));
        }

        public void JumpToAccordion()
        {
            SeleniumContext.WebDriver.RunJavascript(
               string.Format(
                   "$('.questionPnlContent').addClass('hrhidden'); $('#{0}').removeClass('hrhidden');",
                   PanelId));

            base.Visit();
        }

        public void ClickCantFindButton()
        {
            _cantFindAddressButton.Click();
        }

        public void ClickGetAddressButton()
        {
            _getAddressButton.Click();
        }

        public SelectElement GetSelectElement()
        {
            return AddressList;
        }

        public string GetSelectedAddress()
        {
            return _addressSummary.Text;
        }
    }
}