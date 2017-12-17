using AutoMapper;
using Ef.Api.Models;
using Ef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ef.Api
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Person, PersonDto>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => string.Format("{0} ({1}) {2}", src.FirstName, src.MiddleName, src.LastName)));
            });
        }
    }
}