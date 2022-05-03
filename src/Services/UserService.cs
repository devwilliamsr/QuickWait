using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.User;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly ILogger<UserEntity> _logger;

        public UserService(IRepository<UserEntity> repository, ILogger<UserEntity> logger)
        {
            repository = _repository;
            logger = _logger;
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
            return await _repository.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
