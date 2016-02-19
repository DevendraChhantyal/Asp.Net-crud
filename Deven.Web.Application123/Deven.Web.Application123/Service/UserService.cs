using Deven.Web.Application123.Models;
using Deven.Web.Application123.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Service
{
    public interface IUserService:IGenericService<User>
    {

    }

    public class UserService:IUserService
    {
        private UserRepository uRepo = new UserRepository();
        public void Insert(User t)
        {
            uRepo.Insert(t);
        }

        public void Update(User t)
        {
            uRepo.Update(t);
        }

        public void Delete(int id)
        {
            uRepo.Delete(id);
        }

        public User GetById(int id)
        {
           return uRepo.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
           return uRepo.GetAll();
        }
    }
}