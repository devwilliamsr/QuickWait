using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        
        [Required]
        [Column("username")]
        public string Username { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Column("birthdate")]
        public string BirthDate { get; set; }
        [Required]
        [MaxLength(12)]
        [Column("cpf")]
        public string Cpf { get; set; }
        [Required]
        [MaxLength(11)]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Column("password")]
        public string Password { get; set; }

    }
}