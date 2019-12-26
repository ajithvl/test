using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace HeadspinDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchForCheese()
        {
            //using (var driver = new ChromeDriver()
            //{
            //    driver.Navigate().GoToUrl("http://www.google.com")
            //}
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            ChromeDriver driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.Quit();
        }
    }
}
