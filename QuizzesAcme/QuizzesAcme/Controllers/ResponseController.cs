using Microsoft.AspNetCore.Mvc;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models.Response;
using QuizzesAcme.Services.ResponseService;

namespace QuizzesAcme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;

        public ResponseController(IResponseService responseService)
        {
            _responseService= responseService;
        }

        [HttpPost("newAnswer")]
        public async Task<ActionResult<ServiceResponse<Response>>> PostNewAnswer(Response answer)
        {
            var result = await _responseService.NewResponse(answer);
            return Ok(result);
        }

    }
}
