using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_PrototipoProyectoPOO.Model;

namespace PrototipoProyectoPOO.Model
{
    internal class CSetMenuG
    {
        public static Form Main { get; set; }
        public CSetMenuG() { }

        public void setMain(Form main)
        {
            Main = main;
        }

        public Form getMain()
        {
            return Main;
        }

        public void OcultarOpciones()
        {
            Main.IsMdiContainer= true;
            foreach (Control c in Main.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }
        }
        public void MostrarOpciones()
        {
            Main.IsMdiContainer = false;
            foreach (Control c in Main.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = true;
                }
            }
        }
    }
}
