using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarListed = "Arabalar listelendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserNameInvalid = "Müşteri ismi geçersiz.";
        public static string UserPassword = "Şifre geçersiz.";



        public static string RentalAdded = "Aracınız başarıyla kiralandı.";
        public static string RentalListed = "Araçlar listelendi";
        public static string RentalUpdated = "Kiralama işleminiz başarıyla güncellendi.";
        public static string RentalDeleted = "Kiralama işleminiz başarıyla silindi.";
        public static string RentalNotAvailable = "Seçilen tarihler arasında araç kiralanamaz.";
        public static string RentalUnDelivered = "Araba henüz teslim edilmedi.";
    }
}
