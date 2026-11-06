using System.Text.Json.Serialization;

namespace SenacStore.Application.DTOs
{
    public class UsuarioRequestDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Senha { get; set; }
        public Guid TipoUsuarioId { get; set; }
    }
}
