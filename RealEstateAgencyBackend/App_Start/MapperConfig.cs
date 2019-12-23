﻿using AutoMapper;
using RealEstateAgencyBackend.BLL.DTO;
using RealEstateAgencyBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateAgencyBackend
{
    public static class MapperConfig
    {
        public static MapperConfiguration CreateConfiguration()
        {
            MapperConfiguration config = new MapperConfiguration(ConfigMapper);
            return config;
        }

        public static void ConfigMapper(IMapperConfigurationExpression config)
        {

            config.CreateMap<RentalAnnouncementDto, RentalAnnouncement>();
            config.CreateMap<RentalAnnouncement, RentalAnnouncementDto>();
            config.CreateMap<RentalAnnouncementCreateModel, RentalAnnouncementDto>();
            config.CreateMap<RentalAnnouncementDto,RentalAnnouncementViewModel>();

            config.CreateMap<RentalRequestDto, RentalRequest>();
            config.CreateMap<RentalRequest, RentalRequestDto>();
            config.CreateMap<RentalRequestCreateViewModel, RentalRequestDto>();
            config.CreateMap<RentalRequestDto, RentalRequestViewModel>();

            config.CreateMap<User, UserDto>();
            config.CreateMap<UserDto, User>();
            config.CreateMap<UserCreateModel, CreateUserDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.UserLastName, opt => opt.MapFrom(src => src.LastName));
            config.CreateMap<UserDto, UserViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.UserLastName));
        }
    }
}