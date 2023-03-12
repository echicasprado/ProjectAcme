using Microsoft.AspNetCore.Mvc.Formatters;

namespace QuizzesAcme.Helpers
{
    public class Field
    {
        public string Name { get; set; } = string.Empty;
        public string Tittle { get; set; } = string.Empty;
        public bool Required { get; set; } = false;
        public FieldType Type { get; set; } = FieldType.Texto;

        /// <summary>
        /// Create new field
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tittle"></param>
        /// <param name="required"></param>
        /// <param name="type"></param>
        public Field(string name, string tittle, bool required, FieldType type)
        {
            Name = name;
            Tittle = tittle;
            Required = required;
            Type = type;
        }

        public Field() { }
    }
}
