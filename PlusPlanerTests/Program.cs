using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusPlanerTests
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to Webpage
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.plusplaner.com/");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void BothEmpty()
        {
            //Submit
            SeleniumSetMethods.Click("action", PropertyType.Name);
            Console.WriteLine("Submitted");
        }

        [Test]
        public void UsernameOnly()
        {

            //Username
            SeleniumSetMethods.EnterText("Username", "user21", PropertyType.Name);
            Console.WriteLine("Username inputted");

            //Submit
            SeleniumSetMethods.Click("action", PropertyType.Name);
            Console.WriteLine("Submitted");
        }

        [Test]
        public void PasswordOnly()
        {

            //Password
            SeleniumSetMethods.EnterText("Password", "Pass21", PropertyType.Name);
            Console.WriteLine("Password inputted");

            //Submit
            SeleniumSetMethods.Click("action", PropertyType.Name);
            Console.WriteLine("Submitted");
        }

        

        [Test]
        public void UsernameAndPassword()
        {

            //Username
            SeleniumSetMethods.EnterText("Username", "user21", PropertyType.Name);
            Console.WriteLine("Username inputted");

            //Password
            SeleniumSetMethods.EnterText("Password", "Pass21", PropertyType.Name);
            Console.WriteLine("Password inputted");

            //Submit
            SeleniumSetMethods.Click("action", PropertyType.Name);
            Console.WriteLine("Submitted");
        }

        [Test]
        public void IncorrectUsernameOrPassword()
        {

            //Username
            SeleniumSetMethods.EnterText("Username", "user212", PropertyType.Name);
            Console.WriteLine("Username inputted");

            //Password
            SeleniumSetMethods.EnterText("Password", "Pass212", PropertyType.Name);
            Console.WriteLine("Password inputted");

            //Submit
            SeleniumSetMethods.Click("action", PropertyType.Name);
            Console.WriteLine("Submitted");
        }

        [TearDown]
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed Browser");
        }


    }
}

