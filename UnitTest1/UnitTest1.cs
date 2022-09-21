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
            //Refactor
            //TC1.1- given the return message sad
            AnalyzeMood analyzeMood = new AnalyzeMood("I am in sad mood ");
            string expected = "sad";
            var actual = analyzeMood.Mood();
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void GivenMsgReturnHappy()
        {
            //TC1.2- given the return message happy
            AnalyzeMood analysisMood = new AnalyzeMood("I am in happy mood");
            string expected = "happy";
            var actual = analysisMood.Mood();
            Assert.AreEqual(expected,actual);
            Console.WriteLine(actual);
        }
    }
}