using Microsoft.EntityFrameworkCore;
using PokeAPIGQL.Data;
using PokeAPIGQL.GraphQL;
using PokeAPIGQL.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(options => options.UseSqlServer
  (builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
  .AddGraphQLServer()
  .AddQueryType<PokemonQuery>()
  .AddType<PokemonGQLType>()
  .AddType<PokemonTypeGQLType>()
  .AddFiltering()
  .AddSorting()
  .AddProjections()
  .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);

var app = builder.Build();

app.MapGraphQL();

app.Run();
