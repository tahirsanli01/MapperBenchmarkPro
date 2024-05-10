using BenchmarkMapperPro.Configurations;
using BenchmarkMapperPro.CrossCutting.Core;

namespace BenchmarkMapperPro.CrossCutting
{
    public class TinyMapCoreModule : ICoreModule
    {
        public void Load(IServiceCollection collection)
        {
            TinyMap.Initialize();
        }
    }
}
