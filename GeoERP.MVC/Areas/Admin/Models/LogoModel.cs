using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeoERP.MVC.Areas.Admin.Models
{
    /// <summary>
    /// POCO klasa koja predstavlja entitet Logo iz baze podataka.
    /// </summary>
    public class LogoModel
    {
        public int Id { get; set; }

        public int ProfileModelId { get; set; }

        /// <summary>
        /// Sadrzi server-side validaciju.
        /// </summary>
        [Required, StringLength(1024), DataType(DataType.ImageUrl), DisplayName("URL slike visoke rezolucije")]
        public string HighImageUrl { get; set; }

        [Required, StringLength(1024), DataType(DataType.ImageUrl), DisplayName("URL slike niske rezolucije")]
        public string LowImageUrl { get; set; }

        public ProfileModel ProfileModel { get; set; }


    }
}