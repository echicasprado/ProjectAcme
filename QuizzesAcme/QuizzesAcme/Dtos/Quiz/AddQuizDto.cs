using QuizzesAcme.Helpers;

namespace QuizzesAcme.Dtos.Quiz
{
    public class AddQuizDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Field> Fields { get; set; } = new List<Field>();
        public int UseId { get; set; } = 0;
    }
}
