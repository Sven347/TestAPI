using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
