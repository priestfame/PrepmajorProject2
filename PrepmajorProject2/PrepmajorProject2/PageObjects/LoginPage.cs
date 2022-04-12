using OpenQA.Selenium;
using PrepmajorProject2.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrepmajorProject2.PageObjects
{
    class LoginPage
    {

        IWebDriver driver;

        public LoginPage()
        {
            driver = BaseTest.driver;
        }
        private By login = By.CssSelector("#header > div > div.container > div > div > div > div.right-unit > a.stm_lms_log_in > span");
        private By username = By.CssSelector("div.stm_lms_login_wrapper > div:nth-child(1) > input");
        private By password = By.CssSelector("#stm-lms-login > div.stm_lms_login_wrapper > div:nth-child(2) > input");
        private By loginButton = By.CssSelector("div.stm_lms_login_wrapper > div:nth-child(2) > input");
        private By logo = By.XPath("//*[@id='header']/div/div[2]/div/div/div/div[1]/a/img");

        

        public void Login()
        {
            driver.FindElement(login).Click();
        }
        public void Username(string nametxt)
        {
            driver.FindElement(username).SendKeys(nametxt);
        }

        public void Password(string passtxt)
        {
            driver.FindElement(password).SendKeys(passtxt);
        }

        public void LoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
       
        

        public bool LogoIsDisplayed()
        {

            return driver.FindElement(logo).Displayed;
        }


    }

}
