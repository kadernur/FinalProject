using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın 
    //Concrete sınıfındaki classlar veri tablosundaki
    //tablolara karşılık geliyor.
   public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
