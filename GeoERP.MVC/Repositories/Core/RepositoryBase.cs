using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

using GeoERP.MVC.ServiceGeoCloud;

namespace GeoERP.MVC.Repositories.Core
{
    /// <summary>
    /// Bazna klasa za sve repozitorije.
    /// Sadrzi uobicajene funkcionalnosti za repo:
    ///     -održava service klijenta
    ///     -provjerava uobičajene request-response veze
    /// </summary>
    public abstract class RepositoryBase
    {
        protected ServiceGeoCloudClient Client
        {
            get
            {
                // --Provjeri ako servis nije inicijaliziran
                if (HttpContext.Current.Session["ServiceGeoCloudClient"] == null)
                {
                    HttpContext.Current.Session["ServiceGeoCloudClient"] = new ServiceGeoCloudClient();
                }

                    // --Ako je trenutni klijent u greski(bilo koja greska), stvori novu instancu servisa.
                    var client = HttpContext.Current.Session["ServiceGeoCloudClient"] as ServiceGeoCloudClient;

                    if (client.State == CommunicationState.Faulted)
                    {
                        try
                        {
                            client.Abort();
                        }
                        catch (Exception)
                        {
                            
                            throw;
                            // --nema implementacije
                        }


                        client = new ServiceGeoCloudClient();
                        HttpContext.Current.Session["ServiceGeoCloudClient"] = client;

                    }

                return client;
            }
        }

        /// <summary>
        /// WCF servis bi trebao sadrzavati RequestBase i ResponseBase klase koje su bazne 
        /// za sve ostale sadrze request-e i response-e u WCF servisu, te sadrze
        /// RequestId i CorrelationId properties za svaki view i svako polje koje se nalazi na 
        /// view-u.
        /// RequestId i CorrelationId uvijek moraju odgovarati jedan drugome, a ako ne tada nisu u uzajmnoj vezi .
        /// </summary>
        protected void Correlation(string request, string response)
        {
            // --implementacija iznimke koja je bacena ukoliko request i response nisu u korelaciji   
        }
    }
}