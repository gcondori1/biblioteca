using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Libro
    {
        private string isbn;
        private string autor;
        private List<Ejemplar> ejemplares;

        public List<Ejemplar> Ejemplares
        {
            get { return ejemplares; }
            set { ejemplares = value; }
        }

        public string MyProperty
        {
            get { return autor; }
            set { autor = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

    }
}
