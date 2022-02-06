using PokeAPIGQL.Data;
using PokeAPIGQL.Models;

namespace PokeAPIGQL.GraphQL
{
  [GraphQLDescription("Pokemon Query")]
  public class PokemonQuery
  {
    [GraphQLDescription("Get All Pokemons")]
    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Pokemon> GetPokemons([ScopedService] AppDbContext context)
    {
      var pokemons = context.Pokemons;
      return pokemons;
    }

    [GraphQLDescription("Get Pokemon by Name")]
    [UseDbContext(typeof(AppDbContext))]
    public Pokemon GetPokemon([GraphQLName("name")] string name, [ScopedService] AppDbContext context)
    {
      var pokemon = context.Pokemons.Where(p => p.Name == name).FirstOrDefault();
      return pokemon;
    }

    [GraphQLDescription("Get Pokemon by Number")]
    [UseDbContext(typeof(AppDbContext))]
    public Pokemon GetPokedex([GraphQLName("id")] int number, [ScopedService] AppDbContext context)
    {
      var pokemon = context.Pokemons.FirstOrDefault(p => p.Number == number);
      return pokemon;
    }
  }
}