﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //logics[param1,param2,...] 
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; //kurala uymayanı döndür
                }
            }return null;     
        }   
    }
}
