namespace MusicApp.Api.Model
{
    public class Comentario
    {
        public Guid IdComentario { get; set; }
        public Usuario? IdUsuario { get; set; }
        public Usuario? Nome { get; set; }
        public DateTime? DataComentario { get; set; }
        public bool? Status { get; set; }
    }
}
