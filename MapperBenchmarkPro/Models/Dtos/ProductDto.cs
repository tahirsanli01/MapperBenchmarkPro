namespace MapperBenchmarkPro.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // as a formatted string  
        public string ReleaseDate { get; set; }

        public List<string> Tags { get; set; }

        public List<ReviewDto> Reviews { get; set; }

        public decimal Price { get; set; }
    }
}
