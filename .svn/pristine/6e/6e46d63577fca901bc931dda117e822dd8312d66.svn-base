using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGI.Ecom.Automation.Selenium.Framework.Attributes
{
    /// <summary>
    /// Error Panel Attribute class to define the HTML ID that should be in error
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class ErrorPanelAttribute : Attribute
    {
        public How How { get; set; }            
        public string Using { get; set; }
        public string errorPanelId { get; set; }

        public By By
        {
            get
            {
                var methodInfo = typeof(By).GetMethod(How.ToString());
                return methodInfo.Invoke(null, new object[] { Using }) as By;
            }
        }

        public ErrorPanelAttribute(How how,string howUsing)
        {
            this.How = how;
            this.Using = howUsing;
        }

        public ErrorPanelAttribute(string errorPanelId)
        {
            this.errorPanelId = errorPanelId;
            this.How = How.Id;
            this.Using = errorPanelId;
        }
    }
}
