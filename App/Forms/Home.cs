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
        public PrestamoService prestamosServ = new PrestamoService();
        public Home()
        {
            InitializeComponent();
            // test: combobox socio
            List<Item> items = new List<Item>();  
            items.Add(new Item("Socio comun", 1));
            items.Add(new Item("Socio Vip", 2));
            cbSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSocio.DisplayMember = "Name";
            cbSocio.ValueMember = "Value";
            cbSocio.DataSource = items;
            
            loadData(1);
        }

        private void loadData(int socioId)
        {
            prestamosVm = prestamosServ.getPrestamos(socioId);
            dGridPrestamos.DataSource = prestamosVm.prestamos;
            lblSocio.Text = $"{prestamosVm.socio.Nombre} {prestamosVm.socio.Apellido}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if ((int)dGridPrestamos.SelectedRows.Count == 0)
                return;
            DialogResult result1 = MessageBox.Show("¿Esta seguro que desea devolver el libro?",
                "Advertencia",
                MessageBoxButtons.YesNo);
            if(result1 == DialogResult.No)
                return;

            int prestamoIdSelected = (int)dGridPrestamos.SelectedRows[0].Cells[0].Value;
            if(!prestamosServ.removePrestamo(prestamoIdSelected))
            {
                MessageBox.Show("No es posible posible devolver el libro.");
                return;
            }
            MessageBox.Show("La devolución se realizó correctamente");
        }

        private void btnSolicitarPrestamo_Click(object sender, EventArgs e)
        {
            SolicitudLibro solicitudLibroform = new SolicitudLibro(ref prestamosServ, prestamosVm.socio);
            solicitudLibroform.Show();
        }

        private void cbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData((int)cbSocio.SelectedValue);
        }
    }
}
