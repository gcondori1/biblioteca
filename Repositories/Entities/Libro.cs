using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Libro
    {
        private int id;
        private string isbn;
        private string autor;
        private bool isEjemplaresDisponibles;

        public Libro(int id, string isbn, string autor, bool isEjemplaresDisponibles)
        {
            this.id = id;
            this.isbn = isbn;
            this.autor = autor;
            this.IsEjemplaresDisponibles = isEjemplaresDisponibles;
        }

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
        public bool IsEjemplaresDisponibles
        {
            get { return isEjemplaresDisponibles; }
            set { isEjemplaresDisponibles = value; }
        }
        public bool isEjemplares()
        {
            return IsEjemplaresDisponibles;
        }
    }
}
