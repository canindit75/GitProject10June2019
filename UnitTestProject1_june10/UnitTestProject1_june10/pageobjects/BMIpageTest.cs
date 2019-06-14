using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1_june10.pageobjects
{[TestFixture]
     public class BMIpageTest
    {
        [Test]
        public void BMIpageTestcase()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            pageobjects.BMIpage bmipage = new pageobjects.BMIpage(driver);
            bmipage.EnterBMIDetails("44", "f", "5");

        }
    }
}
