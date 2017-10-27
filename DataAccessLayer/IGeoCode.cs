using DataAccessLayer.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IGeoCode
    {
        Task<JObject> GetGeoCode(string address, string apiKey);
    }
}
