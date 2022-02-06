# PokeAPI Graphql

A simple graphql api.

## Technologies

- Dotnetcore 6.0
- SQL Server
- Docker
- GraphQL

# Build

You need docker (or install the SQL Server idk i like use docker) to the database. so:

    docker-compose up -d

frist install the dependences:

    dotnet restore

after you need to create the database, just run the migrations:

    dotnet ef add migration build
    dotnet ef database update

then run the project

    dotnet build
