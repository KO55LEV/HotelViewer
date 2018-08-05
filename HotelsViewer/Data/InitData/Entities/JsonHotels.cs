using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsViewer.Data.InitData.Entities
{
    public class JsonHotelSurroundings
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
    }
    public class JsonHotel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string OriginalUrl { get; set; }
        public string Address { get; set; }
        public string Descrip { get; set; }
        public List<string> Images { get; set; }
        public List<string> Facilities { get; set; }
        public List<JsonHotelSurroundings> Surroundings { get; set; }
    }
}
