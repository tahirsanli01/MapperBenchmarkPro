using BenchmarkMapperPro.Models.Dtos;
using BenchmarkMapperPro.Models.Entities;
using Nelibur.ObjectMapper;

namespace BenchmarkMapperPro.Configurations
{
    public class TinyMap
    {
        public static void Initialize()
        {
            TinyMapper.Bind<Product, ProductDto>(config =>
            {
                config.Ignore(x => x.Id);
            });
        }
    }
}
