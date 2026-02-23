using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMission6.Models
{
    public class NewMovie
    {
        [Key]
        public int? MovieId { get; set; }   // Primary Key

        public int? CategoryId { get; set; }   // FK

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }   // navigation property


        [Required(ErrorMessage="Please enter a movie title")]
        public string Title { get; set; } = "";

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int? Year { get; set; }

        
        public string? Director { get; set; } = "";

        
        public string? Rating { get; set; } = "";

        [Required]
        public bool? Edited { get; set; }

        [Required]
        public bool? CopiedToPlex { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
