using NUnit.Framework;
using NUnitFrameworkFromScratch.pageObjects;
using NUnitFrameworkFromScratch.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NUnitFrameworkFromScratch
{
    public class rahulShettyAcademy : baseClass
    {
        HomePage homepage;


        [Test]
        public void urlLaunchFromJson()
        {
            driver.Url = getDataParser().extractData("amazonurl");
            Thread.Sleep(10000);
        }

        [Test]
        public void clickingOnMoreButton() {
            homepage = new HomePage(driver);
            driver.Url = getDataParser().extractData("amazonurl");

            homepage.moreDropDown.Click();
            Thread.Sleep(6000);



        }


    }
}
