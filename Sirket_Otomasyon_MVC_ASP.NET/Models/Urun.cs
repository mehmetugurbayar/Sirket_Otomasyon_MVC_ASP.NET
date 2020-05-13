using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.Models
{
    public class Urun
    {
        public int urunId { get; set; }
        [Display(Name = "Ürün Kodu")]
        [Required(ErrorMessage = "Kod alanı boş olamaz!")]
        public string urunKodu { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Ad alanı boş olamaz!")]
        public string urunAd { get; set; }
        [Display(Name = "Stok Miktarı")]
        [Required(ErrorMessage = "Miktar alanı boş olamaz!")]
        public string stokMik{ get; set; }
        [Display(Name = "Ürün Fiyatı")]
        [Required(ErrorMessage = "Fiyat alanı boş olamaz!")]
        public string fiyat{ get; set; }
    }
}