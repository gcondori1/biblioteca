using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class EjemplarRepository : IRepository<Ejemplar>
    {
        List<Ejemplar> ejemplares = new List<Ejemplar>()
        {
            new Ejemplar(1, 11, "estante 1", 1),
            new Ejemplar(2, 12, "estante 2", 1),
            new Ejemplar(3, 13, "estante 3", 2),
            new Ejemplar(4, 14, "estante 2", 2),
            new Ejemplar(5, 14, "estante 4", 3),
            new Ejemplar(6, 15, "estante 1", 3),
            new Ejemplar(7, 16, "estante 3", 4),
            new Ejemplar(8, 15, "estante 3", 4),
        };

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
            return ejemplares.Where(x => x.Id == id).FirstOrDefault();
        }

        public void removeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ejemplar> getEjemplaresByLibroId(int libroId)
        {
            return ejemplares.Where(x => x.LibroId == libroId).ToList();
        }
    }
}
