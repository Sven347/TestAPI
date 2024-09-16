using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Model;
using TestAPI.Service;

namespace TestAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;


        public UserController(ILogger<UserController> logger,IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        [Authorize(Roles = "admin")]
        public List<User> GetUsers()
        {
          
            try
            {
                return _userService.GetUsers();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);   
                return new List<User>();
            }
        }
    }
}
