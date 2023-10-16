using System.ComponentModel.DataAnnotations;

namespace Unit2Project_HarryByrd.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1947, 2023, ErrorMessage = "Year must be after 1947.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre? Genre { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
