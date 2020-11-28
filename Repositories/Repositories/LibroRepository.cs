using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repositories
{
    public class LibroRepository : IRepository<Libro>
    {
        List<Libro> libros = new List<Libro>()
        {
               new Libro(1, "0-7645-2651-8", "autor 1", true),
               new Libro(2, "0-7645-2631-6", "autor 7", true),
               new Libro(3, "0-7645-2641-3", "autor 3", true),
               new Libro(4, "0-7645-2646-2", "autor 9", true)
        };
        public void create(Libro entity)
        {
            throw new NotImplementedException();
        }

        public List<Libro> getEntities()
        {
            return libros;
        }

        public List<Libro> getEntitiesByFilters(string filter)
        {
            throw new NotImplementedException();
        }

        public Libro getEntityById(int id)
        {
            return libros.Where(x => x.Id == id)
                .ToList()
                .FirstOrDefault();
        }

        public void removeById(int id)
        {
            throw new NotImplementedException();
        }

        public void disablePrestamos(int id)
        {
            Libro libro = libros.Where(x => x.Id == id).FirstOrDefault();
            libros.Remove(libro);
            libro.IsEjemplaresDisponibles = false;
            libros.Add(libro);
        }
    }
}
