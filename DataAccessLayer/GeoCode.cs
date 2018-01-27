using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleDAL.Model;
using System.Net;
using Newtonsoft.Json.Linq;
using Microsoft.Practices.Unity;
using System.Configuration;

namespace GoogleDAL
{
    public class GeoCode : IGeoCode
    {
        public async Task<JObject> GetGeoCode(string address, string apiKey)
        {
            // Location location;
            WebClient client = new WebClient();
            client.Proxy = new WebProxy("wsproxy.alfa.bank.int", 3128);
            string _url = client.DownloadString(string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}", address, apiKey));
            JObject response = JObject.Parse(_url);
            var location = response["results"][0]["geometry"]["location"] as JObject;
            return location;
        }
    }
}
