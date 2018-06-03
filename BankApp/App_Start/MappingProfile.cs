using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BankApp.Dtos;
using BankApp.Models;

namespace BankApp.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Manager, ManagerDto>();
            Mapper.CreateMap<Role, RoleDto>();

            // Dto to Domain
            Mapper.CreateMap<ManagerDto, Manager>().ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}