using Deven.Web.Application123.Models;
using Deven.Web.Application123.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Service
{
    public interface IStaffService:IGenericService<Staff>
    {

    }
    public class StaffService:IStaffService
    {
        private StaffRepository staffRepo = new StaffRepository();
        public void Insert(Staff t)
        {
            staffRepo.Insert(t);
        }

        public void Update(Staff t)
        {
            staffRepo.Update(t);
        }

        public void Delete(int id)
        {
            staffRepo.Delete(id);
        }

        public Staff GetById(int id)
        {
            return staffRepo.GetById(id);
        }

        public IEnumerable<Staff> GetAll()
        {
            return staffRepo.GetAll();
        }
    }
}