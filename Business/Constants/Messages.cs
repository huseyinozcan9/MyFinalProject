using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintanenceTime = "Bakım zamanı daha sonra tekrar deneyiniz";
        public static string ProductList = "Ürünler listelendi ";
        public static string ProductCountOfCategoryError = "Ürün limiti aşıldı";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün mevcut ";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserNotFound="Kullanıcı bulunamadı";
        internal static string UserRegistered="Kullanıcı kaydedildi";
        internal static string PasswordError="Parolo hatalı";
        internal static string SuccessfulLogin="Giriş başarılı";
        internal static string UserAlreadyExists="Kullanıcı zaten kayıtlı";
        internal static string AccessTokenCreated="Token oluşturuldu";
    }
}
