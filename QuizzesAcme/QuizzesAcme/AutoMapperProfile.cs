using AutoMapper;
using QuizzesAcme.Dtos.Quiz;
using QuizzesAcme.Models;

namespace QuizzesAcme
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile() 
        {
            CreateMap<Quiz,GetQuizDto>();
            CreateMap<AddQuizDto,Quiz>();
            CreateMap<UpdateQuizDto,Quiz>();
        }
    }
}
