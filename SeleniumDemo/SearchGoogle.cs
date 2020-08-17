using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemo
{
    [TestClass]
    public class SearchGoogle
    {

        [TestMethod]
        public void SearchForCheese()
        {
            var directoryPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf(@"\bin\"));

            directoryPath = System.IO.Path.Combine(directoryPath, "driver");
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            var  driver = new ChromeDriver(directoryPath,chromeOptions);

            driver.Navigate().GoToUrl("https://google.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("q")).SendKeys("Hello World");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("btnK")).SendKeys(Keys.Return);

            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
