using BenchmarkMapperPro.Configurations;
using BenchmarkMapperPro.CrossCutting.Core;

namespace BenchmarkMapperPro.CrossCutting
{
    public class AutoMapperCoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
