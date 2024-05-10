using BenchmarkMapperPro.Models.Dtos;
using BenchmarkMapperPro.Models.Entities;
using Mapster;

namespace MapperBenchmarkPro.Configurations
{
    public static class MapsterConfig
    {
        public static void Configure()
        {
            TypeAdapterConfig<Product, ProductDto>.NewConfig()

                .Map(dest => dest.Id, src => src.Id)

                .Map(dest => dest.Name, src => src.Name)

                .Map(dest => dest.ReleaseDate, src => src.ReleaseDate.ToString("yyyy-MM-dd"))

                .Map(dest => dest.Tags, src => src.Tags)

                .Map(dest => dest.Reviews, src => src.Reviews.Adapt<List<ReviewDto>>())

                .Map(dest => dest.Price, src => src.Price);

            TypeAdapterConfig<Review, ReviewDto>.NewConfig()

                .Map(dest => dest.ReviewerName, src => src.ReviewerName)

                .Map(dest => dest.Content, src => src.Content);

        }
    }
}
