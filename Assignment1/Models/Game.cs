using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]

        public string Title { get; set; } = string.Empty;
        [Required]

        public string Developer { get; set; } = string.Empty;
        [Required]
        [GenreValidation(ErrorMessage ="Genre is not valid")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Release Year")]
        [Required]
        [ReleaseYearValidation]
        public int ReleaseYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        [PurchaseDateValidation(ErrorMessage ="Purchase date cannot be in the future")]
        public DateTime? PurchaseDate { get; set; }

        [Range(1, 100)]
        public int Rating { get; set; }

    }
}
