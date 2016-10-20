using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
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
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;

namespace OpenGI.Ecom.Automation.Selenium.Framework.PageObjects
{
    /// <summary>
    /// Data capture base page - all page objects should inherit from this
    /// </summary>
    public abstract class BaseDataCapturePage : BasePage
    {
        public BaseDataCapturePage(IWebDriver driver, ScenarioContext scenarioContext, string panelId)
            : base(driver, scenarioContext)
        {
            PanelId = panelId;
        }

        [FindsBy(How = How.CssSelector, Using = "input, select")]
        private IList<IWebElement> _allInputs;

        
        [FindsBy(How = How.CssSelector, Using = "md-pagination-wrapper, md-tab-item")]
        private IList<IWebElement> _allTabsWrapper;

        [FindsBy(How = How.CssSelector, Using = "[model]")]
        public IList<IWebElement> AllModels;


        [FindsBy(How = How.ClassName, Using = "ui-autocomplete")]
        private IList<IWebElement> _autoCompleteWrappers;

        public virtual IList<IWebElement> AllInputs
        {

            get
            {
                
                // Return all inputs minus those hidden and the submit button
                return _allInputs.Where(x => x.Displayed &&
                    (string.IsNullOrEmpty(x.GetAttribute("type")) ||
                        !string.Equals(
                            x.GetAttribute("type"),
                            "submit",
                            StringComparison.InvariantCultureIgnoreCase))).GroupBy(x => x.GetAttribute("name")).Select(x => x.First())          //eliminate same fields (radio buttons)
                                                                          .GroupDateFields(ScenarioContext)
                                                                          .ToList();
                
            }
        }


        public IWebElement AllTabsWrapper
        {
            get
            {
                return _allTabsWrapper.FirstOrDefault(x => x.Displayed);
            }
        }

        public IList<IWebElement> AllTabs { get
            {
                return AllTabsWrapper.FindElements(By.ClassName("md-tab"));

                
            }
        }


        //public IWebElement CurrentTabWrapper
        //{
        //    get
        //    {
        //        return _currentTabWrapper.FirstOrDefault(x => x.Displayed);
        //    }
        //}

        public IWebElement CurrentTab {  get
            {
                return AllTabsWrapper.FindElement(By.ClassName("md-active"));
            }
        }



        public IWebElement AutocompleteWrapper
        {
            get
            {
                return _autoCompleteWrappers.FirstOrDefault(x => x.Displayed);
            }
        }


        public IList<IWebElement> AutocompleteItems { get
            {
                return AutocompleteWrapper.FindElements(By.TagName("a"));
            }
        }

        public virtual By HelpTextWordingQtipSelector
        {
            get
            {
                return By.XPath("//div[contains(@class,'qtip')]");
            }
        }


        public string PanelId { get; private set; }

        /// <summary>
        /// Clicks the next.
        /// </summary>
        /// <param name="expectNextPage">if set to <c>true</c> [expect next page].</param>
        /// <returns></returns>
        public abstract IDataCapturePage ClickNext(bool expectNextPage);


        //If we add this we have to impliment across all the pages that inherit this :(
        public virtual IDataCapturePage ClickBack(bool expectPreviousPage) { return null; }

        /// <summary>
        /// Visits this instance.
        /// </summary>
        public virtual void Visit()
        {
            Thread.Sleep(50);

            PageFactory.InitElements(Driver, this);

            ScenarioContext["page"] = this;
        }
    }
}
