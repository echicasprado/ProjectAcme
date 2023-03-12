using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizzesAcme.Dtos.Quiz;
using QuizzesAcme.Helpers;
using QuizzesAcme.Models;
using System.Xml;

namespace QuizzesAcme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService) 
        {
            this._quizService = quizService;
        }

        [Authorize]
        [HttpGet("AllQuizzes")]
        public async Task<ActionResult<ServiceResponse<List<GetQuizDto>>>> Get()
        {
            return Ok(await this._quizService.GetAllQuizzes());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetQuizDto>>> GetById(int id)
        {
            return Ok(await this._quizService.GetQuizById(id));
        }

        [HttpPost("CreateQuiz")]
        public async Task<ActionResult<ServiceResponse<GetQuizDto>>> PostCreateQuiz(AddQuizDto newQuiz)
        {
            var result = await _quizService.AddQuiz(newQuiz);

            if (!result.Success)
                return NotFound(result);

            return Ok(result);
        }

        [HttpPut("updateQuiz")]
        public async Task<ActionResult<ServiceResponse<GetQuizDto>>> PutQuiz(UpdateQuizDto updateQuiz)
        {
            var result = await _quizService.UpdateQuiz(updateQuiz);

            if (!result.Success)
                return NotFound(result);
            
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<GetQuizDto>>> DeleteQuiz(int id)
        {
            var result = await _quizService.DeleteQuiz(id);

            if (!result.Success)
                return NotFound(result);

            return Ok(result);
        }
    }
}
