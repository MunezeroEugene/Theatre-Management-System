using System.ComponentModel.DataAnnotations;
using TheatreMs.Api.Models;

namespace TheatreMs.Api.DTOs.Movie;

public class MovieDto
{
    public long? Id { get; set; }

    [Required(ErrorMessage = "Movie title is required")]
    [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Movie description is required")]
    [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Duration is required")]
    [Range(1, 500, ErrorMessage = "Duration must be between 1 and 500 minutes")]
    public int? DurationMinutes { get; set; }

    [Required(ErrorMessage = "Genre is required")]
    public MovieGenre? Genre { get; set; }

    [Required(ErrorMessage = "Director is required")]
    [MaxLength(255)]
    public string Director { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cast details are required")]
    [MaxLength(1000)]
    public string Cast { get; set; } = string.Empty;

    [Required(ErrorMessage = "Release date is required")]
    public DateOnly? ReleaseDate { get; set; }

    [Required(ErrorMessage = "Poster image URL is required")]
    [Url(ErrorMessage = "Invalid URL format for poster")]
    public string PosterImageUrl { get; set; } = string.Empty;

    [Url(ErrorMessage = "Invalid URL format for trailer")]
    public string? TrailerUrl { get; set; }

    [Required(ErrorMessage = "Content rating is required")]
    public MovieRating? Rating { get; set; }
}
