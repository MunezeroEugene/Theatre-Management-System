using System.ComponentModel.DataAnnotations;

namespace TheatreMs.Api.Models;

public class AuditLog
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string UserId { get; set; } = string.Empty;
    
    [Required]
    public string Action { get; set; } = string.Empty;
    
    [Required]
    public string Resource { get; set; } = string.Empty;
    
    public string Details { get; set; } = string.Empty;
    
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    
    public string IpAddress { get; set; } = string.Empty;
}
