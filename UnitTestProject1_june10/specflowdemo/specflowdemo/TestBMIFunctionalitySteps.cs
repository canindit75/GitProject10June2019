using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace specflowdemo
{
    [Binding]
    public class TestBMIFunctionalitySteps
    {
        IWebDriver driver;
        [Given(@"when the user is on BMI home page")]
        public void GivenWhenTheUserIsOnBMIHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/bmi-calculator.html");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"the user enters age (.*)")]
        public void GivenTheUserEntersAge(string age)
        {
            driver.FindElement(By.Id("cage")).SendKeys("45");
        }
        
        [Given(@"the user selects sex")]
        public void GivenTheUserSelectsSex()
        {

            IList<IWebElement> sexlist = driver.FindElements(By.Name("csex"));
            Console.WriteLine(sexlist.Count);
            if (sexlist.Count > 0)
            {
                foreach (IWebElement sex in sexlist)
                {
                    if (sex.GetAttribute("value").Equals("f"))
                    {
                        if (!sex.Selected)
                            sex.Click();
                        break;
                    }
                }
            }


        }
        
        [Given(@"the user enters heightfeet")]
        public void GivenTheUserEntersHeightfeet()
        {
            driver.FindElement(By.Id("cheightfeet")).SendKeys("5");
        }
        
        [Given(@"the user enters heightinch")]
        public void GivenTheUserEntersHeightinch()
        {
            driver.FindElement(By.Id("cheightinch")).SendKeys("5");
        }
        
        [Given(@"the user enters weight")]
        public void GivenTheUserEntersWeight()
        {
            driver.FindElement(By.Id("cpound")).SendKeys("70");
        }
        
        [When(@"the user clicks on Calculate Button")]
        public void WhenTheUserClicksOnCalculateButton()
        {
            IWebElement element = driver.FindElement(By.CssSelector("#content > div.panel2 > table:nth-child(4) > tbody > tr:nth-child(3) > td:nth-child(2) > input[type=image]:nth-child(2)"));
            element.Click();
        }
        
        [Then(@"the user should be dispalyed with BMI and BMI category")]
        public void ThenTheUserShouldBeDispalyedWithBMIAndBMICategory()
        {

            
        }
        
        [Then(@"the user verifies the BMI category")]
        public void ThenTheUserVerifiesTheBMICategory()
        {
            

        }
    }
}
