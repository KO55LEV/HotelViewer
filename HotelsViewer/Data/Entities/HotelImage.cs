using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsViewer.Data.Entities
{
    public class HotelImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
