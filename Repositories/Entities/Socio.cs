using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public abstract class Socio
    {
        private int id;
        private int numeroSocio;
        private string nombre;
        private string apellido;
        private int maxCantidad;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int NumeroSocio
        {
            get { return numeroSocio; }
            set { numeroSocio = value; }
        }
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

        public abstract bool isCupoDisponible(PrestamoRepository prestamoDb);

    }
}
