using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public abstract class Socio
    {
        private int idSocio;
        private string nombre;
        private string apellido;
        private int maxCantidad;

        public int MaxCantidad
        {
            get { return maxCantidad; }
            set { maxCantidad = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int IdSocio
        {
            get { return idSocio; }
            set { idSocio = value; }
        }

        public abstract bool isCupoDisponible();

    }
}
