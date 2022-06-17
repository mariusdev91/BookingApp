using BookingAppMVC.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookingAppMVC.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private HotelBookingEntities db = new HotelBookingEntities();
        public List<User> GetUsers()
        {
            var allUsers = db.Users.ToList();
            return allUsers;
        }
        public User GetUser(int id)
        {
            var u = (from user in db.Users
                     where user.Id == id
                     select user).FirstOrDefault();
            if (u == null)
            {
                throw new Exception("User not found!");
            }
            return u;
        }
        public void CreateUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();

        }
        public void DeleteUser(int id)
        {
            var u = (from user in db.Users
                     where user.Id == id
                     select user).FirstOrDefault();

            if (u == null)
            {
                throw new Exception("User not found!");
            }
            db.Users.Remove(u);
            db.SaveChanges();
        }
        public void UpdateUser(User u)
        {
            var userToUpdate = (from user in db.Users
                                where user.Id == u.Id
                                select user).FirstOrDefault();

            if (userToUpdate == null)
            {
                throw new Exception("User not found!");
            }

            userToUpdate.FirstName = u.FirstName;
            userToUpdate.LastName = u.LastName;
            db.Entry(userToUpdate).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}