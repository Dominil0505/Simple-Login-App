using System.ComponentModel.DataAnnotations;

namespace loginRegister.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [MaxLength(20, ErrorMessage = "Max 20 characters allowed")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Password is to small")]
        public string Password { get; set; }
    }
}
