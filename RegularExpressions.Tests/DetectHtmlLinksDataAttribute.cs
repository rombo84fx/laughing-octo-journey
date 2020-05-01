using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace RegularExpressions.Tests
{
    public class DetectHtmlLinksDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            string[] csvLines = File.ReadAllLines(@"DetectHtmlLinksTestCases\DetectHtmlLinksTestData.csv");

            var testCases = new List<object[]>();

            foreach (string csvLine in csvLines)
            {
                string[] values = csvLine.Split(',');
                object[] testCase = {
                        values[0],
                        $"{values[1]},{values[2]}"
                    };
                testCases.Add(testCase);
            }

            return testCases;
        }
    }
}
