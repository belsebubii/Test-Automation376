using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    /// <summary>
    /// Prevents from using wrong name- shows a list when called. Strongly typed parameter
    /// </summary>
    enum PropertyType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }
    class PropertiesCollection
    {
        //Auto-implemented property
        public static IWebDriver driver { get; set; }

       
    }
}
