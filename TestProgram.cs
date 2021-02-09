using System;
using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pack1{
    
    [TestFixture ]
    public class TestProgram{
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest(){
             driver = new ChromeDriver();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TearDown]
        public void TeardownTest(){
            driver.Quit();
        }

        [Test(Description="This is test method to launch Google")]
        public void testMethod(){
            homeURL = "https://www.google.com";
            driver.Navigate().GoToUrl(homeURL);
            IWebElement searchTextBox =driver.FindElement(By.CssSelector("[name = 'q']"));
            searchTextBox.SendKeys("LambdaTest");
            IWebElement searchButton = 
            driver.FindElement(By. XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));
 
            searchButton.Click();
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Test Passed");
         }
        
    }
}