using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoERP.MVC.Areas.Register.Models
{
    /// <summary>
    /// Model klasa koja predstavlja sliku.
    /// </summary>
    public class PictureViewModel
    {
        public int PicId { get; set; }
        public string PicName { get; set; }
        public string PicUrl { get; set; }
        public bool Status { get; set; }
    }
}