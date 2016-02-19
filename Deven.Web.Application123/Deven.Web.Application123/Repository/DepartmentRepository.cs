using Deven.Web.Application123.Context;
using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Repository
{
    public interface IDepartmentRepository:IGenericRepository<Department>
    {

    }
    public class DepartmentRepository:IDepartmentRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(Department t)
        {
            conn.Departments.Add(t);
            
        }

        public void Delete(int id)
        {
            Department d = GetById(id);
            conn.Departments.Remove(d);

        }

        public void Update(Department t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public Department GetById(int id)
        {
            return conn.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return conn.Departments.ToList();
        }
    }
}