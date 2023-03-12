using AutoMapper;
using QuizzesAcme.Dtos.Quiz;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models;

namespace QuizzesAcme.Services.QuizService
{
    public class QuizService : IQuizService
    {
        private static List<Quiz> listQuiz = new List<Quiz>() 
        {
            new Quiz{
                Id = 1, 
                Description = "Test From Service", 
                Name = "Service Test", 
                Fields = new List<Field>()
                {
                    new Field {Name = "Nombre", Tittle = "Nombre usuario", Required= true, Type = FieldType.Texto},
                    new Field {Name = "Nombre 2", Tittle = "Nombre usuario 2", Required= true, Type = FieldType.Texto}
                }
                 
            }
        };

        private readonly IMapper _mapper;

        public QuizService(IMapper mapper) 
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetQuizDto>> AddQuiz(AddQuizDto newQuiz)
        {
            var serviceResponse = new ServiceResponse<GetQuizDto>();
            listQuiz.Add(_mapper.Map<Quiz>(newQuiz));
            serviceResponse.Data = _mapper.Map<GetQuizDto>(listQuiz.Last());
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetQuizDto>> DeleteQuiz(int id)
        {
            var serviceResponse = new ServiceResponse<GetQuizDto>();

            try
            {
                var quiz = listQuiz.First(q => q.Id == id);

                if (quiz is null)
                    throw new Exception($"Quiz with Id {id} not found");

                listQuiz.Remove(quiz);
                serviceResponse.Data = _mapper.Map<GetQuizDto>(quiz);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetQuizDto>>> GetAllQuizzes()
        {
            var serviceResponse = new ServiceResponse<List<GetQuizDto>>();
            serviceResponse.Data = listQuiz.Select( q => _mapper.Map<GetQuizDto>(q)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetQuizDto>> GetQuizById(int id)
        {
            var currentQuiz = listQuiz.FirstOrDefault(q => q.Id == id);
            var serviceResponse = new ServiceResponse<GetQuizDto>();
            serviceResponse.Data = _mapper.Map<GetQuizDto>(currentQuiz);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetQuizDto>> UpdateQuiz(UpdateQuizDto updateQuiz)
        {
            var serviceResponse = new ServiceResponse<GetQuizDto>();
            
            try
            {
                var quiz = listQuiz.FirstOrDefault(q => q.Id == updateQuiz.Id);

                if (quiz is null)
                    throw new Exception($"Quiz with Id {updateQuiz.Id} not found");

                _mapper.Map(updateQuiz, quiz);

                quiz.Name = updateQuiz.Name;
                quiz.Description = updateQuiz.Description;
                quiz.Fields = updateQuiz.Fields;
                serviceResponse.Data = _mapper.Map<GetQuizDto>(quiz);
            }catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            
            return serviceResponse;
        }
    }
}
