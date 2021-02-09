using System;
using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWithC_{
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Hello World! NBN Project");
            IWebDriver driver;
            String  homeURL = "https://www.google.com";
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl(homeURL);

            //IWebElement searchTextBox =driver.FindElement(By.CssSelector("[name = 'q']"));
            IWebElement searchTextBox =driver.FindElement(By.XPath("//input[@title='Search']"));
            searchTextBox.SendKeys("LambdaTest");
            IWebElement searchButton = 
            //driver.FindElement(By. XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));
            driver.FindElement(By.XPath("//input[@value='Google Search']"));
            searchButton.Click();
            System.Threading.Thread.Sleep(6000);
            driver.Quit();
        }
    }
}
