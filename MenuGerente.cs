using System;
using System.Windows.Forms;
using PrototipoProyectoPOO.Model;

namespace PrototipoProyectoPOO
{
    public partial class MenuGerente : Form
    {
        Inventario chInventario;
        ConsultarVentas chConsultarVentas;
        ConsultarReservaciones chConsultarReservaciones;
        CSetMenuG csetmain;
        public MenuGerente()
        {
            InitializeComponent();
            csetmain = new CSetMenuG();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tmrTiempo_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void lblPicture4_Click(object sender, EventArgs e)
        {

        }


        private void chInventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            chInventario = null;
        }



        private void chConsultarVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            chConsultarVentas = null;
        }

        private void MenuGerente_Load(object sender, EventArgs e)
        {
            //csetmain.setMain(this);
        }

        //---
        private void imgInv_MouseHover_1(object sender, EventArgs e)
        {
            imgInv.Visible = false;
            imgInv.Enabled = false;
            imgInvG.Enabled = true;
            imgInvG.Visible = true;
        }

        private void imgInvG_MouseLeave_1(object sender, EventArgs e)
        {
            imgInv.Visible = true;
            imgInv.Enabled = true;
            imgInvG.Enabled = false;
            imgInvG.Visible = false;
        }

        private void imgVent_MouseHover_1(object sender, EventArgs e)
        {
            imgVent.Visible = false;
            imgVent.Enabled = false;
            imgVentG.Enabled = true;
            imgVentG.Visible = true;
        }

        private void imgVentG_MouseLeave(object sender, EventArgs e)
        {
            imgVent.Visible = true;
            imgVent.Enabled = true;
            imgVentG.Enabled = false;
            imgVentG.Visible = false;
        }

        private void imgReservas_MouseHover(object sender, EventArgs e)
        {
            imgReservas.Visible = false;
            imgReservas.Enabled = false;
            imgReservasG.Enabled = true;
            imgReservasG.Visible = true;
        }

        private void imgReservasG_MouseLeave(object sender, EventArgs e)
        {
            imgReservas.Visible = true;
            imgReservas.Enabled = true;
            imgReservasG.Enabled = false;
            imgReservasG.Visible = false;
        }

        private void imgInvG_Click(object sender, EventArgs e)
        {
            //csetmain.OcultarOpciones();
            chInventario = new Inventario();
            chInventario.MdiParent = csetmain.getMain();
            chInventario.FormClosed += new FormClosedEventHandler(chInventario_FormClosed);
            this.Close();
            chInventario.Show();
        }

        private void imgVentG_Click(object sender, EventArgs e)
        {
            csetmain.OcultarOpciones();
            chConsultarVentas = new ConsultarVentas();
            chConsultarVentas.MdiParent = csetmain.getMain();
            chConsultarVentas.FormClosed += new FormClosedEventHandler(chConsultarVentas_FormClosed);
            chConsultarVentas.Show();
            this.Close();
        }

        private void imgReservasG_Click(object sender, EventArgs e)
        {
            chConsultarReservaciones = new ConsultarReservaciones();
            chConsultarReservaciones.MdiParent = csetmain.getMain();
            chConsultarReservaciones.FormClosed += new FormClosedEventHandler(chConsultarReservaciones_FormClosed);
            this.Close();
            chConsultarReservaciones.Show();
        }

        private void chConsultarReservaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            chConsultarReservaciones = null;
        }
    }
}
