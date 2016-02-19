using Deven.Web.Application123.Models;
using Deven.Web.Application123.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Service
{
    public interface IDepartmentService:IGenericService<Department>
    {

    }
    public class DepartmentService:IDepartmentService
    {
        private DepartmentRepository dRepo = new DepartmentRepository();
        public void Insert(Department t)
        {
            dRepo.Insert(t);
        }

        public void Update(Department t)
        {
            dRepo.Update(t);

        }

        public void Delete(int id)
        {
            dRepo.Delete(id);
        }

        public Department GetById(int id)
        {
            return dRepo.GetById(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return dRepo.GetAll();
        }
    }
}