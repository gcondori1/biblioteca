using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Services;
using Models.ViewModels;
using App.Forms;

namespace examen_ingreso.Forms
{
    public partial class Home : Form
    {
        public PrestamoListViewModel prestamosVm;
        public PrestamoService prestamosServ;
        public Home()
        {
            InitializeComponent();
            getData(1);
        }

        private void getData(int socioId)
        {
            prestamosServ = new PrestamoService();
            prestamosVm = prestamosServ.getPrestamos(socioId);
            dGridPrestamos.DataSource = prestamosVm.prestamos;
            lblSocio.Text = $"{prestamosVm.socio.Nombre} {prestamosVm.socio.Nombre}";
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            SolicitudLibro solicitudLibroform = new SolicitudLibro(prestamosVm.socio.Id);
            solicitudLibroform.Show();
        }
    }
}
