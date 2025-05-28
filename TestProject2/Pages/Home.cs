using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    public class Home
    {
        private WebDriver _driver;
        private string UsernameFieldID = "user-name";
        private string PasswordFieldID = "password";
        private string LoginButtonID = "login-button";

        public Home(WebDriver driver)
        {
            _driver = driver;
        }

        public void Login()
        {
            Utility.WaitHelper.WaitForElementToBeVisible(_driver, By.Id(UsernameFieldID), 3);
            _driver.FindElement(By.Id(UsernameFieldID)).SendKeys(Config.Username);
            _driver.FindElement(By.Id(PasswordFieldID)).SendKeys(Config.Password);
            _driver.FindElement(By.Id(LoginButtonID)).Click();
        }
    }
}
