using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1_june10.selenium
{
    [TestFixture]
    public class framehandling
    {[Test]
        public void framework()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            driver.Manage().Window.Maximize();
            IWebElement frameElement = driver.FindElement(By.ClassName("demo-frame"));
            driver.SwitchTo().Frame(frameElement);
            System.Threading.Thread.Sleep(2000);
            IWebElement dragElement = driver.FindElement(By.Id("draggable"));
            IWebElement dropElement = driver.FindElement(By.Id("droppable"));
            Actions actions = new Actions(driver);
            actions.DragAndDrop(dragElement,dropElement).Perform();

            if (dropElement.Text.Equals("Dropped!"))
                Console.WriteLine("succesful");
            else
                Console.WriteLine("not success");
        }
    }
}
