using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    public class EjemplarRepository : IRepository<Ejemplar>
    {
        public void create(Ejemplar entity)
        {
            throw new NotImplementedException();
        }

        public List<Ejemplar> getEntities()
        {
            throw new NotImplementedException();
        }

        public List<Ejemplar> getEntitiesByFilters(string filter)
        {
            throw new NotImplementedException();
        }

        public Ejemplar getEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(Ejemplar entity)
        {
            throw new NotImplementedException();
        }
    }
}
