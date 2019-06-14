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
{
    public class BMIpage
    {
        IWebDriver driver;
        public BMIpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.Id, Using = "cage")]
        private IWebElement ageTextbox;

        [FindsBy(How = How.Name, Using = "csex")]
        private IList<IWebElement> sexlist;

        [FindsBy(How = How.XPath, Using = "//*[@id='cheightfeet']")]
        private IWebElement heightfeettextbox;

        public void EnterBMIDetails(string age, string Sex, string heightfeet)
        {
            ageTextbox.Clear();
            ageTextbox.SendKeys(age);


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


            heightfeettextbox.Clear();
            heightfeettextbox.SendKeys(heightfeet);
        }


    }


    }  