using PokeAPIGQL.Data;
using PokeAPIGQL.Models;

namespace PokeAPIGQL.GraphQL.Types
{
  public class PokemonTypeGQLType : ObjectType<PokemonType>
  {
    protected override void Configure(IObjectTypeDescriptor<PokemonType> descriptor)
    {
      descriptor.Description("A Pokémon Type");
      descriptor.Field(p => p.Id).Ignore();
      descriptor.Field(p => p.PokemonId).Ignore();
      descriptor.Field(p => p.Pokemon).Ignore();
    }
  }
}