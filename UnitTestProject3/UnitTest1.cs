using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
     
        public static string siteURL = "https://google.com";

        [TestMethod]
        public void TestMethod2()

        {
            var driver = new ChromeDriver();
            var otac;
            driver.Navigate().GoToUrl(siteURL);

            Task.Delay(2000).Wait();


            var userName = driver.FindElement(By.Id("lst-ib"));

            userName.SendKeys("ius sarajevo");

            Task.Delay(2000).Wait();


            var signIn = driver.FindElement(By.Name("btnK"));

            signIn.Click();


            Task.Delay(5000).Wait();


            driver.Quit();

        }
    }
}
