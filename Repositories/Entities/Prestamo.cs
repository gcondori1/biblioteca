using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Prestamo
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;

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
