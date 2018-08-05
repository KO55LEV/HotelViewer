using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsViewer.Core
{
    public static class Helper
    {

        public static int RandomHotelRating()
        {
            Random random = new Random();
            return random.Next(3, 5);
        }

        public static int RandomHotelPrice()
        {
            Random random = new Random();
            return random.Next(50, 150);
        }

    }
}
