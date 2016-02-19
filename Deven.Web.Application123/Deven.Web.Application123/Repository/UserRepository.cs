using Deven.Web.Application123.Context;
using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Repository
{
    public interface IUserRepository:IGenericRepository<User>
    {

    }
    public class UserRepository:IUserRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(User t)
        {
            conn.Users.Add(t);
        }

        public void Delete(int id)
        {
            User s = GetById(id);
            conn.Users.Remove(s);
        }

        public void Update(User t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public User GetById(int id)
        {
            return conn.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return conn.Users.ToList();
        }
    }
}