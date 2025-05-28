using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Pages;

namespace TestProject2.Tests
{
    public class LoginTo
    {
        private WebDriver _driver;
        private Home home;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(Config.BaseURL);
            home = new Home(_driver);
        }

        [Test]
        public void Login()
        {
            home.Login();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }
    }
}
