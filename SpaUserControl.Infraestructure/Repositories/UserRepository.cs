using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Data;
using System;
using System.Linq;

namespace SpaUserControl.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDataContext context;

        public UserRepository(AppDataContext context)
        {
            this.context = context;
        }

        public void Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void Delete(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public User Get(string email)
        {
            return context.Users.FirstOrDefault(user => user.Email.ToLower() == email.ToLower());
        }

        public User Get(Guid id)
        {
            return context.Users.FirstOrDefault(user => user.Id == id);
        }

        public void Update(User user)
        {
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
