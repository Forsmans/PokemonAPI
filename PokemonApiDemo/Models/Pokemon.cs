using System.Reflection.Metadata.Ecma335;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public string Trainer { get; set; }

    }
}
