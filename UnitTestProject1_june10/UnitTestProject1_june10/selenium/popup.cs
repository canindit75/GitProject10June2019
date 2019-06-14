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
    class popup
    {
        [Test]
        public void alertpopmethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("alert('this is an information')");
            System.Threading.Thread.Sleep(2000);
            IAlert alert = driver.SwitchTo().Alert();
            string AlertMsg = alert.Text;
            alert.Accept();
            if (AlertMsg.Equals("this is an information"))
                Console.WriteLine("alert message found");
            else
                Console.WriteLine("alert message not found");



            //confirm alert popup
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("confirm('do you want to continue y/n')");
            System.Threading.Thread.Sleep(2000);
            alert = driver.SwitchTo().Alert();
            AlertMsg = alert.Text;
            alert.Dismiss();
            if (AlertMsg.Equals("do u want to continue y/n"))
                Console.WriteLine("alert message match found");
            else
                Console.WriteLine("alert message match not found");


        }
    }
}
