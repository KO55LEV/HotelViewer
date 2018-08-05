using System;
using System.Collections.Generic;
using AutoMapper;
using HotelsViewer.Core;
using HotelsViewer.Data.Entities;
using HotelsViewer.Data.InitData.Entities;

namespace HotelsViewer.Data
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<string, HotelImage>()
                .ForMember(s => s.Url , c => c.MapFrom(m => m.ToString()))
                .ForMember(s => s.Description, c => c.MapFrom(m => "Image Description"));

            CreateMap<string, HotelFacility>()
                .ForMember(s => s.FacilityName, c => c.MapFrom(m => m.ToString()));

            CreateMap<JsonHotelSurroundings, HotelSurrounding>()
                .ForMember(s => s.Name, c => c.MapFrom(m => m.Name))
                .ForMember(s => s.Category, c => c.MapFrom(m => m.Category))
                .ForMember(s => s.Distance, c => c.MapFrom(m => m.Distance));
            
            CreateMap<JsonHotel, Hotel>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Name, ex => ex.MapFrom(o => o.Name))
                .ForMember(x => x.Town, ex => ex.MapFrom(o => o.Town))
                .ForMember(x => x.OriginalUrl, ex => ex.MapFrom(o => o.OriginalUrl))
                .ForMember(x => x.Address, ex => ex.MapFrom(o => o.Address))
                .ForMember(x => x.Description, ex => ex.MapFrom(o => o.Descrip))
                .ForMember(x => x.Images, ex => ex.MapFrom(o => o.Images))
                .ForMember(x => x.Facilities, ex => ex.MapFrom(o => o.Facilities))
                .ForMember(x => x.Rating, ex => ex.MapFrom(o => Helper.RandomHotelRating()))
                .ForMember(x => x.Price, ex => ex.MapFrom(o => Helper.RandomHotelPrice()))
                .ForMember(x => x.Created, ex => ex.MapFrom(o => DateTime.Now))
                .ForMember(x => x.Surroundings, ex => ex.MapFrom(o => o.Surroundings));
        }

    }
}
