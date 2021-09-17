using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Pokedex.Api.Installers
{
    public class SwaggerInstaller : IInstallers
    {
        public void InstallServices(IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Pokedex API", Version = "v1" });
            });
        }
    }
}