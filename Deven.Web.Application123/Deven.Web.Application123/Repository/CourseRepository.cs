using Deven.Web.Application123.Context;
using Deven.Web.Application123.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Repository
{
    public interface ICourseRepository:IGenericRepository<Course>
    {

    }
    public class CourseRepository:ICourseRepository
    {
        private AppDbConnection conn = new AppDbConnection();
        public void Insert(Course t)
        {
            conn.Courses.Add(t);
        }

        public void Delete(int id)
        {
            Course c = GetById(id);
            conn.Courses.Remove(c);
        }

        public void Update(Course t)
        {
            conn.Entry(t).State = EntityState.Modified;
        }

        public Course GetById(int id)
        {
            return conn.Courses.Find(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return conn.Courses.ToList();
        }
    }
}