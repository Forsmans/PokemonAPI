using MongoDB.Driver;

namespace PokemonAPI.Data
{
    public class PokemonDBContext
    {
        private readonly IMongoDatabase db;


        public PokemonDBContext(string database) 
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void AddPokemon<T>(string table, T pokemon)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(pokemon);
        }

    }
}
