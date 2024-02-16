using Microsoft.JSInterop.Infrastructure;
using System.ComponentModel.DataAnnotations; 

namespace Mission6_Whisenant.Models
{
    //public class MovieCollection
    //{
    //    [Key]
    //    public int MovieID { get; set; }
    //    public string Category { get; set; }
    //    public string Title { get; set; }
    //    public int Year { get; set; }
    //    public string Director { get; set; }
    //    public string Rating { get; set; }
    //    public bool? Edited { get; set; }
    //    public string? LentTo { get; set; }
    //    public string? Notes { get; set; }


    //}

    public class MovieCollection
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        public string? Subcategory { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        // No data annotation required for Edited as it's a nullable boolean
        public bool? Edited { get; set; }

        // LentTo is optional, no data annotation required
        public string? LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot be more than 25 characters.")]
        public string? Notes { get; set; }
    }


}
