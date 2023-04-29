using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecFlowProject.Pages;
using SpecFlow.Pages;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class SpecFlowDocumentationFindStepDefinitions
    {
        private IWebDriver driver = new ChromeDriver();
       
        [Given("I am on the Main Page")]
        public void OpenTheMainPage()
        {
            var test = new MainPage(driver);
            test.MainPageOpen();               
        }

        [When("Open 'SpecFlow' section on 'Docs' tab")]
        public void OpenTheSpecFlowPage()
        {            
            var test = new DocumentationPage(driver);
            test.DocumentationPageOpen();
        }

        [When("Open 'SpecFlow Documentation' page")]
        public void OpenTheSpecFlowDocumentationPage()
        {
            var test = new DocumentationPage(driver);
            test.SpecFlowPageOpen();
        }
                
        [When("Enter keyword in the 'Search' field")]
        public void SearchFieldInput()
        {
            var test = new SearchPage(driver);
            test.SearchFieldOpen(); 
        }

        [Then("I can click on the any result title")]
        public void SearchResultView()
        {
            var test = new SearchPage(driver);
            test.SearchFieldInputAndFindTopic();
        }
    }    
}

