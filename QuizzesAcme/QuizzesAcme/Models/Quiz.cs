using QuizzesAcme.Helpers;

namespace QuizzesAcme.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Field> Fields { get; set; } = new List<Field>();
        public string Url { get; set; } = string.Empty;
        public int UseId { get; set; } = 0;

        public Quiz(int id, string name, string description, List<Field> fields, string url, int useId)
        {
            Id = id;
            Name = name;
            Description = description;
            Fields = fields;
            Url = url;
            UseId = useId;
        }

        public Quiz() { }
    }
}
