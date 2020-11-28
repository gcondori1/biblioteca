using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    public class PrestamoRepository : IRepository<Prestamo>
    {
        public void create(Prestamo entity)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> getEntities()
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> getEntitiesByFilters(string filter)
        {
            return new List<Prestamo>();
        }

        public Prestamo getEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(Prestamo entity)
        {
            throw new NotImplementedException();
        }
    }
}
