using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WorkPlanner.Dtos;
using WorkPlanner.Models;

namespace WorkPlanner.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<WorkOrder, WorkOrderDto>();
            Mapper.CreateMap<Status, StatusDto>();

            // Dto to Domain
            Mapper.CreateMap<StatusDto, Status>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<WorkOrderDto, WorkOrder>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}