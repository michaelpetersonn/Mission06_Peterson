using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Peterson.Models;
// Setting our primary table along with our variables with whether they are required or not
[Table("Movies")]
public class Movie
{
    [Key]
    public int MovieId { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [Range(1888, 2100, ErrorMessage = "Year must be between 1888, 2100")]
    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }
    
// Category (foreign key + navigation property)
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    // Optional boolean, non-nullable for Razor checkbox
    [Required]
    public bool Edited { get; set; } = false;

    [Required] 
    public bool CopiedToPlex { get; set; } = false;
    
    public string? LentTo { get; set; }
    
    [StringLength(25)]
    public string? Notes { get; set; }
}