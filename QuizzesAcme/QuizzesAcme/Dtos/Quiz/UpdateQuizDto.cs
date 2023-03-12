using QuizzesAcme.Helpers;

namespace QuizzesAcme.Dtos.Quiz
{
    public class UpdateQuizDto
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public List<Field> Fields { get; set; } = new List<Field>();
        public string Url { get; set; } = String.Empty;
        public int UseId { get; set; } = 0;
    }
}
