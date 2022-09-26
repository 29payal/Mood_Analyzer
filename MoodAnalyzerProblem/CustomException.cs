using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalysisException : Exception
    {
        public ExceptionType type;
        
        //enum(or enumeration type) is used to assgin constant namesw to a group
        //of numeric integer values

        public enum ExceptionType
        {
            //declaring types of exception
            NULL_TYPE_EXCEPTION,
            EMPTY_TYPE_EXCEPTION,
            //class_not_found
            //constructor_not_found
        }

        //creating a constructor which takes exception typews and message
        public ExceptionType Type;
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}