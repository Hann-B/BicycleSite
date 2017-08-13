using BikeSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeSite.ViewModels
{
    public class ListOfDestinationsViewModel
    {

        public IEnumerable<PlaceModel.RootObject> Places { get; set; }
    }
}
