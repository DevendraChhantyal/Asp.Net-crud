using Deven.Web.Application123.Context;
using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Repository
{
    public interface IStaffRepository:IGenericRepository<Staff>
    {

    }
    public class StaffRepository:IStaffRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(Staff t)
        {
            conn.Staffs.Add(t);
        }

        public void Delete(int id)
        {
            Staff s = GetById(id);
            conn.Staffs.Remove(s);
        }

        public void Update(Staff t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public Staff GetById(int id)
        {
            return conn.Staffs.Find(id);
        }

        public IEnumerable<Staff> GetAll()
        {
            return conn.Staffs.ToList();
        }
    }
}