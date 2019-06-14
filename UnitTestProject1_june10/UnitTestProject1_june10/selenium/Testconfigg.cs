using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace UnitTestProject1_june10.selenium
{
    [TestFixture]
    public class Testconfigg
    {
        
        [Test]
        public void TestConfigurationSettings()
        {
            var ConnetctionStringVal = ConfigurationManager.ConnectionStrings["DBConnectionString"];
            Console.WriteLine("connection string" + ConnetctionStringVal);
            var AppUrl  = ConfigurationManager.AppSettings["URL"];
            Console.WriteLine("connection string" + AppUrl);

        }


    }
}
