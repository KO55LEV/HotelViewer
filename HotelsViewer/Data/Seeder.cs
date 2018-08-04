using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HotelsViewer.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace HotelsViewer.Data
{
    public class Seeder
    {
        public readonly HotelsViewerDbContext _ctx;
        public readonly IHostingEnvironment _hosting;
        public Seeder(HotelsViewerDbContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }
        public void Seed()
        {
            //ensure database is created
            _ctx.Database.EnsureCreated();

            //check if any data exists. 
            if (!_ctx.Hotels.Any())
            {
                //create sample data 
                var filePath = Path.Combine(_hosting.ContentRootPath, "Data/InitData/Hotels.json");
                var json = File.ReadAllText(filePath);
                var hotels = JsonConvert.DeserializeObject<IEnumerable<Hotel>>(json);
                _ctx.Hotels.AddRange(hotels);
                _ctx.SaveChanges();

            }

        }


    }
}
