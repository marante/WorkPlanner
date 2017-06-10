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
            Mapper.CreateMap<WorkOrder, WorkOrderDto>();
            Mapper.CreateMap<WorkOrderDto, WorkOrder>();
        }
    }
}