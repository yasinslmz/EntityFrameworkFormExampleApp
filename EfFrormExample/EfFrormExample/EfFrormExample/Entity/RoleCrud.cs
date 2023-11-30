using EfFrormExample.Entity.Interfaces;
using EfFrormExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFrormExample.Entity
{
    public class RoleCrud : ICrud<Role>
    {
        DataContext db=new DataContext();
        public bool Add(Role entity)
        {
            if(entity != null && !String.IsNullOrWhiteSpace(entity.Name))
            {
                db.Role.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Role Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Role entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
