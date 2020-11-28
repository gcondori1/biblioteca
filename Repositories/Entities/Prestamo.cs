using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Prestamo
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

    }
}
