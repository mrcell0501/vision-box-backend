using Backend.Models;
using Backend.Models.Request;
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
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await usersService.FindMany();
        }


        [HttpPost]
        public async Task<ActionResult<User>> PostUser(CreateUserRequest payload)
        {
            return await usersService.Create(payload);

        }

    }
}
