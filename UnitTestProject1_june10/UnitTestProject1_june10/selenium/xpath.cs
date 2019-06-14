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
    public class xpath
    {
        [Test]
        public void xpah()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();

            IWebElement xlink =driver.FindElement(By.XPath("//*[@id='calinputtable']/tbody/tr[1]/td[1]"));
            Console.WriteLine(xlink.TagName);

        }
    }
}
