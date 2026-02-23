using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Peterson.Models;

[Table("Categories")]
public class Category
{
        public int CategoryId { get; set; }
        //Seeting our Category Model to connect to our table.
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
}