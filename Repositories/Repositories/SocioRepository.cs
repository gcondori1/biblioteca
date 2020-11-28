using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    public class SocioRepository : IRepository<Socio>
    {
        Socio socio;

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
            // Mock Socios
            if (id == 1)
                socio = new SocioComun(id, "Juan", "Comun");
            else 
                socio = new SocioVip(id, "Pepe", "Vip", 100);
            
            return socio;
        }

        public void removeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
