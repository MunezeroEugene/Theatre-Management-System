public class UserDto
{
    public string Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Username { get; set; }

    [Required]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [StringLength(15)]
    public string PhoneNumber { get; set; }

    [Required]
    public UserRole? Role { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }
}