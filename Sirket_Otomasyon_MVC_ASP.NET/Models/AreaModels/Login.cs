using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sirket_Otomasyon_MVC_ASP.NET.Models.AreaModels
{
    public class Login
    {
        [Required(ErrorMessage = "Kullanıcı Adını Girin")]
        [Display(Name = "E-Mail")]
        public string kulAd { get; set; }

        [Required(ErrorMessage = "Şifrenizi girin.")]
        
        [Display(Name = "Şifre")]
        public string kulSif{ get; set; }
    }
}