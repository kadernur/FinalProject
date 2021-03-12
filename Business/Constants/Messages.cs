using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied="Yetkiniz yok.";
        public  static string UserRegistered="Kayıt oldu.";
        public  static string UserNotFound="Kullanıcı bulunamadı.";
        public  static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public  static string UserAlreadyExists="Kullanıcı mevcut.";
        public  static string AccessTokenCreated="Token oluşturuldu.";
    }
}