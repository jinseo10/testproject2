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
    public class CheckoutBackPack
    {
        WebDriver driver;
        Home home;
        Cart cart;
        Products products;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            home = new Home(driver);
            cart = new Cart(driver);
            products = new Products(driver);
        }
        [Test]
        public void CheckoutBackPackTest()
        {
            home.Login();
            products.AddBackpackToCart();
            products.GoToCart();
            cart.Checkout();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
