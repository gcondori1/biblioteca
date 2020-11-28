using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    public class SocioRepository : IRepository<Socio>
    {
        public void create(Socio entity)
        {
            throw new NotImplementedException();
        }

        public List<Socio> getEntities()
        {
            throw new NotImplementedException();
        }

        public List<Socio> getEntitiesByFilters(string filter)
        {
            throw new NotImplementedException();
        }

        public Socio getEntityById(int id)
        {
            // mock Socio
            Socio socio = new SocioComun()
            {
                Id = id
            };
            return socio;
        }

        public void remove(Socio entity)
        {
            throw new NotImplementedException();
        }
    }
}
