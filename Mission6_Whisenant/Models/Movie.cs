using Microsoft.JSInterop.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Whisenant.Models
{


    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("Category")]
        [Required(ErrorMessage ="Please enter a movie category.")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Title is required")]  
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2024, ErrorMessage = "Year must be 1888 or later")]
        public int Year { get; set; }
        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited status is required")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copied to Plex status is required")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be more than 25 characters")]
        public string? Notes { get; set; }
    }


}
