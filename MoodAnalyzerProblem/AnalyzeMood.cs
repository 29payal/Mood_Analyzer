using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class AnalyzeMood
    {
        //method to analyse the mood
        public string message;

        //created parameterized constructor
        public AnalyzeMood(string message)
        {
            this.message = message; 
        }

        public string Mood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.Equals(string.Empty))
                {

                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_TYPE_EXCEPTION, "message can't be Empty");

                }

                else
                { 
                    return "sad";
                }
            }
            //catch block will catch the exception 
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Default exception : " +ex.Message);
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_TYPE_EXCEPTION, "message can't be Null");

            }
            
        }
    }
}
