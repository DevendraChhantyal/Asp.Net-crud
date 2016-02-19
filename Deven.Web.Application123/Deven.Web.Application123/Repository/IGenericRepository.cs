using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deven.Web.Application123.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T t);
        void Delete(int id);
        void Update(T t);
        T GetById(int id);
        IEnumerable<T> GetAll();
        

    }
}
