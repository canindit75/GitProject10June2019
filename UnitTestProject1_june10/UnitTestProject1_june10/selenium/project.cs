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
    public class project
    {
        [Test]
        public void BMI()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/bmi-calculator.html");
            driver.Manage().Window.Maximize();
            IWebElement ageElement = driver.FindElement(By.Id("cage"));
            Console.WriteLine("print the current value" + ageElement.GetAttribute("value"));
            ageElement.Clear();
            ageElement.SendKeys("25");

            IWebElement heightElement = driver.FindElement(By.Id("cheightfeet"));
            Console.WriteLine("print the current value" + heightElement.GetAttribute("value"));
            heightElement.Clear();
            heightElement.SendKeys("5");

            IWebElement heightinElement = driver.FindElement(By.Id("cheightinch"));
            Console.WriteLine("print the current value" + heightinElement.GetAttribute("value"));
            heightinElement.Clear();
            heightinElement.SendKeys("5");

            IWebElement weightElement = driver.FindElement(By.Id("cpound"));
            Console.WriteLine("print the current value" + weightElement.GetAttribute("value"));
            weightElement.Clear();
            weightElement.SendKeys("68");

            driver.FindElement(By.CssSelector("#content > div.leftinput > div.panel2 > table > tbody > tr > td > table:nth-child(4) > tbody > tr > td > input[type=image]:nth-child(2)")).Click();
            IWebElement xlink = driver.FindElement(By.XPath("//*[@id='content']/div[4]/div/b"));
            Console.WriteLine(xlink.Text);
            String str = xlink.Text;
            int p = str.IndexOf("=");
            String s2 = str.Substring( p + 1);
            String s3 = s2.Replace("kg/m2", " ");
            Console.WriteLine(s3);

            double d = Convert.ToDouble(s3);
            String ExpectedCatogary = findBMICategory(d);
            //double string.fin

        }
        public String findBMICategory(double bmi)
        {
            String expcat = null;
            if (bmi < 16)
                expcat = "Severe Thinness";
                
            else if (bmi >= 16 && bmi < 17)
                expcat = "Moderate Thinness";
            else if (bmi >= 17 && bmi < 18.5)
                expcat = "Mild Thinness";
            else if (bmi >= 18.5 && bmi < 25)
                expcat = "Normal";
            else if (bmi >= 25 && bmi < 30)
                expcat = "Overweight";
            else if (bmi >= 30 && bmi < 35)
                expcat = "Obese Class I";

            Console.WriteLine("problem is = " + expcat);

        }

       

    }
}
