using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods
{
    public static class RadioButtonExtensions
    {
        public static void ClickRadioButton(this IList<IWebElement> elements, string value)
        {
            GetRadioButton(elements, value).Click();
        }

        private static IWebElement GetRadioButton(IList<IWebElement> elements, string value)
        {
            return elements.Single(
                    x => string.Equals(
                        x.GetAttribute("value"),
                        value,
                        StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
