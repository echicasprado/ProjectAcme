using System.Text.Json.Serialization;

namespace QuizzesAcme.Helpers
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FieldType
    {
        Texto = 1,
        Numero = 2,
        Fecha = 3
    }
}
