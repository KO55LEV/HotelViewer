using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsViewer.Data.Entities
{
    public class HotelSurrounding
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
    }
}
