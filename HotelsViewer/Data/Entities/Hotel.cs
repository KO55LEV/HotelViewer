using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsViewer.Data.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string OriginalUrl { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public bool IsPublished { get; set; }
        public DateTime Created { get; set; }
        public HotelImage Images { get; set; }
        public HotelFacility Facilities { get; set; }
        public HotelSurrounding Surroundings { get; set; }
        
    }
}
