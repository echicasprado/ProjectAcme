using QuizzesAcme.Dtos.Quiz;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models;

namespace QuizzesAcme.Services.QuizService
{
    public interface IQuizService
    {
        Task<ServiceResponse<List<GetQuizDto>>> GetAllQuizzes();
        Task<ServiceResponse<GetQuizDto>> GetQuizById(int id);
        Task<ServiceResponse<GetQuizDto>> AddQuiz(AddQuizDto newQuiz);
        Task<ServiceResponse<GetQuizDto>> UpdateQuiz(UpdateQuizDto updateQuiz);
        Task<ServiceResponse<GetQuizDto>> DeleteQuiz(int id);
    }
}
