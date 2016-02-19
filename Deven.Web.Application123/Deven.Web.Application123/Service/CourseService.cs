using Deven.Web.Application123.Models;
using Deven.Web.Application123.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deven.Web.Application123.Service
{
    public interface ICourseService:IGenericService<Course>
    {

    }
    public class CourseService:ICourseService
    {
        private CourseRepository cRepo = new CourseRepository();
        public void Insert(Course t)
        {
            cRepo.Insert(t);
        }

        public void Update(Course t)
        {
            cRepo.Update(t);
        }

        public void Delete(int id)
        {
            cRepo.Delete(id);
        }

        public Course GetById(int id)
        {
            return cRepo.GetById(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return cRepo.GetAll();
        }
    }
}