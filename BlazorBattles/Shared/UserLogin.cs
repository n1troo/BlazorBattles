using System.ComponentModel.DataAnnotations;

namespace BlazorBattles.Shared;

public class UserLogin
{
    [Required(ErrorMessage = "Proszę wprowadzić nazwę użytkownika")]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}