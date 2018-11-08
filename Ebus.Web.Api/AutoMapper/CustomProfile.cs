using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ebus.Web.Api.AutoMapper
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<>();
        }
    }
}
