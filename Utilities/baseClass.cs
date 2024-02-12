using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitFrameworkFromScratch.Utilities
{
    public class baseClass
    {

        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            
            initBrowser("chrome");
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait =  TimeSpan.FromSeconds(5);
        }


        public jsonReader getDataParser()
        {
            return new jsonReader();
        }

        public void initBrowser(string browser)
        {
            switch (browser)
            {
               case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;


                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
            }
        }



        [TearDown]
        public void stopBrowser()
        {

            driver.Quit();
        }



    }
}
