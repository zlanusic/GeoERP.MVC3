using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GeoERP.MVC.ServiceGeoCloud;

namespace GeoERP.MVC.Areas.Admin.Models
{
    /// <summary>
    /// POCO klasa koja predstavlja entitet Tvrtke iz baze podataka.
    /// </summary>
    public class ProfileModel
    {
        ServiceGeoCloud.ServiceGeoCloudClient _serviceGeoCloudClient = new ServiceGeoCloudClient();

        public int Id { get; set; }

        [Required, DisplayName("Puni naziv tvrtke")]
        public string FullName { get; set; }

        public string ShortName { get; set; }
        
        [Required, DisplayName("Mjesto")]
        public string City { get; set; }
        
        [Required, DisplayName("Adresa")]
        public string Address { get; set; }
        
        [Required, DisplayName("Vlasnik tvrtke")]
        public string Owner { get; set; }
        
        [Required, DisplayName("OIB tvrtke")]
        public string OibNum { get; set; }
        
        [Required, DisplayName("PDV broj")]
        public string PdvNum { get; set; }
        
        [Required, DisplayName("Matični broj tvrtke")]
        public string Mb { get; set; }

        public string Phone { get; set; }
        
        public string Mobile { get; set; }
        
        public string Fax { get; set; }

        public string Url { get; set; }
        
        public string Email1 { get; set; }
        
        public string Email2 { get; set; }
        
        public string Email3 { get; set; }
        
        /// <summary>
        /// Sadrži server-side validaciju.
        /// </summary>
        [Required, DisplayName("Korisničko ime")]
        public string UserName { get; set; }
        
        /// <summary>
        /// Sadrži server-side validaciju.
        /// </summary>
        [Required, DataType(DataType.Password), DisplayName("Lozinka")]
        public string Pwd { get; set; }
        
        /// <summary>
        /// Lista slika.
        /// </summary>
        public List<LogoModel> Images { get; set; }

        /// <summary>
        /// Lista banaka.
        /// </summary>
        public List<BankModel> Banks { get; set; }

        public void UpdateProfileModel()
        {
            _serviceGeoCloudClient.Open();
            _serviceGeoCloudClient.UnesiNovuFirmu(null, FullName, ShortName, City, Address, 
                                                  Phone, Mobile, Fax, Email1, Email2, Email3,
                                                  Url, OibNum, Mb, PdvNum, null, null, null, 
                                                  Owner, null, UserName, Pwd, null);
            _serviceGeoCloudClient.Close();
        }
        
    }
}