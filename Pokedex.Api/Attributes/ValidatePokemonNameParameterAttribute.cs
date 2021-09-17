using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pokedex.Api.Attributes
{
    public class ValidatePokemonNameParameterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionArguments.ContainsKey("pokemonName"))
            {
                // the trick is to get the parameter from filter context
                string pokemonName = filterContext.ActionArguments["pokemonName"] as string;

                // validate name

                if (string.IsNullOrEmpty(pokemonName) || pokemonName.Length > 20 || !Regex.IsMatch(pokemonName, "^[ A-Za-z_'-]*$"))
                {
                    filterContext.Result = new BadRequestObjectResult(new
                    {
                        StatusCode = 403,
                        Value = "The PokeName Name supplied is not a valid"
                    });
                }

                base.OnActionExecuting(filterContext);
            }
        }
    }
}
