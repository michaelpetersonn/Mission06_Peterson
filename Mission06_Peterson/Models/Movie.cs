using System.ComponentModel.DataAnnotations;

namespace Mission06_Peterson.Models;
// Setting our primary table along with our variables with whether they are required or not
public class Movie
{
    [Key]
    public int MovieId { get; set; }

    [Required]
    public string MovieTitle { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [Required]
    public int MovieYear { get; set; }

    [Required]
    public string MovieDirector { get; set; } = string.Empty;

    [Required]
    public string MovieRating { get; set; } = string.Empty;

    // Optional boolean, non-nullable for Razor checkbox
    public bool? Edited { get; set; } = false;

    // Optional fields
    public string? LentTo { get; set; }

    [StringLength(25)]
    public string? Notes { get; set; }
}