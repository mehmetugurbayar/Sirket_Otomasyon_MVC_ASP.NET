using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.Models
{
    public class Musteri
    {
        public int musteriId { get; set; }
        [Display(Name = "Müşteri Adı")] //bu modelimiz html de görüneni değiştirdik
        [Required(ErrorMessage ="Müşteri adı boş olamaz!")] //Boş değer null girilmez //mesaj özelleştirildi
        public string musteriAd { get; set; }

        [Display(Name = "Müşteri Soyadı")]
        [Required(ErrorMessage = "Müşteri Soyadı boş olamaz!")]
        public string musteriSoyad { get; set; }

        [Display(Name = "Müşteri Adres")]
        [Required(ErrorMessage = "Müşteri telefonu boş olamaz!")]
        public string musteriTel{ get; set; }
        [Display(Name = "Müşteri Telefon")]
        [Required(ErrorMessage = "Müşteri adresi boş olamaz!")]
        public string musteriAdres { get; set; }
    }
}