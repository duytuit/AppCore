﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.AutoMapper
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            //CreateMap<Post, PostResponse>()
            //  .ForMember(dest => dest.Tags, opt =>
            //      opt.MapFrom(src => src.Tags.Select(x => new TagResponse { Name = x.TagName })));

            //CreateMap<Tag, TagResponse>();
        }
    }
}
