using System.ComponentModel.DataAnnotations;
using static MoviesWebApi.Data.Constants;

namespace MoviesWebApi.Data.Dto
{
    public class RegisterDto
    {
        [Required(ErrorMessage = UsernameErrorMessage)]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength)]
        public string Username { get; set; } = null!;


        [Required(ErrorMessage = EmailErrorMessage)]
        [EmailAddress]
        [StringLength(EmailMaxLenght, MinimumLength = EmailMinLength)]
        public string Email { get; set; } = null!;

        
        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}

