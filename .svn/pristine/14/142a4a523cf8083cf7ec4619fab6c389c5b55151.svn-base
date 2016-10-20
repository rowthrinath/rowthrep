using NUnit.Framework;
using OpenGI.Ecom.Automation.Selenium.Framework.Attributes;
using OpenGI.Ecom.Automation.Selenium.Framework.ExtensionMethods;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects;
using OpenGI.Ecom.Automation.TPR.Selenium.PageObjects;
using OpenGI.Ecom.Automation.Selenium.Framework.PageObjects.Interfaces;
using OpenGI.Selenium.Extensions;
using OpenGI.Selenium.Helpers;
using OpenGI.Selenium.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using OpenGI.Ecom.Automation.Selenium.Framework.StepDefinitions;

namespace OpenGI.Ecom.Automation.TPR.Selenium.StepDefinitions
{
    /// <summary>
    /// Then bindings
    /// </summary>
    /// <seealso cref="OpenGI.Ecom.Automation.TPR.Selenium.StepDefinitions.BindingsBase" />
    [Binding]
    public sealed class ThenBindings : BindingsBase
    {
        public ThenBindings(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        { }

        [Then(@"I should move to the Declarations accordion")]
        public void ThenIShouldMoveToTheDeclarationsAccordion()
        {
            Assert.That(
                (ScenarioContext["page"] as DeclarationsPage).HasNonMotoringConviction.First().Displayed,
                Is.EqualTo(true));
        }

        [Then(@"I should move to the Your Business accordion")]
        public void ThenIShouldMoveToTheYourBusinessAccordion()
        { 
            Assert.That(
                (ScenarioContext["page"] as YourBusinessPage).IsLimitedCompany.First().Displayed,
                Is.EqualTo(true));
        }

        [Then(@"I should move to the Business Activities accordion")]
        public void ThenIShouldMoveToTheBusinessActivitiesAccordion()
        {
            Assert.That(
                (ScenarioContext["page"] as BusinessActivitiesPage).QualificationRequired.First().Displayed,
                Is.EqualTo(true));
        }

        [Then(@"I should move to the Your Details accordion")]
        public void ThenIShouldMoveToTheYourDetailsAccordion()
        {
            Assert.That(
                (ScenarioContext["page"] as YourDetailsPage).Title.WrappedElement.Displayed,
                Is.EqualTo(true));
        }

        [Then(@"I should move to the Further Information accordion")]
        public void ThenIShouldMoveToTheFurtherInformationAccordion()
        {
            Assert.That(
    			(ScenarioContext["page"] as FurtherInformationPage).HouseNumberOrName.Displayed,
    			Is.EqualTo(true));
        }
    }
}
