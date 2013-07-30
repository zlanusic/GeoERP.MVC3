using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GeoERP.MVC.Areas.Register.Models
{
    /// <summary>
    /// Model klasa koja predstavlja korisnika.
    /// Trebali bi na svaki property dodati i anotacije koje 
    /// se koriste za validaciju i prikaz!
    /// </summary>
    public class RegisterCompanyViewModel
    {
        /// <summary>
        /// Identifikacija korisnika. 
        /// </summary>
        [DisplayName("Identifikacijski broj")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Ime tvrtke korisnika.
        /// Anotacija je za samo za primjer!!
        /// </summary>
        [DisplayName("Naziv tvrtke: ")]
        //[Required(ErrorMessage = "Naziv tvrtke je obavezan")]
        public string FullName { get; set; }
        
        [DisplayName("Skraćeni naziv tvrtke: ")]
        public string ShortName { get; set; }

        /// <summary>
        /// Mjesto i adresa tvrtke.
        /// </summary>
        [DisplayName("Mjesto: ")]
        public string CityName { get; set; }
        [DisplayName("Adresa: ")]
        public string Address { get; set; }
        
        /// <summary>
        /// Podaci tvrtke.
        /// </summary>
        [DisplayName("Direktor: ")]
        public string Director { get; set; }
        [DisplayName("Izaberite banku: ")]
        public BankViewModel BankViewModel { get; set; }
        [DisplayName("OIB: ")]
        public int Oib { get; set; }
        [DisplayName("PDV broj: ")]
        public int PdvNum { get; set; }
        [DisplayName("Matični broj(MB): ")]
        public int PersonalNumber { get; set; } // --MB

        /// <summary>
        /// Kontakt tvrtke.
        /// </summary>
        [DisplayName("Telefon: ")]
        public int Phone { get; set; }
        [DisplayName("Mobitel: ")]
        public int Mobile { get; set; }
        [DisplayName("Fax: ")]
        public int Fax { get; set; }

        /// <summary>
        /// Web site tvrtke.
        /// </summary>
        [DisplayName("Web stranica tvrtke: ")]
        public string WebPath { get; set; }

        /// <summary>
        /// Korisnikov email.
        /// </summary>
        [DisplayName("Email 1: ")]
        public string Email1 { get; set; }
        [DisplayName("Email 2: ")]
        public string Email2 { get; set; }
        [DisplayName("Email 3:")]
        public string Email3 { get; set; }

        /// <summary>
        /// Logo tvrtke.
        /// </summary>
        [DisplayName("Logo tvrtke: ")]
        public PictureViewModel PictureViewModel { get; set; }
        
        /// <summary>
        /// Korisnicko ime i lozinka.
        /// </summary>
        [DisplayName("Korsničko ime: ")]
        //[Required (ErrorMessage = "Korisničko ime je obavezno!")]
        public string UserName { get; set; }
        [DisplayName("Lozinka: ")]
        //[Required(ErrorMessage = "Lozinka je obavezna!")]
        public string UserPwd { get; set; }
    }
}