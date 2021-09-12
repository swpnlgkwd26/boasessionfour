using AutoMapper;
using sample_app.Models;
using sample_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.MappingProfile
{
    public class DomainMappingProfile :Profile
    {
        public DomainMappingProfile()
        {
            // logic for Mapping Product=> ProdudtEdit or ProductAdd
          
            CreateMap<Product, ProductAddViewModel>().ReverseMap() ;
            CreateMap<Product, ProductEditViewModel>().ReverseMap();
            CreateMap<RegisterViewModel, ApplicationUser>().
                ForMember(dest=>dest.UserName , opt=> opt.MapFrom(src=>src.Email));

        }
    }
}
