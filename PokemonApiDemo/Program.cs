using PokemonAPI.Data;
using PokemonAPI.Models;

namespace PokemonApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PokemonDBContext db = new PokemonDBContext("PokemonDB");


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.MapGet("/Pokemons", () =>
            {
                return db;

            });

            app.Run();
        }
    }
}

            //List<Pokemon> pokemons = new List<Pokemon>
            //{
            //    new Pokemon { Id = 1, Name = "Pikachu", Type = "Electric", Level = 10, Trainer = "Ash" },
            //    new Pokemon { Id = 2, Name = "Bulbasaur", Type = "Grass/Poison", Level = 12, Trainer = "Misty" },
            //    new Pokemon { Id = 3, Name = "Charmander", Type = "Fire", Level = 8, Trainer = "Brock" },
            //    new Pokemon { Id = 4, Name = "Squirtle", Type = "Water", Level = 11, Trainer = "Gary" },
            //    new Pokemon { Id = 5, Name = "Jigglypuff", Type = "Normal/Fairy", Level = 9, Trainer = "Serena" },
            //    new Pokemon { Id = 6, Name = "Meowth", Type = "Normal", Level = 7, Trainer = "Jessie" },
            //    new Pokemon { Id = 7, Name = "Geodude", Type = "Rock/Ground", Level = 14, Trainer = "James" },
            //    new Pokemon { Id = 8, Name = "Machop", Type = "Fighting", Level = 13, Trainer = "May" },
            //    new Pokemon { Id = 9, Name = "Abra", Type = "Psychic", Level = 6, Trainer = "Max" },
            //    new Pokemon { Id = 10, Name = "Sandshrew", Type = "Ground", Level = 10, Trainer = "Dawn" }
            //};

            //foreach(var pokemon in pokemons)
            //{
            //    db.AddPokemon("Pokemons",pokemon);
            //}