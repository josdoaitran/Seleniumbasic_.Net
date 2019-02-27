using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumBasic
{
    [TestClass]
    public class FirstScriptSelenium
    {
        [TestMethod]
        public void test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
            driver.Manage().Window.Maximize();
            driver.Close();
        }
    }
}
