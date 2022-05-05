using Domain.DTOs.AuthUsers.SignUp;
using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> Get(Guid id);
        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(Guid id);
    }
}
