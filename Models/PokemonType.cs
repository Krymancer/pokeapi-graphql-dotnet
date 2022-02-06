using System.ComponentModel.DataAnnotations;

namespace PokeAPIGQL.Models
{
  [GraphQLDescription("A Pokémon Type")]
  public class PokemonType
  {
    [Key]
    public int Id { get; set; }
    [GraphQLDescription("The Name of the Pokémon Type")]
    public string Name { get; set; }
    public int PokemonId { get; set; }
    public Pokemon Pokemon { get; set; }
  }
}