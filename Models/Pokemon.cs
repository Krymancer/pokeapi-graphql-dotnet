using System.ComponentModel.DataAnnotations;

namespace PokeAPIGQL.Models
{
  [GraphQLDescription("A Pokémon")]
  public class Pokemon
  {
    [Key]
    public int Id { get; set; }
    [GraphQLDescription("The Number of the Pokémon in the National Dex")]
    public int Number { get; set; }
    [GraphQLDescription("The Name of the Pokémon")]
    public string Name { get; set; }
    [GraphQLDescription("The Species of the Pokémon")]
    public string Species { get; set; }
    [GraphQLDescription("The Height of the Pokémon in meters")]
    public double Height { get; set; }
    [GraphQLDescription("The Weight of the Pokémon in kilograms")]
    public double Weight { get; set; }
    [GraphQLDescription("An URL to a image of the Pokémon")]
    public string Sprite { get; set; }
    [GraphQLDescription("The Description of the Pokémon")]
    public string Description { get; set; }
    [GraphQLDescription("The types of the Pokémon")]
    public ICollection<PokemonType> Types { get; set; }
  }
}