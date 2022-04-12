using OpenQA.Selenium;
using PrepmajorProject;
using PrepmajorProject2.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrepmajorProject.PageObjects
{

    public class EyeIconPage
    {
        public IWebDriver driver;

        public EyeIconPage()
        {
            driver = BaseTest.driver;
        }


        private By login = By.CssSelector("//*[@id='header']/div/div[2]/div/div/div/div[3]/a[1]/span");
        private By username = By.CssSelector("div.stm_lms_login_wrapper > div:nth-child(1) > input");
        private By password = By.CssSelector("#stm-lms-login > div.stm_lms_login_wrapper > div:nth-child(2) > input");
        private By loginButton = By.CssSelector("div.stm_lms_login_wrapper > div:nth-child(2) > input");
        private By settingCogIcon = By.CssSelector("#header > div > div.container > div > div > div > div.right-unit > div.stm_lms_settings_button > a > i");
        private By settingPage = By.CssSelector("#user-settings");
        private By currentPassword = By.CssSelector("#pwd");
        private By emailAddress = By.CssSelector("#email");
        private By generatePassword = By.CssSelector("#your-profile > div.user-pass1-wrap > button");
        private By newPassword = By.CssSelector("#pass1");
       // private By saveButton = By.CssSelector("#user-activity");
        private By eyeIcon = By.CssSelector("#div > button.button.wp-hide-pw > span.dashicons.dashicons-visibility");



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
        public void ClickSettingCogIcon()
        {
            driver.FindElement(settingCogIcon).Click();
        }


        public void ClickSettingPage()
        {
            driver.FindElement(settingPage).Click();
        }


        public void EnterCurrentPassword(string pwd)
        {
            driver.FindElement(currentPassword).SendKeys(pwd);
        }


        public void EnterEmailAddress(string email)
        {
            driver.FindElement(emailAddress).SendKeys(email);
        }


        public void GeneratePassword(string pwd)
        {
            driver.FindElement(generatePassword).SendKeys(pwd);
        }


        public void EnterNewPassword(string pwd)
        {
            driver.FindElement(newPassword).SendKeys(pwd);
        }


        //public void ClickSaveButton()
        //{
        //    driver.FindElement(saveButton).Click();
        //}


        public void ClickEyeIcon()
        {
            driver.FindElement(eyeIcon).Click();
        }




        public bool EyeIconButtonIsEnabled()
        {
            return driver.FindElement(eyeIcon).Enabled;
        }


    }



}



