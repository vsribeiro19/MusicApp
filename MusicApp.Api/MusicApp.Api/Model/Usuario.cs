using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MusicApp.Api.Model
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Perfil? Perfil { get; set; }
        public DateTime? DataCriacao { get; set; }
        public bool? Status { get; set; }
    }
}
