using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelsViewer.Data.Entities;

namespace HotelsViewer.Data
{
    public class HotelsViewerDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
    }
}
