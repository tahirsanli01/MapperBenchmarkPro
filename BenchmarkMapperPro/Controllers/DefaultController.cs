using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkMapperPro.CrossCutting;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace BenchmarkMapperPro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DefaultController : ControllerBase
    {


        [HttpGet(Name = "Run")]
        public IActionResult Run()
        {
            var summary = BenchmarkRunner.Run<MapperBenchmark>();
            return Ok();
        }
    }
}
