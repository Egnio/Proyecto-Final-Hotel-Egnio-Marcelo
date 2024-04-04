namespace ProyectoFinalHotelPOO.FormsCliente
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUsuario.Controls.Add(this.lblClienteNombre);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(175, 75);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(874, 85);
            this.pnlUsuario.TabIndex = 8;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(106, 38);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(129, 15);
            this.lblClienteNombre.TabIndex = 1;
            this.lblClienteNombre.Text = "Marcelo Rodríguez";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(39, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnCerrarSesion);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(175, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(874, 75);
            this.pnlCliente.TabIndex = 7;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(699, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(175, 72);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblNombreSistema);
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Controls.Add(this.btnAcercaDe);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.btnHoteles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 563);
            this.panel1.TabIndex = 6;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = true;
            this.lblNombreSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.Location = new System.Drawing.Point(24, 109);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(132, 30);
            this.lblNombreSistema.TabIndex = 5;
            this.lblNombreSistema.Text = "Reserva de Hoteles\r\n        Managua\r\n";
            // 
            // btnReservar
            // 
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(0, 218);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(175, 57);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 270);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(175, 57);
            this.btnAcercaDe.TabIndex = 2;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(38, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnHoteles
            // 
            this.btnHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.Location = new System.Drawing.Point(0, 166);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(175, 57);
            this.btnHoteles.TabIndex = 0;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 563);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnHoteles;
    }
}