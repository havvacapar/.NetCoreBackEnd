using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message):base(false,message) //default : False.. ve string değer döndürür..(message)
        {

        }

        public ErrorResult() : base(false) //default durumu : False
        {
        }
    }
}
