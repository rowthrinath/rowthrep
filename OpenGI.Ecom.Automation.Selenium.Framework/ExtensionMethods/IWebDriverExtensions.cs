using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Extensions;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods
{
    /// <summary>
    /// OpenQA.Selenium.IWebDriver extension methods
    /// </summary>
    public static class IWebDriverExtensions
    {
        /// <summary>
        /// Determines whether the specified error panel has the error class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="errorPanelId">The error panel ID.</param>
        /// <returns></returns>
        public static bool HasError(this IWebDriver driver, By errorPanelId)
        {
            if (errorPanelId.ToString().Contains("By.Id")) 
            { 
                return driver.FindElement(errorPanelId)
                       .GetAttribute("class").Split(' ').Contains("inError");
            }
            else
            {
                return driver.FindElement(errorPanelId) != null;
            }

        }

        /// <summary>
        /// Waits for accordion transition by wating for all visible inputs to be displayed.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public static void WaitForAccordionTransition(this IWebDriver driver, BaseDataCapturePage dataCapturePage)
        {
            driver.WaitUntilDisplayed(By.Id(dataCapturePage.PanelId));
            dataCapturePage.AllInputs.ToList().ForEach(x => { driver.WaitUntilDisplayed(By.Id(x.GetAttribute("id"))); });
        }

        /// <summary>
        /// Waits for validation.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public static void WaitForValidation(this IWebDriver driver)
        {
            PageObjectHelpers.GetWait().Until(d => (d as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
        }
    }
}
