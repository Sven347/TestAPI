using TestAPI.Model;

namespace TestAPI.Repository
{
    public class UserRepository: IUserRepository
    {
        public UserRepository()
        {
        }

        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    ID = 1,
                    Name = "Test",
                    Email = "Test@test.com",
                }
            };
        }
    }
}
