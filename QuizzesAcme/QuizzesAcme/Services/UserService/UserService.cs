using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models;
using QuizzesAcme.Models.User;

namespace QuizzesAcme.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly JwtAuthenticationManager _jwtServiceManager;
        
        public UserService(JwtAuthenticationManager jwtServiceManager)
        {
            _jwtServiceManager = jwtServiceManager;
        }

        public Task<ServiceResponse<User>> getUserInformation(string email)
        {
            throw new NotImplementedException();
        }

        
        public async Task<ServiceResponse<GetLogin>> login(User user)
        {
            var token = _jwtServiceManager.Authenticate(user);
            var currentLogin = new GetLogin();
            var serviceResponse = new ServiceResponse<GetLogin>();

            currentLogin.Username = user.Email;
            currentLogin.Token = token;
            serviceResponse.Data = currentLogin;
            
            if(token == null) 
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Acceso denegado";
            }

            return serviceResponse;
        }
    }
}
