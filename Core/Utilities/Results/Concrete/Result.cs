using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success) //(this) Tek parametreliyide aynı anda çalıştırmak için
        {
            Message = message;
            
        }

        public Result(bool success)
        { 
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; } //getter readonlydir readonliler consta set edilebilirler.
    }
}
