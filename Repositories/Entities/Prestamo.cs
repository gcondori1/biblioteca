using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class Prestamo
    {
        private int id;
        private DateTime fechaInicio;
        private int socioId;
        private int ejemplarId;

        public Prestamo(DateTime fechaInicio, int socioId, int ejemplarId)
        {
            this.fechaInicio = fechaInicio;
            this.socioId = socioId;
            this.ejemplarId = ejemplarId;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public int EjemplarId
        {
            get { return ejemplarId; }
            set { ejemplarId = value; }
        }

        public int SocioId
        {
            get { return socioId; }
            set { socioId = value; }
        }

    }
}
