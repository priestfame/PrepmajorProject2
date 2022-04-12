using NUnit.Framework;
using OpenQA.Selenium;
using PrepmajorProject;
using PrepmajorProject.PageObjects;
using PrepmajorProject2.Hooks;
using System;
using TechTalk.SpecFlow;

namespace PrepmajorProject.Features
{
    [Binding]
    public class EyeIconSteps
    {

        public IWebDriver driver = BaseTest.driver;

        EyeIconPage _eyeIconPage = new EyeIconPage();



        [Given(@"a user navigates to EAC Prepmajor member website")]
        public void GivenAUserNavigatesToEACPrepmajorMemberWebsite()
        {
            driver.Navigate().GoToUrl(@"https://eac.prepmajor.com/members/priestfame/");
        }

        [When(@"a user clicks log in on the menu")]
        public void WhenAUserClicksLogInOnTheMenu()
        {
            _eyeIconPage.Login();
        }

        [When(@"a user enters username ""(.*)""")]
        public void WhenAUserEntersUsername(string nametxt)
        {
            _eyeIconPage.Username(nametxt);
        }

        [When(@"a user enters a password ""(.*)""")]
        public void WhenAUserEntersAPassword(string passtxt)
        {
            _eyeIconPage.Password(passtxt);
        }

        [When(@"a user click login button")]
        public void WhenAUserClickLoginButton()
        {
            _eyeIconPage.LoginButton();
        }


        [When(@"a user click on the setting cog icon")]
        public void WhenAUserClickOnTheSettingCogIcon()
        {
            _eyeIconPage.ClickSettingCogIcon();
        }

        [When(@"a user click on the setting page")]
        public void WhenAUserClickOnTheSettingPage()
        {
            _eyeIconPage.ClickSettingPage();
        }

        [When(@"a user enter current password""(.*)""")]
        public void WhenAUserEnterCurrentPassword(string pwd)
        {
            _eyeIconPage.EnterCurrentPassword(pwd);
        }

        [When(@"a user enter email ""(.*)""")]
        public void WhenAUserEnterEmail(string email)
        {
            _eyeIconPage.EnterEmailAddress(email);
        }

        [When(@"a user click on generate password")]
        public void WhenAUserClickOnGeneratePassword(string pwd)
        {
            _eyeIconPage.GeneratePassword(pwd);
        }

        [When(@"a user enter new password ""(.*)""")]
        public void WhenAUserEnterNewPassword(string pwd)
        {
            _eyeIconPage.EnterNewPassword(pwd);
        }

        [When(@"a user click on the eye icon")]
        public void WhenAUserClickOnTheEyeIcon()
        {
            _eyeIconPage.ClickEyeIcon();
        }

        [Then(@"the eyeicon button is enabled")]
        public void ThenTheEyeIconButtonIsEnabled()
        {
            Assert.IsTrue(_eyeIconPage.EyeIconButtonIsEnabled());
        }













    }
}