using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class Cart
    {
        WebDriver _driver;
        const string checkoutButtonID = "checkout";

        public Cart(WebDriver driver)
        {
            _driver = driver;
        }

        public void Checkout()
        {
            Utility.WaitHelper.WaitForElementToBeVisible(_driver, By.Id(checkoutButtonID), 3);
            _driver.FindElement(By.Id(checkoutButtonID)).Click();
        }
    }
}
