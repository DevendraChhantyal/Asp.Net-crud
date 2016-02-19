using Deven.Web.Application123.Models;
using Deven.Web.Application123.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Service
{
    public interface IStudentService:IGenericService<Student>
    {

    }
    public class StudentService:IStudentService
    {
        private StudentRepository sRepo = new StudentRepository();
        public void Insert(Student t)
        {
            sRepo.Insert(t);
        }

        public void Update(Student t)
        {
            sRepo.Update(t);
        }

        public void Delete(int id)
        {
            sRepo.Delete(id);
        }

        public Student GetById(int id)
        {
            return sRepo.GetById(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return sRepo.GetAll();
        }
    }
}