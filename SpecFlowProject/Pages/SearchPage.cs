using System;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProject.Pages;

namespace SpecFlow.Pages
{
    class SearchPage
    {

        private IWebDriver driver;
        private readonly By _searchField = By.XPath("//div//form[@id='rtd-search-form']");
        private readonly By _searchFieldInput = By.CssSelector("div input.search__outer__input");
        private readonly By _searchResultTitle = By.XPath("(//div[@class='search__result__single']//a//h2//span)[1]");
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SearchFieldOpen()
        {
            Waits.WaitElement(driver, _searchField);
            driver.FindElement(_searchField).Click();
        }

        public void SearchFieldInputAndFindTopic()
        {
            Waits.WaitSomeInterval();
            driver.FindElement(_searchFieldInput).SendKeys("Installation");
            Waits.WaitElement(driver, _searchResultTitle); 
            driver.FindElement(_searchResultTitle).Click();     
            driver.Quit();
        }
    }
}

