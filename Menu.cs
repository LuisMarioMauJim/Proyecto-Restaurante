using System;
using System.Windows.Forms;
using PrototipoProyectoPOO.Model;

namespace PrototipoProyectoPOO
{
    public partial class Menu : Form
    {
        MenuGerente chMenuGerente;
        CSetMenuG csetmain;
        public Menu()
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
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void lblPicture4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //funcion solo para probar el modulo de gerente
            chMenuGerente = new MenuGerente();
            chMenuGerente.MdiParent = this;
            chMenuGerente.FormClosed += new FormClosedEventHandler(chMenuGerente_FormClosed);
            chMenuGerente.Show();
        }

        private void chMenuGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            chMenuGerente = null;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            csetmain.setMain(this);
        }
    }
}
