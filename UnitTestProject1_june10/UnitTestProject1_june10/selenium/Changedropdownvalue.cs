using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject1_june10.selenium
{
    [TestFixture]
     public class Changedropdownvalue
    {
    [Test]
    public void dropdown()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            IWebElement activitydd = driver.FindElement(By.Id("cactivity"));
            SelectElement select = new SelectElement(activitydd);
            Console.WriteLine("default dropdown value " + select.SelectedOption.Text);
            select.SelectByIndex(0);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("current value changed from index to basel " + select.SelectedOption.Text);
            select.SelectByValue("1.55");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("current value changed from value 1.55 " + select.SelectedOption.Text);
            //Console.WriteLine("current value changed from value 1.55 " + select.SelectedOption.Text);
        }
    }
}
