using System.ComponentModel.DataAnnotations;

namespace Mission06_Peterson.Models;

public class Category
{
        public int CategoryId { get; set; }
        
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
}