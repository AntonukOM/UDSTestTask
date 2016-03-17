using System.ComponentModel.DataAnnotations;

namespace Test.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Login can not be empty")]
        [StringLength(128, ErrorMessage = "Your name is too long")]
        [DataType(DataType.Text)]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password can not be empty")]
        [MinLength(2, ErrorMessage = "The minimum length of the password must be {0} characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name can not be empty")]
        [StringLength(128, ErrorMessage = "Your name is too long")]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}