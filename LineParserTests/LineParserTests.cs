using Microsoft.VisualStudio.TestTools.UnitTesting;
using LineParserClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineParserClass.Tests
{
    [TestClass()]
    public class LineParserTests
    {
        [TestMethod()]
        public void LimitCharactersTest()
        {
            //Arrange
            var testObject = new LineParser();
            string expectedResult = "Word Word";
            string testData = "Word Word";
            string actualResult;
            //Act

            actualResult = testObject.LimitCharacters(testData, 4);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}