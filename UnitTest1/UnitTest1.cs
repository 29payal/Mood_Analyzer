using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void GivenMsgReturnHappyOrSad()
        {
            //UC1- given the return message the mood is happy or sad
            AnalyzeMood analyzeMood = new AnalyzeMood();
            string message = "I am in happy mood";
            string expected = "happy";
            var actual = analyzeMood.Mood(message);
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void GivenMsgReturnSad()
        {
            //TC1.1- given the return message sad
            AnalyzeMood analysisMood = new AnalyzeMood();
            string message = "I am in Sad Mood";
            string expected = "sad";
            var actual = analysisMood.Mood(message);
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);
        }
    }
}