using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Entities
{
    public class SocioVip: Socio
    {
        private double coutaMensual;

        public double CuotaMensual
        {
            get { return coutaMensual; }
            set { coutaMensual = value; }
        }
        public override bool isCupoDisponible()
        {
            throw new NotImplementedException();
        }
    }
}
