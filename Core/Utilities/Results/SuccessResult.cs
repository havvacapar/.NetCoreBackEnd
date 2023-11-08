using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult (string message) : base(true, message) //default u true olan sonuç.. string bir sonuç istiyor..
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
