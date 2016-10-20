using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenGI.Selenium.Extensions;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;
using OpenGI.Selenium.Helpers;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;

namespace OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods
{
    /// <summary>
    /// OpenQA.Selenium.IWebElement extension methods
    /// </summary>
    public static class IWebElementExtensions
    {
        /// <summary>
        /// Clicks the specified element with a wait.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="secondsToWait">The seconds to wait.</param>
        public static void Click(this IWebElement element, int secondsToWait)
        {
            // Todo: do this better
            try
            {
                Thread.Sleep(secondsToWait * 1000);
                element.Click();
            }
            catch
            {
                Thread.Sleep(secondsToWait * 1000);

                element.Click();
            }
        }

        public static void Hover(this IWebElement question, ScenarioContext scenarioContext,string questionName)
        {
            var dataCapture = scenarioContext["page"] as BaseDataCapturePage;
            var helpTextAttribute = StepDefinitionHelpers.GetQuestionHelpTextSelector(questionName, scenarioContext);
            var image = StepDefinitionHelpers.GetDriver(scenarioContext).FindElement(helpTextAttribute.By);
            image.Hover(StepDefinitionHelpers.GetDriver(scenarioContext), dataCapture.HelpTextWordingQtipSelector);
        }

        public static void Hover(this IWebElement question, IWebDriver driver,By waitforBy = null)
        {
            Actions action = new Actions(driver);
            
            action.MoveToElement(question).Click().Build().Perform();

            if (waitforBy != null) 
            {
                PageObjectHelpers.GetWait(5).Until(E => E.FindElement(waitforBy) != null);
            }
        }
        
    }
}
