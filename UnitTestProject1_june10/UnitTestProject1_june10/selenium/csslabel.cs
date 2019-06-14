using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace UnitTestProject1_june10.selenium
{
    [TestFixture]
    public class css
    {
    [Test]
        public void cssage()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
                driver.Manage().Window.Maximize();

                IWebElement element = driver.FindElement(By.CssSelector("#calinputtable > tbody > tr:nth-child(1) > td:nth-child(1)"));
                Console.WriteLine(element.Text);
             }

     }
}
