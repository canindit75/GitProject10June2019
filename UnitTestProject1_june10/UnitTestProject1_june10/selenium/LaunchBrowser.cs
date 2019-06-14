using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1_june10.selenium
{[TestFixture]
    class LaunchBrowser  
    {
        [Test]
        public void Launc()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            driver.Manage().Window.Maximize();
            IWebElement ageElement = driver.FindElement(By.Id("cage"));
            Console.WriteLine("print the current value" + ageElement.GetAttribute("value"));
            ageElement.Clear();
            ageElement.SendKeys("45");
            Console.WriteLine("print the current value again" + ageElement.GetAttribute("value"));
            Console.WriteLine(ageElement.GetAttribute("id") + ageElement.GetAttribute("name"));
            Console.WriteLine(ageElement.TagName);

      

            IList<IWebElement> sexlist = driver.FindElements(By.Name("csex"));
            Console.WriteLine(sexlist.Count);
            if (sexlist.Count > 0)
            {
                foreach (IWebElement sex in sexlist)
                {
                    if (sex.GetAttribute("value").Equals("f"))
                    {
                        if (!sex.Selected)
                            sex.Click();
                        break;
                    }
                }
            }

            IWebElement table = driver.FindElement(By.ClassName("cinfoT"));
            IList<IWebElement> Rows  = table.FindElements(By.TagName("tr"));

            foreach (IWebElement row in Rows)
            {
                IList<IWebElement> Cols = table.FindElements(By.TagName("td"));
                {
                    foreach(IWebElement col in Cols)
                    {
                        Console.Write(col.Text + "\t");

                    }
                    Console.WriteLine("\n");
                }
            }


        }
    }
}
