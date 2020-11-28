using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Ejemplar
    {
        private int numeroEdicion;
        private string ubicacion;

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
    }
}
