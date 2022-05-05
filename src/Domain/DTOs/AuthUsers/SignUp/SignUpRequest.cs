using System.ComponentModel.DataAnnotations;

namespace Domain.DTOs.AuthUsers.SignUp
{
    public class SignUpRequest
    {
        [Required(ErrorMessage ="Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Email is required.")]
        [EmailAddress(ErrorMessage ="Format invalid.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }
        public string BirthDate { get; set; }
        [MaxLength(12, ErrorMessage ="Cpf must have a max of {1} characters")]
        public string Cpf { get; set; }
        [MaxLength(11, ErrorMessage = "PhoneNumber must have a max of {1} characters")]
        public string PhoneNumber { get; set; }
        
    }
}
