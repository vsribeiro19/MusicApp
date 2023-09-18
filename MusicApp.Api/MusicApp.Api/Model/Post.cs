namespace MusicApp.Api.Model
{
    public class Post
    {
        public Guid idPost { get; set; }
        public int idUsuario { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public List<Comentario>? Comentarios { get; set; }
        public DateTime? Postagem { get; set; }
        public bool? Status { get; set; }
    }
}
