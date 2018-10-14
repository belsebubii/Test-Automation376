using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        private RemoteWebDriver _driver;

        public LoginPageObject(RemoteWebDriver driver) => _driver = driver;


        IWebElement txtUserName => _driver.FindElementByName("UserName");
        IWebElement txtPassword => _driver.FindElementByName("Password");
        IWebElement btnLogin => _driver.FindElementByName("Login");

        /// ///classic way of initializing Pages using POM - up until Selenium 3.10

        //public LoginPageObject()
        //{
        //    PageFactory.InitElements(PropertiesCollection.driver, this);
        //}

        //[FindsBy(How = How.Name, Using = "UserName")]
        //public IWebElement txtUserName { get; set; }

        //[FindsBy(How = How.Name, Using = "Password")]
        //public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Name, Using = "Login")]
        //public IWebElement btnLogin { get; set; }


        public EAPageObject Login(string userName, string password)
        {
            //Login
            txtUserName.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //click button
            btnLogin.Click();

            //return the page object
            return new EAPageObject();
        }



    }
}
