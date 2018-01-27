using GoogleMapService.GoogleBL.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapService.GoogleBL
{
   public interface IGetGeoCodeService
    {
        Task<JObject> GetGeoLocations(string address, string apiKey);
    }
}
