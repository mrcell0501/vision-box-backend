using Backend.Models;
using Backend.Models.Request;
using Backend.Models.Response;
using Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserResponse>> GetUsers()
        {
            IEnumerable<User> users = await usersService.FindMany();
            return users.Select(user => new UserResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
            });
        }


        [HttpPost]
        public async Task<ActionResult<UserResponse>> PostUser(CreateUserRequest payload)
        {
            User user = await usersService.Create(payload);
            return new UserResponse
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
            };

        }

    }
}
