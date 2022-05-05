using System;

namespace Domain.DTOs.AuthUsers.SignUp
{
    public class SignUpResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
