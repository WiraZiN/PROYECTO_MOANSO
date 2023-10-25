using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MOANSO
{
    public partial class MantenedorPrenda : Form
    {
        public MantenedorPrenda()
        {
            InitializeComponent();
            listaPrenda();
            txtID.Enabled = false;
            cbkestMaterial.Enabled = true;
        }

        public void listaPrenda()
        {
            dgvMaterialPrenda.DataSource = datMatPrenda.Instancia.ListarPrenda();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMatPrenda p = new entMatPrenda();
                p.Material = txtMaterialPrenda.Text.Trim();
                p.estMaterial = cbkestMaterial.Checked;
                logMatPrenda.Instancia.InsertarMatPrenda(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaPrenda();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMatPrenda p = new entMatPrenda();
                p.idMatPrenda = int.Parse(txtID.Text.Trim());
                p.Material = txtMaterialPrenda.Text.Trim();
                p.estMaterial = cbkestMaterial.Checked;
                logMatPrenda.Instancia.ModificarMatPrenda(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaPrenda();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMatPrenda p = new entMatPrenda();
                p.idMatPrenda = int.Parse(txtID.Text.Trim());
                cbkestMaterial.Checked = false;
                p.estMaterial = cbkestMaterial.Checked;
                logMatPrenda.Instancia.DeshabilitarMatPrenda(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            listaPrenda();
        }
    }
}
