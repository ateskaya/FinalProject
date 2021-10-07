using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed ="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 20 ürün olabilir.";
        public static string ProductUpdated="Ürün güncellendi.";
        public static string ProductNameAlreadyExists="Bu isimde bir ürün vardır.";
        public static string CategoryLimitExceded="Kategori limiti 15 olduğu için ürün ekleyemezsiniz.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kayıtlı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string PasswordError = "Şifre hatalı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Access token oluşturuldu";
    }
}
