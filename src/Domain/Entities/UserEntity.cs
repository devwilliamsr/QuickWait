using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        
        [Column("username")]
        public string Username { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("birthdate")]
        public string BirthDate { get; set; }
        [Column("cpf")]
        public string Cpf { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("password")]
        public string Password { get; set; }
        
    }
}