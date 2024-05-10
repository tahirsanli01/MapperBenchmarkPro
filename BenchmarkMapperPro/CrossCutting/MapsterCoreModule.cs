using BenchmarkMapperPro.CrossCutting.Core;
using MapperBenchmarkPro.Configurations;
using Mapster;

namespace BenchmarkMapperPro.CrossCutting
{
    public class MapsterCoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            // Register Mapster
            services.AddMapster();

            // Configure Mapster
            MapsterConfig.Configure();
        }
    }
}
