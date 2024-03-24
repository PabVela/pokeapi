using System.Threading.Channels;

namespace Pokedex.Host.MinimalApi.Pokemon
{
    public static class MapPokemonMinimalApiExtensions
    {
        public static WebApplication MapPokemonMinimalApi(this WebApplication app)
        {

            app.MapGet("/api/pokemon/{pokemonName}", async (
                
                string pokemonName
                ) =>
            {
                return Results.Ok("hola");
            });
            return app;
        }
    }
}
