using AutoMapper;
using DMA;
using Shared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Utility
{
   public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<UserResponse, User>();
        }
    }
}
