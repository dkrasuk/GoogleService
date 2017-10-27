using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapService.BusinessLayer.Model;
using Microsoft.Practices.Unity;
using AutoMapper;
using DataAccessLayer;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace GoogleMapService.BusinessLayer
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
                return null;
            }
            try
            {
                var response = await _geo.GetGeoCode(address, apiKey);
                return response;
            }
            catch (Exception e)
            {
                return null;
            }          
            
        }
    }
}
