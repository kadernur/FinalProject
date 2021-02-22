using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //mesaj içersin,işlem sonucu içersin aynı 
    //zamanda data da içersin
    
  public   interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
