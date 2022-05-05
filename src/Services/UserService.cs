using Domain.DTOs.AuthUsers.SignUp;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private ILogger<UserEntity> _logger;

        public UserService(IRepository<UserEntity> repository, ILogger<UserEntity> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            byte[] salt = new byte[128 / 8];

            user.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: user.Password,
                salt:salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            var users = new UserEntity();
            

            return await _repository.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
