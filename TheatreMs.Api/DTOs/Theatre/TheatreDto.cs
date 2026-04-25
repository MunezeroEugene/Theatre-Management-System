using System.ComponentModel.DataAnnotations;

namespace TheatreMs.Api.DTOs.Theatre;

public class TheatreDto
{
    public long? Id { get; set; }

    [MaxLength(100)]
    public string? Name { get; set; }

    [MaxLength(200)]
    public string? Address { get; set; }

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    [MaxLength(100)]
    public string? Email { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Province is required"), MaxLength(50)]
    public string Province { get; set; } = string.Empty;

    [Required(ErrorMessage = "District is required"), MaxLength(50)]
    public string District { get; set; } = string.Empty;

    [Required(ErrorMessage = "Sector is required"), MaxLength(50)]
    public string Sector { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cell is required"), MaxLength(50)]
    public string Cell { get; set; } = string.Empty;

    [Required(ErrorMessage = "Village is required"), MaxLength(50)]
    public string Village { get; set; } = string.Empty;

    public int? TotalScreens { get; set; }
    public string? ImageUrl { get; set; }
}
