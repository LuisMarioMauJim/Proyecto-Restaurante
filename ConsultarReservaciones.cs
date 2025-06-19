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
    public partial class ConsultarReservaciones : Form
    {
        WGerente wReservas;
        DataSet dsRes;
        CSetMenuG csetmain;
        MenuGerente cMenuGerente;
        public ConsultarReservaciones()
        {
            InitializeComponent();
            wReservas = new WGerente();
            csetmain = new CSetMenuG();
        }

        private void ConsultarReservaciones_Load(object sender, EventArgs e)
        {
            CargarReservaciones();
            rdbFecha.Checked = true;
        }

        private void CargarReservaciones()
        {
            if (ExisteConexion())
            {
                dsRes = new DataSet();
                if (wReservas.listReservas(ref dsRes))
                {
                    dtgInventario.DataSource = dsRes.Tables[0];
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
            existeConexion = wReservas.ConnectionCheck();

            return existeConexion;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            // Filtrar las filas donde la fecha es exactamente igual a la seleccionada (sin tener en cuenta la hora)
            dsRes.Tables[0].DefaultView.RowFilter = $"Fecha >= #{fechaSeleccionada:yyyy-MM-dd}# AND Fecha < #{fechaSeleccionada.AddDays(1):yyyy-MM-dd}#";

            dtgInventario.DataSource = dsRes.Tables[0].DefaultView;
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            CargarReservaciones();
            if(rdbCliente.Checked == true)
            {
                txtCliente.Enabled = true;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                txtCliente.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            CargarReservaciones();
            if (rdbFecha.Checked == true)
            {
                txtCliente.Enabled = false;
                dateTimePicker1.Enabled = true;
            }
            else
            {
                txtCliente.Enabled = true;
                dateTimePicker1.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarReservaciones();
            btnCancelar.Visible = false;
            txtCliente.Text = string.Empty;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            btnCancelar.Visible=true;
            dsRes.Tables[0].DefaultView.RowFilter = "Cliente like '%" + txtCliente.Text + "%'";
            dtgInventario.DataSource = dsRes.Tables[0].DefaultView;
        }
    }
}
