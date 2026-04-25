using System.ComponentModel.DataAnnotations;
using TheatreMs.Api.Models;

namespace TheatreMs.Api.DTOs.Screening;

public class ScreeningDto
{
    public long? Id { get; set; }

    [Required(ErrorMessage = "Movie selection is required")]
    public long? MovieId { get; set; }

    public string? MovieTitle { get; set; }

    [Required(ErrorMessage = "Theatre selection is required")]
    public long? TheatreId { get; set; }

    public string? TheatreName { get; set; }

    [Required(ErrorMessage = "Screening start time is required")]
    public DateTime? StartTime { get; set; }

    public string? StartDateString { get; set; }
    public string? StartTimeString { get; set; }
    public DateTime? EndTime { get; set; }

    [Required(ErrorMessage = "Screen number is required")]
    [Range(1, 40, ErrorMessage = "Screen number must be between 1 and 40")]
    public int? ScreenNumber { get; set; }

    [Required(ErrorMessage = "Screening format is required")]
    public ScreeningFormat? Format { get; set; }

    [Required(ErrorMessage = "Base price is required")]
    [Range(0.01, 1000000.0, ErrorMessage = "Price must be greater than 0")]
    public double? BasePrice { get; set; }
}
