using Deven.Web.Application123.Context;
using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Repository
{
    public interface IStudentRepository:IGenericRepository<Student>
    {

    }
    public class StudentRepository:IStudentRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(Student t)
        {
            conn.Students.Add(t);
        }

        public void Delete(int id)
        {
            Student s = GetById(id);
            conn.Students.Remove(s);
          
        }

        public void Update(Student t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public Student GetById(int id)
        {
            return conn.Students.Find(id);
        }


        public IEnumerable<Student> GetAll()
        {
            return conn.Students.ToList();
        }
    }
}