using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Models.ViewModels;
using Repositories.Repositories;
using System.Linq;

namespace Services.Services
{
    public class PrestamoService
    {
        PrestamoRepository prestamoDb = new PrestamoRepository();
        SocioRepository socioDb = new SocioRepository();
        LibroRepository libroDb = new LibroRepository();
        EjemplarRepository ejemplarDb = new EjemplarRepository();

        public PrestamoListViewModel getPrestamos(int socioId)
        {
            return new PrestamoListViewModel()
            {
                socio = socioDb.getEntityById(socioId),
                prestamos = prestamoDb.getPrestamosBySocio(socioId)
            };
        }
        public bool savePrestamo(int socioId, int libroId)
        {
            Socio socio = socioDb.getEntityById(socioId);
            if (!socio.isCupoDisponible(prestamoDb))
                return false;

            List<Ejemplar> ejemplares = ejemplarDb.getEjemplaresByLibroId(libroId);

            List<Prestamo> prestamos = prestamoDb.getPrestamosByEjemplares(ejemplares.Select(x => x.Id)
                .ToArray());

            if (ejemplares.Count == prestamos.Count)
                return false;

            int[] idsPrestamos = prestamos.Select(x => x.Id).ToArray();

            Ejemplar ejemplar = ejemplares.Where(x => !idsPrestamos.Contains(x.Id)).FirstOrDefault();

            Prestamo newPrestamo = new Prestamo(DateTime.Now, socioId, ejemplar.Id);
            prestamoDb.create(newPrestamo);

            if (ejemplares.Count == prestamos.Count + 1)
                libroDb.disablePrestamos(libroId);
                
            return true;
        }
        public bool isEjemplaresLibro(int libroId)
        {
            return libroDb.getEntityById(libroId).isEjemplares();
        }

        public List<Ejemplar> getEjemplaresByLibroId(int libroId)
        {
            return ejemplarDb.getEjemplaresByLibroId(libroId);
        }

        public List<Libro> getLibros()
        {
            return libroDb.getEntities();
        }

        public bool removePrestamo(int prestamoId)
        {
            try
            {
                prestamoDb.removeById(prestamoId);
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
