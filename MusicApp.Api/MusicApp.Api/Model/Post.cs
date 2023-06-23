namespace MusicApp.Api.Model
{
    public class Post
    {
        public int idPost { get; set; }
        public int idUsuario { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Postagem { get; set; }
    }
}
