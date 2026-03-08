using RestApiProyect.DTOs;
using RestApiProyect.Models;
using AutoMapper;


namespace RestApiProyect.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Tareas, TaskDto>();
            CreateMap<CreateTaskDto, Tareas>();
            CreateMap<UpdateTaskDto, Tareas>();

        }
    }
}
