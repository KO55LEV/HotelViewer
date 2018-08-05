using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelsViewer.Data.Entities;
using HotelsViewer.Data.InitData.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace HotelsViewer.Data
{
    public class Seeder
    {
        private readonly HotelsViewerDbContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly IMapper _mapper;
        
        public Seeder(HotelsViewerDbContext ctx, IHostingEnvironment hosting, IMapper mapper)
        {
            _ctx = ctx;
            _hosting = hosting;
            _mapper = mapper;
        }

        public void Seed()
        {
            //ensure database is created
            _ctx.Database.EnsureCreated();

            //check if any data exists. 
            if (!_ctx.Hotels.Any())
            {
                //create sample data 
                var directoryJsonSeedPath = Path.Combine(_hosting.ContentRootPath, "Data/InitData/Hotels");

                if (Directory.Exists(directoryJsonSeedPath))
                {
                    DirectoryInfo jsonDir = new DirectoryInfo(directoryJsonSeedPath);
                    FileInfo[] jsonFiles = jsonDir.GetFiles("*.json"); //Getting all json files
                    foreach (FileInfo file in jsonFiles)
                    {
                        var jsonHotel = File.ReadAllText(file.FullName);
                        var hotelObj = JsonConvert.DeserializeObject<JsonHotel>(jsonHotel);

                        //use mapper to map this dynamic object to data objects 
                        Hotel newHotel = _mapper.Map<Hotel>(hotelObj);

                        //if we need to add few hotels use AddRange. 
                        //_ctx.Hotels.AddRange(hotels);
                        _ctx.Hotels.Add(newHotel);
                        _ctx.SaveChanges();
                        

                    }

                    
                    
                }

            }

        }


    }
}
