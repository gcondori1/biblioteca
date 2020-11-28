using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Libro
    {
        private string isbn;
        private string autor;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public bool isEjemplares(int libroId)
        {
            Repositories.EjemplarRepository ejemplardb = new Repositories.EjemplarRepository();
            List<Ejemplar> ejemplares = ejemplardb.getEntitiesByFilters($"libroId = {libroId}");
            return true;
        }
    }
}
