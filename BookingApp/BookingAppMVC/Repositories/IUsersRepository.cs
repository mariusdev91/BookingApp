using BookingAppMVC.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppMVC.Repositories
{
    interface IUsersRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        void CreateUser(User u);
        void DeleteUser(int id);
        void UpdateUser(User u);
    }
}
