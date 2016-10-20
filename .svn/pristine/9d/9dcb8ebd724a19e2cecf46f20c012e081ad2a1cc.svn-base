using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGI.Selenium.Extensions;
using TechTalk.SpecFlow;
using System.Configuration;

namespace OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IWebElement> GroupDateFields(this IEnumerable<IWebElement> inputs,ScenarioContext scenarioContext)
        {
            var inputList = inputs.ToList();
            var dateMMYYClasses = new []{"controlMM","controlYYYY"};
            inputList.RemoveAll(x => dateMMYYClasses.Contains(x.GetAttribute("class")));
            return inputList;
        }
    }
}
