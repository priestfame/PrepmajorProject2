using NUnit.Framework;
using OpenQA.Selenium;
using PrepmajorProject2.Hooks;
using PrepmajorProject2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepmajorProject2.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver driver = BaseTest.driver;
        LoginPage loginPage = new LoginPage();

        [Given(@"a user navigates to EAC Prepmajor website")]
        public void GivenAUserNavigatesToEACPrepmajorwebsite()
        {
            driver.Navigate().GoToUrl(@"https://eac.prepmajor.com/user-account/");
        }
        
        [When(@"a user clicks login on the menu")]
        public void WhenAUserClicksLoginOnTheMenu()
        {
            loginPage.Login();
        }
        
        [When(@"a user enters a username ""(.*)""")]
        public void WhenAUserEntersAUsername(string nametxt)
        {
            loginPage.Username(nametxt);
        }
        
        [When(@"a user enters password ""(.*)""")]
        public void WhenAUserEntersPassword(string passtxt)
        {
            loginPage.Password(passtxt);
        }
        
        [When(@"a user clicks login button")]
        public void WhenAUserClicksLoginButton()
        {
            loginPage.LoginButton();
        }

        [Then(@"a user is logged in and logo is correctly displayed on the page")]
        public void ThenAUserIsLoggedInAndLogoIsCorrectlyDisplayedOnThePage()
        {
            Assert.IsTrue(loginPage.LogoIsDisplayed());
        }

      












    }
}
