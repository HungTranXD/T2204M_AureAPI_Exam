using AutoMapper;
using DMAWS_T2204M_TranHung.DTOs;
using DMAWS_T2204M_TranHung.Models;

namespace DMAWS_T2204M_TranHung
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<ProjectEmployee, ProjectEmployeeDTO>().ReverseMap();
        }
    }
}
