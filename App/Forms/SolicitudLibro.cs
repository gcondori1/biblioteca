using Repositories.Entities;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class SolicitudLibro : Form
    {
        PrestamoService prestamosServ;
        public Socio socio;
        public SolicitudLibro(ref PrestamoService prestServ, Socio socioSelected)
        {
            prestamosServ = prestServ;
            socio = socioSelected;
            InitializeComponent();
            cbLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            loadData(prestamosServ);
        }

        private void loadData(PrestamoService prestamosServ)
        {
            List<Libro> libros = prestamosServ.getLibros();
            cbLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLibros.DisplayMember = "Name";
            cbLibros.ValueMember = "Value";
            cbLibros.DataSource = libros.Select(x => new Item(x.ISBN, x.Id)).ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            int libroSelected = (int)cbLibros.SelectedValue;
            if (!prestamosServ.isEjemplaresLibro(libroSelected))
            {
                MessageBox.Show("No hay ejemplares disponibles del libro seleccionado");
                return;
            }
            if (!prestamosServ.savePrestamo(socio.Id, libroSelected))
            {
                MessageBox.Show("No es posible realizar el prestamos porque no tiene cupos disponibles");
                return;
            }
            MessageBox.Show("El prestamo se realizó correctamente");

        }
    }
}
