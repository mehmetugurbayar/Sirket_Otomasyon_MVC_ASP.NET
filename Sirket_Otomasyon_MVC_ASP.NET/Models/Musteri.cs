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
        [Required] //Boş değer null girilmez
        public string musteriAd { get; set; }

        [Display(Name = "Müşteri Soyadı")]
        [Required]
        public string musteriSoyad { get; set; }
    }
}