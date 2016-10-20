using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGI.Ecom.Automation.Selenium.Framework.Attributes
{
    public class LabelAttribute : Attribute
    {
        public By By
        {
            get
            {
                var methodInfo = typeof(By).GetMethod(How.ToString());
                return methodInfo.Invoke(null, new object[] { Using }) as By;
            }
        }

        public How How { get; set; }            //How for Element that would trigger help text popup
        public string Using { get; set; }       //using for Element that would trigger help text popup
        public string Wording { get; set; }
    }
}
