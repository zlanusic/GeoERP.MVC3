using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoERP.MVC.Areas.Register.Models
{
    /// <summary>
    /// Model klasa koja predstavlja banku.
    /// </summary>
    public class BankViewModel
    {
        /// <summary>
        /// Podaci za banku.
        /// </summary>
        public string BankName { get; set; }
        public string Iban { get; set; }
        public int Account { get; set; }
    }
}