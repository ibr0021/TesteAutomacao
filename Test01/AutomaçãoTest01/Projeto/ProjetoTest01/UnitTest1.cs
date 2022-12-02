using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace ProjetoTest01
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\cinti\Downloads\CursoAutomação-Selenium e C#\TesteAutomacao\Test01\AutomaçãoTest01\bin\Debug");
            driver.Navigate().GoToUrl("https://google.com.br");
            driver.TakeScreenshot().SaveAsFile(AppDomain.CurrentDomain.BaseDirectory+"print1.jpg");
        }
    }
}
