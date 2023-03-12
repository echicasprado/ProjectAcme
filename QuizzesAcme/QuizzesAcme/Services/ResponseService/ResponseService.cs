using QuizzesAcme.Helpers;
using QuizzesAcme.Models.Response;

namespace QuizzesAcme.Services.ResponseService
{
    public class ResponseService : IResponseService
    {
        public Task<ServiceResponse<List<int>>> CountQuiz(int QuizId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Response>>> NewResponse(Response newAnswer)
        {
            throw new NotImplementedException();
        }
    }
}
