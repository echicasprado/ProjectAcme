using QuizzesAcme.Helpers;

namespace QuizzesAcme.Models.Response
{
    public class Response
    {
        public int Id { get; set; } = 0;
        public int QuizId { get; set; } = 0;
        public List<FieldValue> Values { get; set; } = new List<FieldValue>();
        public DateTime Date { get; set; } = DateTime.Now;

        public Response(int id, int quizId, DateTime date, List<FieldValue> values)
        {
            Id = id;
            QuizId = quizId;
            Date = date;
            Values = values;
        }

        public Response() { }
    }
}
