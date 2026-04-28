using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.DTOs;

public class UpdateUserRequest
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Role is required.")]
    [StringLength(50, MinimumLength = 2)]
    public string Role { get; set; } = string.Empty;
}
