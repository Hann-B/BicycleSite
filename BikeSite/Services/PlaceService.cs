using BikeSite.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BikeSite.Services
{
    public class PlaceService:IPlaceService
    {
        readonly private SingleTracksAPI _singleTracksApi;
        public PlaceService(IOptions<SingleTracksAPI> optionsAccessor)
        {
            _singleTracksApi = optionsAccessor.Value;
        }

        public async Task<PlaceModel.RootObject> GetTopDestinations()
        {
            var singleTracksApi = _singleTracksApi;

            var request = (HttpWebRequest)WebRequest.Create(singleTracksApi.AllUsaPlaces.ToString());
            request.Accept = "application/json";
            request.Headers["X-Mashape-Key"] = singleTracksApi.X_Mashape_Key.ToString();

            WebResponse response = await request.GetResponseAsync();

            var raw = String.Empty;
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 1024, true))
            {
                raw = reader.ReadToEnd();
            }
            var allresults = JsonConvert.DeserializeObject<PlaceModel.RootObject>(raw);
  
            return allresults;

            //Task<HttpResponse<MyClass>> response = Unirest.get("https://trailapi-trailapi.p.mashape.com/?q[country_cont]=United+States")
            //.header("X-Mashape-Key", "yBf3jtD85Jmshy4ot1trl6UGG49rp1qXRdsjsnwlIG9upX5cYd")
            //.header("Accept", "text/plain")
            //.asString();
        }
    }
}
