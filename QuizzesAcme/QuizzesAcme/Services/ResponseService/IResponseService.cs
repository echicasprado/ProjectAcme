using QuizzesAcme.Helpers;
using QuizzesAcme.Models;
using QuizzesAcme.Models.Response;

namespace QuizzesAcme.Services.ResponseService
{
    public interface IResponseService
    {
        Task<ServiceResponse<List<Response>>> NewResponse(Response newAnswer);
        Task<ServiceResponse<List<int>>> CountQuiz(int QuizId);
    }
}
