using System;
using NUnit.Framework;
using NUnitFrameworkFromScratch.Utilities;
using OpenQA.Selenium;

namespace NUnitFrameworkFromScratch
{
    public class Tests : baseClass
    {
       

        [Test]
        [Description("Testcase is related to radio button")]
        public void Test1()
        { 

            //Radio button
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.FindElement(By.Id("radio-btn-example")).Click();


        }

        [Test]
        public void handlingWebTables()
        {
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            IList<IWebElement> productTableRows = driver.FindElements(By.XPath("(//*[@id='product'])[1]//tr"));
            IList<IWebElement> productColumns = driver.FindElements(By.XPath("(//*[@id='product'])[1]//tr[1]/th"));
            TestContext.Progress.WriteLine("number of rows in table is :: " + productTableRows.Count);
            TestContext.Progress.WriteLine("number of columns in table is :: " + productColumns.Count);

            for (int i=1;i<productTableRows.Count;i++)
            {
                for(int j=1;j<productColumns.Count;j++)
                {
                    TestContext.Progress.Write(driver.FindElement(By.XPath("(//*[@id='product'])[1]//tr[" + (i+1)+"]/td["+(j+1)+"]")).Text);
                }
            }

           




        }


    }
}