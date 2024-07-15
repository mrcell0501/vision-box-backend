using Backend.Models;
using Backend.Models.Request;
using Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApiDatabaseContext _db;

        public UsersService(ApiDatabaseContext dbContext)
        {
            _db = dbContext;
        }

        public async Task<IEnumerable<User>> FindMany()
        {
            return await _db.Users.OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<User> Create(CreateUserRequest payload)
        {
            User user = new()
            {
                Name = payload.Name,
                Email = payload.Email,
                Role = payload.Role,
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();

            return user;
        }

    }
}
