using GoogleMapService.BusinessLayer.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapService.BusinessLayer
{
   public interface IGetGeoCodeService
    {
        Task<JObject> GetGeoLocations(string address, string apiKey);
    }
}
