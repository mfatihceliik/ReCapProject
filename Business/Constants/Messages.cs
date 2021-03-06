using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi !";
        public static string MaintenanceTime = "Bakım zamanında işlem yapılamaz !";
        public static string GetAllCars = "Tüm araçlar listelendi.";
        public static string GetCarDetails = "Araç bilgileri getirildi.";
        public static string GetCarsByBrand = "Markaya göre sıralama yapıldı.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarImageLimitExceeded = "Araca eklenebilecek maksimum resim sayısına ulaşıldı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatası";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kayıt oldu";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
