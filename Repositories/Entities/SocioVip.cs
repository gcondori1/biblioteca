using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Entities.Constants.Constants;

namespace Repositories.Entities
{
    public class SocioVip: Socio
    {
        private double coutaMensual;

        public SocioVip(int id, string nombre, string apellido, double coutaMensual)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.MaxCantidad = (int)maximaCantidades.SocioVip;
            this.coutaMensual = coutaMensual;
        }

        public double CuotaMensual
        {
            get { return coutaMensual; }
            set { coutaMensual = value; }
        }
        public override bool isCupoDisponible(PrestamoRepository prestamoDb)
        {
            int cantPrestamos = prestamoDb.getPrestamosBySocio(this.Id).Count;
            if (cantPrestamos < (int)maximaCantidades.SocioVip)
                return true;
            return false;
        }
    }
}
