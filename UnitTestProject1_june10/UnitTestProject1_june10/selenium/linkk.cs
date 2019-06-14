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
    public class linkk
    {
        [Test]
        public void locatelinks()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            Console.WriteLine("title of the page " + title);
            Console.WriteLine("current url of the page " + driver.Url);
            driver.FindElement(By.LinkText("BMI")).Click();
            Console.WriteLine("current title of the page " + driver.Url);
          

              //*[@id="calinputtable"]/tbody/tr[1]/td[1]
        }
    }
}
