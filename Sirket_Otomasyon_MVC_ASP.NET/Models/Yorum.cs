using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket_Otomasyon_MVC_ASP.NET.Models
{
    public class Yorum
    {

        public int yorumID{ get; set; }

        [AllowHtml]
        [Display(Name = "Yorum Başlığı")]
        public string yorumBaslik { get; set; }


        [AllowHtml]
        [Display(Name = "Yorum")]
        [Required(ErrorMessage = "Boş yorum gönderemezsiniz")]
        public string yorum{ get; set; }
        
    }
}