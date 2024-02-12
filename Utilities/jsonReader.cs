using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFrameworkFromScratch.Utilities
{
    public class jsonReader
    {
        public jsonReader() { }


        public string extractData(string tokenName)
        {

            String workingDirectory = Environment.CurrentDirectory;
            TestContext.Progress.Write("Working Directory : "+workingDirectory);

            String projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            TestContext.Progress.Write("project Directory : " + projectDirectory);
            string myJson = File.ReadAllText(projectDirectory+"/Utilities/testdata.json");
            var jObject = JToken.Parse(myJson);
            return jObject.SelectToken(tokenName).Value<string>();

        }

    }
}
