namespace BenchmarkMapperPro.Configurations
{
    using BenchmarkMapperPro.Models.Dtos;
    using BenchmarkMapperPro.Models.Entities;
    using Riok.Mapperly.Abstractions;

    [Mapper]
    public partial class ProductMapper
    {
        [MapProperty(nameof(Product.Id), nameof(ProductDto.Id))]
        [MapProperty(nameof(Product.ReleaseDate), nameof(ProductDto.ReleaseDate), Use = nameof(MapReleaseDate))]
        [MapProperty(nameof(Product.Tags), nameof(ProductDto.Tags))]
        [MapProperty(nameof(Product.Reviews), nameof(ProductDto.Reviews))]
        [MapProperty(nameof(Product.Price), nameof(ProductDto.Price))]
        public partial ProductDto ProductToProductDto(Product product);

        private string MapReleaseDate(DateTime releaseDate) => releaseDate.ToString("yyyy-MM-dd");
    }


    [Mapper]
    public partial class ReviewMapper
    {
        [MapProperty(nameof(Review.ReviewerName), nameof(ReviewDto.ReviewerName))]
        [MapProperty(nameof(Review.Content), nameof(ReviewDto.Content))]
        public partial ReviewDto ReviewToReviewDto(Review product);
    }
}
