using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class Products
    {
        WebDriver _driver;
        const string backpackID = "add-to-cart-sauce-labs-backpack";
        const string bikeLightID = "add-to-cart-sauce-labs-bike-light";
        const string tShirtID = "add-to-cart-sauce-labs-bolt-t-shirt";
        const string jacketID = "add-to-cart-sauce-labs-fleece-jacket";
        const string onesieID = "add-to-cart-sauce-labs-onesie";
        const string cartClass = "shopping_cart_link";

        public Products(WebDriver driver)
        {
            _driver = driver;
        }

        public void AddBackpackToCart()
        {
            Utility.WaitHelper.WaitForElementToBeVisible(_driver, By.Id(backpackID), 3);
            _driver.FindElement(By.Id(backpackID)).Click();
        }

        public void GoToCart()
        {
            Utility.WaitHelper.WaitForElementToBeVisible(_driver, By.ClassName(cartClass), 3);
            _driver.FindElement(By.ClassName(cartClass)).Click();
        }
    }
}
