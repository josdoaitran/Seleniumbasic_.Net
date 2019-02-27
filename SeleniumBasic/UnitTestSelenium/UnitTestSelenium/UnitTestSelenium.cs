using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace UnitTestSelenium
{
    [TestClass]
    public class UnitTestSelenium
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://google.com";
            String actualTitle = driver.Title;
            String expectedTitle = "Google";

            if (actualTitle.Equals(expectedTitle))
            {
                Console.Out("DDDDDD");

            }
        }
    }
}
