using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;
using BenchmarkMapperPro.Configurations;
using BenchmarkMapperPro.CrossCutting.Core;
using BenchmarkMapperPro.Models.Datasets;
using BenchmarkMapperPro.Models.Dtos;
using BenchmarkMapperPro.Models.Entities;
using Nelibur.ObjectMapper;
using System;

namespace BenchmarkMapperPro
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser]
    public class MapperBenchmark
    {

        [GlobalSetup]
        public void Setup()
        {

        }

        [Benchmark]
        public void Mapster()
        {
            var _service = ServiceTool.ServiceProvider.GetService<MapsterMapper.IMapper>();
            var productDto = _service.Map<ProductDto>(ProductHelper.GetProduct());
        }

        [Benchmark]
        public void Mapperly()
        {
            var _service = ServiceTool.ServiceProvider.GetService<ProductMapper>();
            var productDto = _service.ProductToProductDto(ProductHelper.GetProduct());
        }

        [Benchmark()]
        public void TinyMap()
        {
            var productDto = TinyMapper.Map<ProductDto>(ProductHelper.GetProduct());
        }

        [Benchmark()]
        public void AutoMapper()
        {
            var _service = ServiceTool.ServiceProvider.GetService<AutoMapper.IMapper>();
            var productDto = _service.Map<ProductDto>(ProductHelper.GetProduct());
        }
    }

    public class AntiVirusFriendlyConfig : ManualConfig
    {
        public AntiVirusFriendlyConfig()
        {
            AddJob(Job.MediumRun
                .WithToolchain(InProcessNoEmitToolchain.Instance));
        }
    }
}
