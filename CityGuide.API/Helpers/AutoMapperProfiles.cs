﻿using AutoMapper;
using CityGuide.API.Dtos;
using CityGuide.API.Models;
using System.Linq;

namespace CityGuide.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                 {
                     opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                 });

            CreateMap<City, CityForDetailDto>();
        }
    }
}
