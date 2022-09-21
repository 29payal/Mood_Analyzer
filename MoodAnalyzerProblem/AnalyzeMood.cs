using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)
        {
            this.message = message; 
        }

        public string Mood()
        {
            try
            {
                message=message.ToLower();
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }

            //catch block will catch the exception 
            catch(NullReferenceException e)
            {
                //print the default exception message
                Console.WriteLine(e);
                return "happy";
            }
        }
    }
}
