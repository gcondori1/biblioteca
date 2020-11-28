using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Models.ViewModels;
using Repositories.Repositories;

namespace Services.Services
{
    public class PrestamoService
    {
        public PrestamoListViewModel getPrestamos(int socioId)
        {
            PrestamoRepository prestamoDb = new PrestamoRepository();
            SocioRepository socioDb = new SocioRepository();

            return new PrestamoListViewModel()
            {
                socio = socioDb.getEntityById(socioId),
                prestamos = prestamoDb.getEntitiesByFilters($"socioId = {socioId}")
            };
        }
        public bool savePrestamo(PrestamoViewModel prestamoVm)
        {
            try
            {
                PrestamoRepository prestamoDb = new PrestamoRepository();
                prestamoDb.create(prestamoVm.prestamo);
                return true;
            } catch
            {
                return false;
            }
        }
        public bool isEjemplaresLibro(int libroId)
        {
            Libro libro = new Libro();
            return libro.isEjemplares(libroId);
        }
    }
}
