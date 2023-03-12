using QuizzesAcme.Helpers;
using QuizzesAcme.Models;
using QuizzesAcme.Models.User;

namespace QuizzesAcme.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<User>> getUserInformation(string email);
        Task<ServiceResponse<GetLogin>> login(User user);
    }
}
