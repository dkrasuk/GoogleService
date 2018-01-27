using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapService.GoogleBL.Model;
using Microsoft.Practices.Unity;
using GoogleDAL;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace GoogleMapService.GoogleBL
{
    public class GeoCodeService : IGetGeoCodeService
    {
        private IGeoCode _geo;


        public GeoCodeService(IGeoCode geo)
        {
            _geo = geo;
        }
        public async Task<JObject> GetGeoLocations(string address, string apiKey)
        {        
            if (address == null)
            {
                throw new ArgumentNullException("Address not specified");
            }
            try
            {
                var response = await _geo.GetGeoCode(address, apiKey);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("Geolocation is not received");
            }          
            
        }
    }
}
