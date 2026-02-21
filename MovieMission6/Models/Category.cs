using System.ComponentModel.DataAnnotations;

namespace MovieMission6.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; } = "";
    }
}