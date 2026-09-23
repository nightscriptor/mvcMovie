using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{

    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Pole {0} musi mieć od {2} do {1} znaków.")]
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        public string? Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100, ErrorMessage = "Pole {0} musi być w przedziale od {1} do {2}.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}
