using TestAPI.Model;
using TestAPI.Repository;

namespace TestAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService( IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
