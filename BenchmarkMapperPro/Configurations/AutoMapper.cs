using AutoMapper;
using BenchmarkMapperPro.Models.Dtos;
using BenchmarkMapperPro.Models.Entities;

namespace BenchmarkMapperPro.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.ReleaseDate, act => act.MapFrom(src => src.ReleaseDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.Tags, act => act.MapFrom(src => src.Tags))
                .ForMember(dest => dest.Reviews, act => act.MapFrom(src => src.Reviews))
                .ForMember(dest => dest.Price, act => act.MapFrom(src => src.Price)).ReverseMap();

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.ReviewerName, act => act.MapFrom(src => src.ReviewerName))
                .ForMember(dest => dest.Content, act => act.MapFrom(src => src.Content)).ReverseMap();
        }
    }
}
