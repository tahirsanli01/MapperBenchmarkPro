using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperBenchmarkPro.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<string> Tags { get; set; }

        public List<Review> Reviews { get; set; }

        public decimal Price { get; set; }
    }
}
