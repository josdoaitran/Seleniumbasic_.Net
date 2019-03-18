using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
                Console.WriteLine("Passed");

            }
            else
            {
                Console.WriteLine("Failed, current title: " + actualTitle);
            }
        }
        [TestMethod]
        public void Test_BasicAction()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://en.wikipedia.org/wiki/Wiki";
            driver.FindElement(By.CssSelector("#searchInput")).Clear();
            driver.FindElement(By.CssSelector("#searchInput")).SendKeys("Selenium");
            driver.FindElement(By.Id("searchButton")).Click();
            driver.Quit();
        }
        [TestMethod]
        public void TestList()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://en.wikipedia.org");
            driver.Manage().Window.Maximize();
        }
    }
}
