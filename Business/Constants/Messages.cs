using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Temel mesajlarımız
        public static string ProductAdded = "ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Category limiti aşıldı. Yeni ürün eklenmiyor.";
    }
}