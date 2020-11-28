using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    class LibroRepository : IRepository<Libro>
    {
        public void create(Libro entity)
        {
            throw new NotImplementedException();
        }

        public List<Libro> getEntities()
        {
            List<Libro> libros = new List<Libro>();
            return libros;
        }

        public Libro getEntityById(int id)
        {
            Libro libro = new Libro();
            return libro;
        }

        public void remove(Libro entity)
        {
            throw new NotImplementedException();
        }
    }
}
