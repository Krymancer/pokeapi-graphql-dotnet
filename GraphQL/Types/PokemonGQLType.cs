using PokeAPIGQL.Data;
using PokeAPIGQL.Models;

namespace PokeAPIGQL.GraphQL.Types
{
  public class PokemonGQLType : ObjectType<Pokemon>
  {
    protected override void Configure(IObjectTypeDescriptor<Pokemon> descriptor)
    {
      descriptor.Description("A Pokémon");
      descriptor.Field(p => p.Id).Ignore();
      descriptor.Field(p => p.Types)
      .ResolveWith<Resolvers>(p => p.GetTypes(default!, default!))
      .UseDbContext<AppDbContext>();
    }

    private class Resolvers
    {
      public IQueryable<PokemonType> GetTypes([Parent] Pokemon pokemon, [ScopedService] AppDbContext context)
      {
        return context.PokemonTypes.Where(p => p.PokemonId == pokemon.Id);
      }
    }
  }
}