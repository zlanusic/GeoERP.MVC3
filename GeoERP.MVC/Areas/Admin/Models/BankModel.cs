using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeoERP.MVC.Areas.Admin.Models
{
    /// <summary>
    /// POCO klasa koja predstavlja entitet Banke iz baze podataka.
    /// </summary>
    public class BankModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Server-side validacija.
        /// </summary>
        [Required, DisplayName("Naziv banke")]
        public string Name { get; set; }

        [Required, DisplayName("IBAN")]
        public int Iban { get; set; }

        [Required, DisplayName("Žiro račun")]
        public int ZiroAccount { get; set; }

    }
}