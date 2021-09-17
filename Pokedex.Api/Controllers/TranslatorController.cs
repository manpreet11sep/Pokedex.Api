using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Pokemon/translated")]
    [ApiVersion("1.0")]
    public class TranslatorController : ControllerBase
    {
        [HttpGet("{pokemonName}")]
        public IActionResult GetPokemonTranslated([FromRoute] string pokemonName)
        {
            return new JsonResult("Pokemon");
        }
    }
}