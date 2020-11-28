using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Ejemplar
    {
        private int id;
        private int numeroEdicion;
        private string ubicacion;
        private int libroId;

        public Ejemplar(int id, int numeroEdicion, string ubicacion, int libroId)
        {
            this.id = id;
            this.numeroEdicion = numeroEdicion;
            this.ubicacion = ubicacion;
            this.libroId = libroId;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NumeroEdicion
        {
            get { return numeroEdicion; }
            set { numeroEdicion = value; }
        }

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public int LibroId
        {
            get { return libroId; }
            set { libroId = value; }
        }

    }
}
