
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks; //Sleep


namespace SeleniumFirst
{
    /// <summary>
    /// Test not working for some reason? check
    /// 
    /// edit : NUnit test adapter
    /// </summary>

    class Program
    {
        //create a reference for the browser
       


        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to Webpage
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        //[Test]
        //public void Test_1() //Google landing page
        //{
        //    //locate element
        //    IWebElement element = PropertiesCollection.driver.FindElement(By.Name("q"));

        //    //perform operations
        //    element.SendKeys("hello world");
        //    Console.WriteLine("Executed Test");
        //}

        [Test]
        public void Test_2()
        {
            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "namename", PropertyType.Name);

            Console.WriteLine("Title value is: " + SeleniumGetMethods.GetTextFromDDL("TitleId",PropertyType.Id));
            Console.WriteLine("Initial value is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //First name
            SeleniumSetMethods.EnterText("FirstName", "John", PropertyType.Name);

            //Middle name
            SeleniumSetMethods.EnterText("MiddleName", "Smith", PropertyType.Name);

            //Gender
            SeleniumSetMethods.Click("Male", PropertyType.Name);

            //Languages known
            SeleniumSetMethods.Click("english", PropertyType.Name); //unchecks
            SeleniumSetMethods.Click("Hindi", PropertyType.Name);


            //Save
            SeleniumSetMethods.Click("Save", PropertyType.Name);

            Thread.Sleep(2000); //pause


        }

        [TearDown]
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
