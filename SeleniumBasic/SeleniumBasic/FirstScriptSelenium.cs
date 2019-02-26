using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumBasic
{
    public class FirstScriptSelenium
    {
        static void test(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
        }
    }
}
