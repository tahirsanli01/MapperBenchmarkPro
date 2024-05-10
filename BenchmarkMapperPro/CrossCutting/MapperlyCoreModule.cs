using BenchmarkMapperPro.Configurations;
using BenchmarkMapperPro.CrossCutting.Core;

namespace BenchmarkMapperPro.CrossCutting
{
    public class MapperlyCoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddSingleton<ProductMapper>();
        }
    }
}
