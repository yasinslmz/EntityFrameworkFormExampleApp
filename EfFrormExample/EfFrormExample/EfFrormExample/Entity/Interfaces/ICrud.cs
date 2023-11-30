using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFrormExample.Entity.Interfaces
{
    public interface ICrud<T>
    {
        bool Add(T entity);
        T Get(int id);
        List<T> GetAll();
        bool Update(T entity,int id);
        bool Delete(int id);

    }
}
