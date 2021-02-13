using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {//Result a Constructor vasıtasıyla bir tane bool bir tane string bir şey göndermek istiyorsun 
        
        public Result(bool success, string message):this(success)
        {//:this(success)  Result classınınn tek parametreli constructorı da çalışsın demek(İKİ PARAMETRELİ GÖNDERİM İÇİN)
            //Success ve Message Metotlarını contructor ile set ediliyor
            //set; olmamasının sebabi başka bir yazılımda success ve message değeri veremesin diye
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
