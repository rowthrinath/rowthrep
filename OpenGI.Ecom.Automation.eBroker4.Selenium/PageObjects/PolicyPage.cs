using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
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
using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using System.Threading;

namespace OpenGI.Ecom.Automation.eBroker.Selenium.PageObjects
{
    public class PolicyPage: eBrokerDemoBaseDataCapturePage,ICompletable
    {
        public PolicyPage(IWebDriver driver, ScenarioContext scenarioContext): base(driver, scenarioContext, null)
        { }

    

        [FindsBy(How = How.XPath, Using = "//*[@id='page_columns']/div[2]/p[2]/a[1]/img")]
        public IWebElement ClickCarGetQuote { get; set; }

        [FindsBy(How = How.Name, Using = "promotionCode")]
        public IWebElement PromotionCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "cmp-input-select-one[field-name='marketing'] button.cmp-select-one-button")]
        [HelpText(How = How.CssSelector, Using = "cmp-input-select-one[field-name='marketing'] > div > cmp-input-info > button > md-icon")]
        public IList<IWebElement> Marketing { get; set; }


        [FindsBy(How = How.CssSelector, Using = "cmp-input-select-one > div > div.layout-align-space-between-center.layout-row > label")]
        [ErrorPanel(How.CssSelector, "cmp-input-select-one > div > div.layout-align-space-between-center.layout-row > label")]
        public IWebElement Title { get; set; }


        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.person.title.vt'] button")]
        [ErrorPanel(How.CssSelector, "[model='vm.data.person.title.vt'] button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.cmpInputButtonGroup button")]
        public IWebElement TitleButton { get; set; }

        [ErrorPanel(How.Name, "firstName")]
        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement FirstName { get; set; }

        [ErrorPanel(How.Name, "surname")]
        [FindsBy(How = How.Name, Using = "surname")]
        public IWebElement Surname { get; set; }

        [ErrorPanel(How.Name, "contactTelephone")]
        [FindsBy(How = How.Name, Using = "contactTelephone")]
        public IWebElement ContactNumber { get; set; }

        [ErrorPanel(How.Name, "contactEmail")]
        [FindsBy(How = How.Name, Using = "contactEmail")]
        public IWebElement PrimaryEmail { get; set; }

        [ErrorPanel(How.Name, "input[name='fullAddress'] ~ div > div[ng-messages]")]
        [FindsBy(How = How.Name, Using = "fullAddress")]
        public IWebElement Postcode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "md-autocomplete-parent-scope > span")]
        //[FindsBy(How = How.XPath, Using = "/html/body/md-virtual-repeat-container/div/div[2]/ul/li")]
        public IList<IWebElement> addressList { get; set; }

        [FindsBy(How = How.CssSelector, Using = "cmp-input-select-one[field-name='coverType'] button.cmp-select-one-button")]
        public IList<IWebElement> CoverType { get; set; }

        [FindsBy(How = How.ClassName, Using = "md-datepicker-input")]
        public IWebElement CoverStartDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main > div > form > md-toolbar > button")]
        public IWebElement TabOneNext { get; set; }


        [ErrorPanel(How.CssSelector, "#main > div > form > md-toolbar > button")]
        [FindsBy(How = How.CssSelector, Using = "#main > div > form > md-toolbar > button")]
        public IWebElement TabTwoQ1 { get; set; }


        public override void Visit()
        {
            Driver.Navigate().GoToUrl(BaseUrl);

 			PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.CssSelector("cmp-input-info:nth-child(1) > div > cmp-input-info > div > span")).Text.Trim() == "About You");

            base.Visit();
        }

        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            TabOneNext.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var tabTwo = new VehiclePage(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, tabTwo);

                return tabTwo;

            }
            

            return this;

        }

        public void CompletePage()
        {
			//PromotionCode.SendKeys("abc");
            //Marketing.ElementAt(0).Click();
            //Title.ElementAt(0).Click();
            //FirstName.SendKeys("John");
            //Surname.SendKeys("Cena");
            //ContactNumber.SendKeys("0123");
            //PrimaryEmail.SendKeys("abc@xyz.com");
            //Postcode.SendKeys("WR4 9SR");
            
           // if (addressList.Count > 0) { 
             //   addressList.ElementAt(0).Click();
            //}
            

            //CoverType.ElementAt(0).Click();
        
        }
    }
}
