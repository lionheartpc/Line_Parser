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
        public void LimitCharactersTest_givenEmptyContent_expectEmptyString()
        {
            //Arrange

            var testObject = new LineParser();
            string expectedResult = "";
            string testData = "";
            string actualResult;

            //Act

            actualResult = testObject.LimitCharacters(testData, 4);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void LimitCharactersTest_givenWord_expectWordString()
        {
            //Arrange

            var testObject = new LineParser();
            string expectedResult = "Word";
            string testData = "Word";
            string actualResult;

            //Act

            actualResult = testObject.LimitCharacters(testData, 6);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void LimitCharactersTest_givenWords_expectWordsFormatted()
        {
            //Arrange

            var testObject = new LineParser();
            string expectedResult = "Word Word\r\nTesting\r\nWord";
            string testData = "Word Word Testing Word";
            string actualResult;

            //Act

            actualResult = testObject.LimitCharacters(testData, 10);

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }

 
    }
}