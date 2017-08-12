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
        readonly private SingleTracksAPI _allUsaPlaces;
        public PlaceService(IOptions<SingleTracksAPI> optionsAccessor)
        {
            _allUsaPlaces = optionsAccessor.Value;
        }

        public async Task<object> GetTopDestinations()
        {
            var TopPlacesUrl = _allUsaPlaces;
            HttpWebRequest query = (HttpWebRequest)WebRequest.Create(TopPlacesUrl.ToString());
            WebResponse response = await query.GetResponseAsync();
            var raw = String.Empty;
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 1024, true))
            {
                raw = reader.ReadToEnd();
            }
            var allresults = JsonConvert.DeserializeObject<PlaceModel.RootObject>(raw);

            return allresults.places.OrderBy(o => o.activities.Select(s => s.rank));

            //Task<HttpResponse<MyClass>> response = Unirest.get("https://trailapi-trailapi.p.mashape.com/?q[country_cont]=United+States")
            //.header("X-Mashape-Key", "yBf3jtD85Jmshy4ot1trl6UGG49rp1qXRdsjsnwlIG9upX5cYd")
            //.header("Accept", "text/plain")
            //.asString();
        }
    }
}
