using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSBusiness.Models
{
    public class TemplateViewModel
    {
        [Required]
        public int Delay { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [UIHint("tinymce_jquery_full"), AllowHtml]
        public string Content { get; set; }
    }
}