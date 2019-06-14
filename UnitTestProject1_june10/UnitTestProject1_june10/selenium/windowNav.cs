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
     public class windowNav
    {
        private object login;

        [Test]
        public void windownavigation()
        {
            IWebDriver driver = new ChromeDriver("https://www.online.citibank.co.in/products-services/online-services/internet-banking.htm");
            driver.Navigate().GoToUrl("");
            driver.Manage().Window.Maximize();
            String parentwindowid = driver.CurrentWindowHandle;
            Console.WriteLine("parent window id" + parentwindowid);
            IWebElement printerElement = driver.FindElement(By.XPath("//*[@title='LOGIN NOW"));
            login.click();
            IList<String>win




            String subWindowId = null;
            for(int i =0; i< winids.Count; i++)
            {
                mainWindowId = winids[0];
                subWindowId = Winids[1];
            }
            Console.WriteLine


        }
    }
}
