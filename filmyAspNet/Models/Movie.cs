using System.ComponentModel.DataAnnotations;

namespace filmyAspNet.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public String? Genre { get; set; }
        public Decimal Price { get; set; }
    }
}
