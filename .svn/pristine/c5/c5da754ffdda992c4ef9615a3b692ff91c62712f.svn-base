using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
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
    public class VehiclePage : eBrokerDemoBaseDataCapturePage
    {
        public VehiclePage(IWebDriver driver, ScenarioContext scenarioContext) : base(driver, scenarioContext, null)
        { }


        [ErrorPanel(How.CssSelector, "[model='vm.data.flags.ownerAndKeeper'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.flags.ownerAndKeeper'] label")]
        public IWebElement Are_you_the_owner_and_keeper_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.flags.ownerAndKeeper'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.flags.ownerAndKeeper'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.flags.ownerAndKeeper'] div.cmpInputButtonGroup button")]
        public IWebElement Are_you_the_owner_and_keeper_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.purchaseDate.value'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.purchaseDate.value'] label")]
        public IWebElement When_was_your_car_purchased_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.purchaseDate.value']  md-datepicker input")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.purchaseDate.value']  md-datepicker input")]
        public IWebElement When_was_your_car_purchased_DateInput { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.nightLocation.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.nightLocation.vt'] label")]
        public IWebElement Where_do_you_park_your_car_overnight_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.nightLocation.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.nightLocation.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.nightLocation.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Where_do_you_park_your_car_overnight_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.nightLocation.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.nightLocation.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Where_do_you_park_your_car_overnight_SelectOther { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.coverType.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.coverType.vt'] label")]
        public IWebElement Your_Level_Of_Cover_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.coverType.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.coverType.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.coverType.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Your_Level_Of_Cover_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.windscreen.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.windscreen.vt'] label")]
        public IWebElement Do_You_Require_Windscreen_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.windscreen.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.windscreen.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.windscreen.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Do_You_Require_Windscreen_Button { get; set; }        

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.volExcess.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.volExcess.vt'] label")]
        public IWebElement Your_Voluntary_Excess_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.volExcess.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.volExcess.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Your_Voluntary_Excess_Select { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbyears.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbyears.vt'] label")]
        public IWebElement Your_NCB_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbyears.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbyears.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Your_NCB_Select { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbprotected.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbprotected.vt'] label")]
        public IWebElement Would_you_protect_your_NCB_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbprotected.vt'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbprotected.vt'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbprotected.vt'] div.cmpInputButtonGroup button")]
        public IWebElement Would_you_protect_your_NCB_Button { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbcountry.vt'] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbcountry.vt'] label")]
        public IWebElement Where_Did_you_earn_your_NCB_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbcountry.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbcountry.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Where_Did_you_earn_your_NCB_Select { get; set; }
        
        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbtype.vt')] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbtype.vt')] label")]
        public IWebElement What_type_of_car_did_you_earn_NCB_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.ncbtype.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.ncbtype.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement What_type_of_car_did_you_earn_NCB_Select { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.permittedDrivers.vt')] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.permittedDrivers.vt')] label")]
        public IWebElement Who_will_be_insured_to_drive_the_car_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.vehicle.permittedDrivers.vt'] md-select")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.vehicle.permittedDrivers.vt'] md-select")]
        [SelectorFindsBy(How = How.CssSelector, Using = "div.md-clickable md-option")]
        public IWebElement Who_will_be_insured_to_drive_the_car_Select { get; set; }
        
        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.numberOfPeople.value')] label")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.numberOfPeople.value')] label")]
        public IWebElement Additional_drivers_Label { get; set; }

        [ErrorPanel(How.CssSelector, "[model='vm.data.policy.numberOfPeople.value'] div.cmpInputButtonGroup button")]
        [FindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.numberOfPeople.value'] div.cmpInputButtonGroup button")]
        [SelectorFindsBy(How = How.CssSelector, Using = "[model='vm.data.policy.numberOfPeople.value'] div.cmpInputButtonGroup button")]
        public IWebElement Additional_drivers_Button { get; set; }
        

        [ErrorPanel(How.CssSelector, "md-toolbar > button:nth-child(2)")]
        [FindsBy(How = How.CssSelector, Using = "md-toolbar > button:nth-child(2)")]
        public IWebElement Vehicle_Next_Button { get; set; }




        public override void Visit()
        {
            PageObjectHelpers.GetWait().Until(
                d => d.FindElement(By.XPath("//*[@id=\"main\"]/div/div/span")).Text.Trim() == "Your Car Details");

            base.Visit();
        }

        public override IDataCapturePage ClickNext(bool expectNextPage)
        {
            Vehicle_Next_Button.Click(int.Parse(ConfigurationManager.AppSettings["timeToSleep"]));

            if (expectNextPage)
            {
                var Driver1 = new Driver1Page(Driver, ScenarioContext);

                PageFactory.InitElements(Driver, Driver1);

                return Driver1;
            }

            return this;

        }
    }
}
