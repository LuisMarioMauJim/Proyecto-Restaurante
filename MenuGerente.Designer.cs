namespace PrototipoProyectoPOO
{
    partial class MenuGerente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGerente));
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlRes = new System.Windows.Forms.Panel();
            this.imgReservas = new System.Windows.Forms.PictureBox();
            this.imgReservasG = new System.Windows.Forms.PictureBox();
            this.lblDescRes = new System.Windows.Forms.Label();
            this.lblReservacion = new System.Windows.Forms.Label();
            this.pnlVen = new System.Windows.Forms.Panel();
            this.imgVent = new System.Windows.Forms.PictureBox();
            this.imgVentG = new System.Windows.Forms.PictureBox();
            this.lblDescVent = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.pnlInv = new System.Windows.Forms.Panel();
            this.imgInv = new System.Windows.Forms.PictureBox();
            this.imgInvG = new System.Windows.Forms.PictureBox();
            this.lblDescInv = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.pnlRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReservasG)).BeginInit();
            this.pnlVen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentG)).BeginInit();
            this.pnlInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInvG)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Enabled = true;
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick_1);
            // 
            // pnlRes
            // 
            this.pnlRes.Controls.Add(this.imgReservas);
            this.pnlRes.Controls.Add(this.imgReservasG);
            this.pnlRes.Controls.Add(this.lblDescRes);
            this.pnlRes.Controls.Add(this.lblReservacion);
            this.pnlRes.Location = new System.Drawing.Point(1232, 98);
            this.pnlRes.Name = "pnlRes";
            this.pnlRes.Size = new System.Drawing.Size(346, 670);
            this.pnlRes.TabIndex = 7;
            // 
            // imgReservas
            // 
            this.imgReservas.Image = ((System.Drawing.Image)(resources.GetObject("imgReservas.Image")));
            this.imgReservas.Location = new System.Drawing.Point(61, 165);
            this.imgReservas.Name = "imgReservas";
            this.imgReservas.Size = new System.Drawing.Size(223, 207);
            this.imgReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReservas.TabIndex = 20;
            this.imgReservas.TabStop = false;
            this.imgReservas.MouseHover += new System.EventHandler(this.imgReservas_MouseHover);
            // 
            // imgReservasG
            // 
            this.imgReservasG.Enabled = false;
            this.imgReservasG.Image = ((System.Drawing.Image)(resources.GetObject("imgReservasG.Image")));
            this.imgReservasG.Location = new System.Drawing.Point(29, 140);
            this.imgReservasG.Name = "imgReservasG";
            this.imgReservasG.Size = new System.Drawing.Size(295, 269);
            this.imgReservasG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReservasG.TabIndex = 27;
            this.imgReservasG.TabStop = false;
            this.imgReservasG.Visible = false;
            this.imgReservasG.Click += new System.EventHandler(this.imgReservasG_Click);
            this.imgReservasG.MouseLeave += new System.EventHandler(this.imgReservasG_MouseLeave);
            // 
            // lblDescRes
            // 
            this.lblDescRes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescRes.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescRes.Location = new System.Drawing.Point(28, 446);
            this.lblDescRes.Name = "lblDescRes";
            this.lblDescRes.Size = new System.Drawing.Size(256, 212);
            this.lblDescRes.TabIndex = 26;
            this.lblDescRes.Text = "Permite obtener información detallada sobre las reservas realizadas en el sistema" +
    ", para gestionar la disponibilidad y verificar detalles de las reservaciones.";
            // 
            // lblReservacion
            // 
            this.lblReservacion.Font = new System.Drawing.Font("Rockwell", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservacion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblReservacion.Location = new System.Drawing.Point(25, 10);
            this.lblReservacion.Name = "lblReservacion";
            this.lblReservacion.Size = new System.Drawing.Size(217, 103);
            this.lblReservacion.TabIndex = 4;
            this.lblReservacion.Text = "Consultar Reservas";
            // 
            // pnlVen
            // 
            this.pnlVen.Controls.Add(this.imgVent);
            this.pnlVen.Controls.Add(this.imgVentG);
            this.pnlVen.Controls.Add(this.lblDescVent);
            this.pnlVen.Controls.Add(this.lblVentas);
            this.pnlVen.Location = new System.Drawing.Point(821, 98);
            this.pnlVen.Name = "pnlVen";
            this.pnlVen.Size = new System.Drawing.Size(361, 670);
            this.pnlVen.TabIndex = 6;
            // 
            // imgVent
            // 
            this.imgVent.Image = ((System.Drawing.Image)(resources.GetObject("imgVent.Image")));
            this.imgVent.Location = new System.Drawing.Point(68, 165);
            this.imgVent.Name = "imgVent";
            this.imgVent.Size = new System.Drawing.Size(220, 207);
            this.imgVent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVent.TabIndex = 20;
            this.imgVent.TabStop = false;
            this.imgVent.MouseHover += new System.EventHandler(this.imgVent_MouseHover_1);
            // 
            // imgVentG
            // 
            this.imgVentG.Enabled = false;
            this.imgVentG.Image = ((System.Drawing.Image)(resources.GetObject("imgVentG.Image")));
            this.imgVentG.Location = new System.Drawing.Point(36, 140);
            this.imgVentG.Name = "imgVentG";
            this.imgVentG.Size = new System.Drawing.Size(291, 269);
            this.imgVentG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVentG.TabIndex = 27;
            this.imgVentG.TabStop = false;
            this.imgVentG.Visible = false;
            this.imgVentG.Click += new System.EventHandler(this.imgVentG_Click);
            this.imgVentG.MouseLeave += new System.EventHandler(this.imgVentG_MouseLeave);
            // 
            // lblDescVent
            // 
            this.lblDescVent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescVent.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescVent.Location = new System.Drawing.Point(31, 446);
            this.lblDescVent.Name = "lblDescVent";
            this.lblDescVent.Size = new System.Drawing.Size(257, 192);
            this.lblDescVent.TabIndex = 26;
            this.lblDescVent.Text = "Ingresa para obtener información detallada sobre los productos vendidos en una tr" +
    "ansacción específica.";
            // 
            // lblVentas
            // 
            this.lblVentas.Font = new System.Drawing.Font("Rockwell", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblVentas.Location = new System.Drawing.Point(36, 10);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(213, 103);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Consultar Ventas";
            // 
            // pnlInv
            // 
            this.pnlInv.Controls.Add(this.imgInv);
            this.pnlInv.Controls.Add(this.imgInvG);
            this.pnlInv.Controls.Add(this.lblDescInv);
            this.pnlInv.Controls.Add(this.lblInventario);
            this.pnlInv.Location = new System.Drawing.Point(384, 98);
            this.pnlInv.Name = "pnlInv";
            this.pnlInv.Size = new System.Drawing.Size(363, 670);
            this.pnlInv.TabIndex = 5;
            // 
            // imgInv
            // 
            this.imgInv.Image = ((System.Drawing.Image)(resources.GetObject("imgInv.Image")));
            this.imgInv.Location = new System.Drawing.Point(71, 165);
            this.imgInv.Name = "imgInv";
            this.imgInv.Size = new System.Drawing.Size(210, 207);
            this.imgInv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInv.TabIndex = 20;
            this.imgInv.TabStop = false;
            this.imgInv.MouseHover += new System.EventHandler(this.imgInv_MouseHover_1);
            // 
            // imgInvG
            // 
            this.imgInvG.Enabled = false;
            this.imgInvG.Image = ((System.Drawing.Image)(resources.GetObject("imgInvG.Image")));
            this.imgInvG.Location = new System.Drawing.Point(39, 140);
            this.imgInvG.Name = "imgInvG";
            this.imgInvG.Size = new System.Drawing.Size(283, 269);
            this.imgInvG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInvG.TabIndex = 27;
            this.imgInvG.TabStop = false;
            this.imgInvG.Visible = false;
            this.imgInvG.Click += new System.EventHandler(this.imgInvG_Click);
            this.imgInvG.MouseLeave += new System.EventHandler(this.imgInvG_MouseLeave_1);
            // 
            // lblDescInv
            // 
            this.lblDescInv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescInv.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescInv.Location = new System.Drawing.Point(34, 446);
            this.lblDescInv.Name = "lblDescInv";
            this.lblDescInv.Size = new System.Drawing.Size(261, 212);
            this.lblDescInv.TabIndex = 26;
            this.lblDescInv.Text = "Permite administrar y supervisar eficientemente los niveles de stock, el suminist" +
    "ro de productos y la disponibilidad de recursos dentro del sistema. ";
            // 
            // lblInventario
            // 
            this.lblInventario.Font = new System.Drawing.Font("Rockwell", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblInventario.Location = new System.Drawing.Point(25, 10);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(279, 127);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "Gestionar    Inventario";
            // 
            // MenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1855, 936);
            this.Controls.Add(this.pnlRes);
            this.Controls.Add(this.pnlVen);
            this.Controls.Add(this.pnlInv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuGerente";
            this.Text = "MenuGerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuGerente_Load);
            this.pnlRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReservasG)).EndInit();
            this.pnlVen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentG)).EndInit();
            this.pnlInv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInvG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.Panel pnlRes;
        private System.Windows.Forms.PictureBox imgReservas;
        private System.Windows.Forms.PictureBox imgReservasG;
        private System.Windows.Forms.Label lblDescRes;
        private System.Windows.Forms.Label lblReservacion;
        private System.Windows.Forms.Panel pnlVen;
        private System.Windows.Forms.PictureBox imgVent;
        private System.Windows.Forms.PictureBox imgVentG;
        private System.Windows.Forms.Label lblDescVent;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Panel pnlInv;
        private System.Windows.Forms.PictureBox imgInv;
        private System.Windows.Forms.PictureBox imgInvG;
        private System.Windows.Forms.Label lblDescInv;
        private System.Windows.Forms.Label lblInventario;
    }
}

