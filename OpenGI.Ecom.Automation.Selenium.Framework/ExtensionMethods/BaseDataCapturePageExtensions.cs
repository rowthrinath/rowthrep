using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods
{
    /// <summary>
    /// BaseDataCapturePage extension methods
    /// </summary>
    public static class BaseDataCapturePageExtensions
    {
        /// <summary>
        /// Gets the questions.
        /// </summary>
        /// <param name="baseDataCapturePage">The base data capture page.</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetQuestions(this BaseDataCapturePage baseDataCapturePage)
        {
            return baseDataCapturePage.GetType().GetProperties().Where(
                x => x.PropertyType.ToString().StartsWith("OpenQA.Selenium") ||
                x.PropertyType.ToString().StartsWith("System.Collections.Generic")).Where(
                    x => !x.CustomAttributes.Any(y => y.AttributeType == typeof(IgnoreWebElementAttribute)));
        }

        /// <summary>
        /// Gets the question names.
        /// </summary>
        /// <param name="baseDataCapturePage">The base data capture page.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetQuestionNames(this BaseDataCapturePage baseDataCapturePage)
        {
            return baseDataCapturePage.GetQuestions().Select(x => x.Name);
        }
    }
}
