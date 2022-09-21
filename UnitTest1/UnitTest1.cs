using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMsgReturnSad()
        {
            //UC1
            //TC1.1- given the return message sad

            //Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(message);
            var actual = analyzeMood.Mood();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //TC1.2- given the return message happy

            //Arrange
            string message = "I am in happy mood ";
            string expected = "happy";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(message);
            var actual = analyzeMood.Mood();
            //Assert
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void GivenNullMoodReturnHappy()
        {
            //UC2
            //TC2.1 - given null mood then return happy message
        
            //Arrange
            string message = null; 
            string expected = "happy";
            //Act
            AnalyzeMood analyzeMood = new AnalyzeMood(message);
            var actual = analyzeMood.Mood();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
    }
}