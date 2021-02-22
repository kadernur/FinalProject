using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        //iki parametre gönderen birisi için 
        //this aynı zamanda bu classın tek parametreli olanı çalıştır demek.
        //constructor'un base ile çalışması örneği.

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }

        //overloading sadece başarılı olup olmadığımı 
        //döndürmek istediğim durumlarda kullanırım.
        //mesaj dödürmek istemediğim anlarda.

        public Result(bool success)
        {
           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }


    }
}
