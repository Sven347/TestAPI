using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Service
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
