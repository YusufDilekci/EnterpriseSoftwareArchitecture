using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //public olan variablelar PascalCase prensibine göre yazılır.

        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakım sürecindedir.";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Her kategoriye ait ürün sayısı 10 'u geçmemeli.";
        public static string SameProductNameError = "Aynı ürün adında bir ürün zaten mevcut";
        public static string CategoryCountExceed = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Başarılı bir şekilde kaydoldunuz.";
        public static string UserNotFound = "Kullanıcı bilgileriniz geçerli değildir";
        public static string PasswordError = "Kullanıcı adı veya şifre yanlış";
        public static string SuccessfulLogin = "Başarılı bir şekilde giriş yapıldı.";
        public static string UserAlreadyExists = "Bu emaile sahip kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Bir token oluşturuldu.";
    }
}
