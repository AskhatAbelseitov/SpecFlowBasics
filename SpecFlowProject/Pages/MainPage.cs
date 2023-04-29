using System;
using OpenQA.Selenium;
using SpecFlowProject.Pages;

namespace SpecFlow.Pages
{
    class MainPage
    {
        private IWebDriver driver;
        private readonly By _acceptCookies = By.XPath("//button[@id='consent-accept']");
        
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }            

        public MainPage MainPageOpen()
        {
            driver.Navigate().GoToUrl("https://specflow.org/");
            driver.Manage().Window.Maximize();
            Waits.WaitSomeInterval();
            //driver.FindElement(_acceptCookies).Click();
            return this;
        }
    }
}





