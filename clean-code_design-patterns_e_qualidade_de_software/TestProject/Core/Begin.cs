global using NUnit.Framework;
global using OpenQA.Selenium;
global using OpenQA.Selenium.Edge;
global using TestProject.Core;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject.Core
{
    public class Begin : DSL
    {
        [SetUp]
        public void Setup()
        {
            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArguments("disable-cache");
            edgeOptions.AddArguments("start-maximized");
            driver = new EdgeDriver();
            // https://buscacepinter.correios.com.br/app/endereco/index.php
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            new DriverManager().SetUpDriver(new EdgeConfig());

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //[Test]
        //public void Test()
        //{
            //Console.WriteLine("Tudo OK");
        //}

        [TearDown]
        public void FimDoTest()
        {
            if (driverQuit) driver.Quit();
            
        }
    }
}