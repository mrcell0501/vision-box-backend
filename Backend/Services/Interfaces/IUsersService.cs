using Backend.Models;
using Backend.Models.Request;

namespace Backend.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<User>> FindMany();
        Task<User> Create(CreateUserRequest payload);

    }
}
