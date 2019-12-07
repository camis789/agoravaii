using System;
using System.Linq;
using ApiLibrary.Context;
using ApiLibrary.Models;

namespace ApiLibrary.Repository.Class
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextBooks _context;

        public UserRepository(DbContextBooks ctx)
        {
            _context = ctx;
        }

        public void Add(User user)
        {
            user.DateCreate = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User FindEmail(string email)
        {
            return _context.Users.Where(x => x.Email == email).FirstOrDefault();
        }

        public User Auth(User user)
        {
            var userResponse = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            if (userResponse != null)
            {

                return userResponse;
            }
            else
            {
                return null;
            }

        }
    }
}