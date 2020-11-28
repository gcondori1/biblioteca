using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using static Repositories.Entities.Constants.Constants;

namespace Repositories.Entities
{
    class SocioComun : Socio
    {
        public SocioComun(int id, string nombre, string apellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.MaxCantidad = (int)maximaCantidades.SocioComun;
        }

        public override bool isCupoDisponible(PrestamoRepository prestamoDb)
        {
            int cantPrestamos = prestamoDb.getPrestamosBySocio(this.Id).Count;
            if (cantPrestamos < (int)maximaCantidades.SocioComun)
                return true;
            return false;
        }
    }
}
