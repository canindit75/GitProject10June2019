using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace UnitTestProject1_june10.selenium
{
    [TestFixture]
    public class webdriverwaitexample
    {
        [Test]
        public void web()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement menu = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            menu.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                IWebElement printerElement = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(printerElement).Click().Build().Perform();
                //actions.Mov
                Console.WriteLine(printerElement.TagName);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("printer element not found");
            }

        }
    }
}
