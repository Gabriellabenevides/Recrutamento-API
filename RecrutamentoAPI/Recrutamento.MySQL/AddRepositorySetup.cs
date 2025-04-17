using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recrutamento.Domain.Interface;
using Recrutamento.MySQL.Repositories;

namespace Recrutamento.MySQL;

public static class AddRepositorySetup
{
    public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IVagaRepository, VagaRepository>();
        services.AddScoped<IProcessoSeletivoRepository, ProcessoSeletivoRepository>();
        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        return services;
    }
}