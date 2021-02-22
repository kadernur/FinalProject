using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel Voidler için başlangıç
   public interface IResult
    {
        //yaptığım işlem başarılı mı başarısız mı onıu test eder.

        bool Success { get; } //sadece okunabilir.

        //yapmaya çalıştığım işlem başarılı ürün eklendi gibi bir mesaj  verecektir.
        string Message { get; }


    }
}
