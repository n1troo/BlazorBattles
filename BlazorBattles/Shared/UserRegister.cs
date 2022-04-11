using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BlazorBattles.Shared;

public class UserRegister
{
    [Required, EmailAddress] public string Email { get; set; }

    [Required, MinLength(2), MaxLength(10)]
    public string UserName { get; set; }

    public string Bio { get; set; }
    [Required, PasswordPropertyText] public string Password { get; set; }

    [Required, PasswordPropertyText, Compare("Password", ErrorMessage = "Hasła różnią się!")]
    public string ConfirmPassword { get; set; }

    public int StarUnitId { get; set; } = 1;

    [Required, Range(10, 1000, ErrorMessage = "Wybierz pomiedzy 10-1000")]
    public int Bananas { get; set; } = 100;

    public DateTime DateOfBirth { get; set; } = DateTime.Now;

    [Range(typeof(bool), "true", "true", ErrorMessage = "Wybierz jedno jedno!")]
    public bool isConfirmed { get; set; } = true;
}