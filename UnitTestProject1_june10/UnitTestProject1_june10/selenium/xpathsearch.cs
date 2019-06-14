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
    public class xpathsearch
    {
        [Test]
        public void xpath()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            Console.WriteLine
            IList<IWebElement> startsswitch_idxpath = driver.FindElements(By.XPath("//*[@id='calinputtable']/tbody/tr[1]/td[1]"));
            foreach (IWebElement b in startsswitch_idxpath)
            {
                    //Console.WriteLine("printing all the elements start with c on attribute id using x path");
                    Console.WriteLine(b.GetAttribute("id");
                
            }


        }

    }
}
