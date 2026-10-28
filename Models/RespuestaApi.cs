namespace RickAndMortyApp.Models
{
    public class RespuestaApi
    {
        public Info Info { get; set; } = new();
        public List<Personaje> Results { get; set; } = new();
    }
}
