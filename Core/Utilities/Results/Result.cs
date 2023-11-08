using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message; //hem bool hem de string ifadeleri istedik  
        }
        public Result(bool success)
        { 
            Success = success; //sadece bool ifadeyi istedik
            
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
