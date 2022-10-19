using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Constant
{
    public static class Messages
    {
        public static string Added="Eklnedi";
        public static string Deleted="Silindi";
        public static string Listed="Listelendi";
        public static string Updated="Güncellendi";
        public static string AuthorizationDenied = "Erişim Engellendi";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string SuccessMessages = "Mesaj Başarılı";
        public static string UserAlreadyExists = "kullanıcı zaten var";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string ProductUpdated = "Ürün güncellendi";
    }
}
