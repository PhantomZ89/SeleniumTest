using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"D:\Projects\UnitTestProject1\UnitTestProject1");
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");
            Task.Delay(5000).Wait();

            driver.Quit();
        }
    }
}
