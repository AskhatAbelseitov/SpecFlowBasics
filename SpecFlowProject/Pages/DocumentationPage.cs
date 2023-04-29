using System;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using SpecFlowProject.Pages;

namespace SpecFlow.Pages
{
    class DocumentationPage
    {
       
        private IWebDriver driver;
        private readonly By _docsTab = By.XPath("//a[@href='https://docs.specflow.org/en/latest/']");
        private readonly By _specFlowTab = By.XPath("//div//ul//li//a[@href='https://docs.specflow.org/projects/specflow/en/latest/']");


        public DocumentationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void DocumentationPageOpen()
        {
            driver.FindElement(_docsTab).Click();           
        }

        public void SpecFlowPageOpen()
        {
            Waits.WaitSomeInterval();
            driver.FindElement(_specFlowTab).Click();
        }
    }
}

