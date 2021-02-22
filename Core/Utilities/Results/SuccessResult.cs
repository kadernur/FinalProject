using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //true burda verip mesaj verdim sadecde manager kısmında.
        //default true vermiş oldum.
        public SuccessResult(string message):base(true,message)
        {

        }

        //mesaj vermedim
        public SuccessResult():base(true)
        {

        }
    }
}
