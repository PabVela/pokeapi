using Pokedex.Host.MinimalApi.Pokemon;

namespace Pokedex.Host.Controllers
{
    public static class MinimalApiExtensions
    {
        public static WebApplication MapMinimalApi(this WebApplication app)
        {
            app.MapPokemonMinimalApi();
            return app;
        }
    }
}
