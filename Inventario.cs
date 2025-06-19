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
    public partial class Inventario : Form
    {
        DataSet dsInv;
        CSetMenuG csetmain;
        WGerente wInventarios;
        MenuGerente cMenuGerente;
        public Inventario()
        {
            InitializeComponent();
            csetmain = new CSetMenuG();
            wInventarios = new WGerente();
            cMenuGerente = new MenuGerente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            EditarDatos();
            btnEliminarReg.Visible = false;
            btnActualizarReg.Visible = false;
            btnRegistrar.Visible = true;
            lblAccion.Text = "Añadir:";
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

        private void CargarSuministros()
        {
            if (ExisteConexion())
            {
                dsInv = new DataSet();
                if (wInventarios.listSuministros(ref dsInv))
                {
                    dtgInventario.DataSource = dsInv.Tables[0];
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
            existeConexion = wInventarios.ConnectionCheck();

            return existeConexion;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarSuministros();
            rdbNombre.Checked = true;
            OcultarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rdbClave.Checked == true)
            {
                if (int.TryParse(txtBuscar.Text, out int idBuscar))
                {
                    // Filtrar por el ID entero usando una comparación directa
                    dsInv.Tables[0].DefaultView.RowFilter = $"ID = {idBuscar}";
                }
                else
                if (txtBuscar.Text != "")
                {
                    // Manejar el caso en que el texto de búsqueda no es un número válido
                    dsInv.Tables[0].DefaultView.RowFilter = string.Empty; // O manejar el error según sea necesario
                    MessageBox.Show("Por favor, ingrese un número válido para buscar por ID.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CargarSuministros();
                }
                // Actualizar la fuente de datos del DataGridView
                dtgInventario.DataSource = dsInv.Tables[0].DefaultView;
            }
            else
                if (rdbNombre.Checked == true)
            {
                dsInv.Tables[0].DefaultView.RowFilter = "Suministro like '%" + txtBuscar.Text + "%'";
                dtgInventario.DataSource = dsInv.Tables[0].DefaultView;
            }
        }

        private void Limpiar()
        {
            txtSuministro.Text = string.Empty;
            txtId.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void OcultarDatos()
        {
            pnlDatos.Visible = false;
            dtgInventario.Size = new System.Drawing.Size(981, 377);
        }

        private void MostrarDatos()
        {
            pnlDatos.Visible = true;
            dtgInventario.Size = new System.Drawing.Size(541, 377);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            limpiarValidacion();
            if (ValidacionRequeridos())
            {
                CInventarios nuevo = new CInventarios();
                {
                    nuevo.Inv_Suministro = txtSuministro.Text;
                    nuevo.Inv_Cantidad = Convert.ToInt32(txtCantidad.Text);
                    nuevo.Inv_Descripcion = txtDescripcion.Text;
                };
                if (wInventarios.insertSuministro(nuevo))
                {
                    MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarSuministros();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Registro fallido, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            EditarDatos();
            btnEliminarReg.Visible = true;
            btnActualizarReg.Visible = false;
            btnRegistrar.Visible = false;
            lblAccion.Text = "Eliminar:";
            Limpiar();
        }

        private void btnEliminarReg_Click(object sender, EventArgs e)
        {
            if(txtId.Text!="")
            {
                DialogResult resp = MessageBox.Show("¿Desea eliminar el suministro " + txtSuministro.Text + " con clave: " + txtId.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resp == DialogResult.Yes)
                {
                    CInventarios eliminar = new CInventarios();
                    {
                        eliminar.Inv_Pk = Convert.ToInt32(txtId.Text);
                    }
                    if (wInventarios.deleteSuministro(eliminar))
                    {
                        MessageBox.Show("Eliminación exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarSuministros();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Eliminación fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un registro para actualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dtgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnEliminarReg.Visible == true || btnActualizarReg.Visible == true)
            {
                DataGridViewRow fila = dtgInventario.CurrentRow;
                txtId.Text = fila.Cells[0].Value.ToString();
                txtSuministro.Text = fila.Cells[1].Value.ToString();
                txtCantidad.Text = fila.Cells[2].Value.ToString();
                txtDescripcion.Text = fila.Cells[3].Value.ToString();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            OcultarDatos();
        }

        private void btnActualizarReg_Click(object sender, EventArgs e)
        {
            if(txtId.Text!="")
            {
                limpiarValidacion();
                if (ValidacionRequeridos())
                {
                    CInventarios actualizar = new CInventarios();
                    {
                        actualizar.Inv_Pk = Convert.ToInt32(txtId.Text);
                        actualizar.Inv_Suministro = txtSuministro.Text;
                        actualizar.Inv_Cantidad = Convert.ToInt32(txtCantidad.Text);
                        actualizar.Inv_Descripcion = txtDescripcion.Text;
                    };
                    if (wInventarios.updateSuministro(actualizar))
                    {
                        MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarSuministros();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Actualización fallida, intente más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else
                {

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            EditarDatos();
            btnEliminarReg.Visible = false;
            btnActualizarReg.Visible = true;
            btnRegistrar.Visible = false;
            lblAccion.Text = "Registrar:";
        }

        public bool ValidacionRequeridos()
        {
            bool esRequerido = true;
            if (string.IsNullOrEmpty(txtSuministro.Text))
            {
                errorProvider.SetError(txtSuministro, "Requerido");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || txtCantidad.Text.Any(char.IsDigit) == false)
            {
                errorProvider.SetError(txtCantidad, "Requerido un número entero");
                esRequerido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "Requerido");
                esRequerido = false;
            }
            return esRequerido;
        }

        private void limpiarValidacion()
        {
            errorProvider.SetError(txtSuministro, null);
            errorProvider.SetError(txtCantidad, null);
            errorProvider.SetError(txtDescripcion, null);
        }

        private void tls_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EditarDatos()
        {
            if (btnEliminarReg.Visible == false)
            {
                txtSuministro.ReadOnly=true;
                txtCantidad.ReadOnly=true;
                txtDescripcion.ReadOnly = true;
            }
            else
            {
                txtSuministro.ReadOnly = false;
                txtCantidad.ReadOnly = false;
                txtDescripcion.ReadOnly = false;
            }
        }
    }
}
