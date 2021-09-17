using Microsoft.AspNetCore.Mvc;
using Pokedex.Api.Attributes;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Pokemon")]
    [ApiVersion("1.0")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPokemons()
        {
            return new JsonResult("Pokemon");
        }

        [HttpGet("{pokemonName}")]
        [ValidatePokemonNameParameter]
        public IActionResult GetAllPokemons([FromRoute] string pokemonName)
        {
            return new JsonResult("Pokemon");
        }
    }
}