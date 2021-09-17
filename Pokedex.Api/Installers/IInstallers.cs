using Microsoft.Extensions.DependencyInjection;

namespace Pokedex.Api.Installers
{
    public interface IInstallers
    {
        void InstallServices(IServiceCollection services);
    }
}