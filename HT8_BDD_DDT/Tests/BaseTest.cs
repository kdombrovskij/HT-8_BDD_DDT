using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace HT8_BDD_DDT.Tests
{
    class BaseTest
    {
        private IWebDriver _driver;
        public IWebDriver Driver { get { return _driver; } }

        [SetUp]
        public void Setup()
        {
            Serilog.Log.Logger = new LoggerConfiguration()
               .WriteTo.File(@"D:\HT\HT6\HT8_BDD_DDT\Logs\Logs.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();
            Serilog.Log.Information("Log started");
            _driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
            Serilog.Log.Information("Log closed");
        }

        [BeforeScenario]
        protected void DoBeforeAllScenarios()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
            }
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://rozetka.com.ua/ua/");
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        protected void DoAfterAllScenarios()
        {
            _driver.Quit();
        }
    }
}
