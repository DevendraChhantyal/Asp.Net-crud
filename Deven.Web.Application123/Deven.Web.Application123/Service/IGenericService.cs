using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deven.Web.Application123.Service
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
