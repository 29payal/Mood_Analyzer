using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class AnalyzeMood
    {
        //method to analyze mood
        public string Mood(string message)
        {
            //convert the message to lower case and then check it contains happy or sad
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
