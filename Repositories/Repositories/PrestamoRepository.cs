using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class PrestamoRepository : IRepository<Prestamo>
    {
        List<Prestamo> prestamos = new List<Prestamo>();

        public void create(Prestamo entity)
        {
            entity.Id = prestamos.Count + 1;
            prestamos.Add(entity);
        }

        public List<Prestamo> getEntities()
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> getEntitiesByFilters(string filter)
        {
            throw new NotImplementedException();
        }

        public Prestamo getEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public void removeById(int id)
        {
            prestamos.Remove(prestamos.Where(x => x.Id == id).FirstOrDefault());
        }
        public List<Prestamo> getPrestamosBySocio(int socioId)
        {
           return prestamos.Where(x => x.SocioId == socioId).ToList();
        }
        public List<Prestamo> getPrestamosByEjemplares(int[] ids)
        {
            return prestamos.Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}
