using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.Models
{
    public class Admin
    {
        public int adminId { get; set; }

        [Display(Name = "Kullanıcı adı")] //bu modelimiz html de görüneni değiştirdik
        [Required(ErrorMessage = "Kullanıcı alanı boş olamaz!")] //Boş değer null girilmez //mesaj özelleştirildi
        public string adminKulAd { get; set; }

        [Display(Name = "Kullanıcı Şifre")] //bu modelimiz html de görüneni değiştirdik
        [Required(ErrorMessage = "Kullanıcı şifre alanı boş olamaz!")] //Boş değer null girilmez //mesaj özelleştirildi
        public string adminKulSif { get; set; }
    }
}