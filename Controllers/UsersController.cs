using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using census.Repository;
using Microsoft.AspNetCore.Mvc;
using census.Entities.Models;

namespace census.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private static readonly IUserRepository repository = new UserRepository();

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Users")]
        public IEnumerable<UserModel> GetAllUsers()
        {
            return repository.GetAll();
        }

        [HttpPost]
        [Route("User")]
        [Consumes("application/json")]
        public UserModel PostUser(UserModel model)
        {
            return repository.Add(model);
        }
    }
}