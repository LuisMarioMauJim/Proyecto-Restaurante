using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoProyectoPOO.Model;
using PrototipoProyectoPOO.Presenter;

namespace PrototipoProyectoPOO
{
    public partial class ConsultarVentas : Form
    {
        WGerente wVentas;
        DataSet dsVent;
        DataSet dsMov;
        CSetMenuG csetmain;
        MenuGerente cMenuGerente;
        public ConsultarVentas()
        {
            InitializeComponent();
            wVentas = new WGerente();
            csetmain = new CSetMenuG();
        }

        private void ConsultarVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
            cMenuGerente = new MenuGerente();
        }

        private void CargarVentas()
        {
            if (ExisteConexion())
            {
                dsVent = new DataSet();
                if (wVentas.listVentas(ref dsVent))
                {
                    dtgInventario.DataSource = dsVent.Tables[0];
                }
                else
                {
                    MessageBox.Show("No hay registro de áreas", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No hay conexion con el servidor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteConexion() //verifica la disponiblidad de la conexion
        {
            bool existeConexion = false;
            existeConexion = wVentas.ConnectionCheck();

            return existeConexion;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Any(char.IsDigit) == false && txtBuscar.Text!="")
            {
                MessageBox.Show("Ingresa un ID adecuado (número entero)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                btnDetalles.Visible = true;
                if (int.TryParse(txtBuscar.Text, out int idBuscar))
                {
                    // Filtrar por el ID entero usando una comparación directa
                    dsVent.Tables[0].DefaultView.RowFilter = $"ID = {idBuscar}";
                }
                if (txtBuscar.Text == "")
                {
                    CargarVentas();
                    btnDetalles.Visible = false;
                    dtgMovimientos.Visible = false;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            cMenuGerente = new MenuGerente();
            cMenuGerente.MdiParent = csetmain.getMain();
            cMenuGerente.FormClosed += new FormClosedEventHandler(cMenuGerente_FormClosed);
            //this.Close();
            cMenuGerente.Show();
        }

        private void cMenuGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            cMenuGerente = null;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            dtgMovimientos.Visible = true;
            dsMov = new DataSet();
            if (wVentas.listMovimientos(ref dsMov,Convert.ToInt32(txtBuscar.Text)))
            {
                dtgMovimientos.DataSource = dsMov.Tables[0];
            }
            else
            {
                MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
