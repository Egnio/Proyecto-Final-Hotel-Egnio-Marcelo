namespace ProyectoFinalHotelPOO.FormsCliente
{
    partial class FrmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNuevaReservacion = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtCodigoDeCliente = new System.Windows.Forms.TextBox();
            this.lblCódigoDeCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNúmeroTelefónico = new System.Windows.Forms.Label();
            this.txtNúmeroTelefónico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtCorreoElectrónico = new System.Windows.Forms.TextBox();
            this.LblIngresar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(317, 328);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(589, 180);
            this.dgvClientes.TabIndex = 44;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlUsuario.Controls.Add(this.lblClienteNombre);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(175, 75);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(872, 85);
            this.pnlUsuario.TabIndex = 62;
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
            this.pnlCliente.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlCliente.Controls.Add(this.btnCerrarSesion);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(175, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(872, 75);
            this.pnlCliente.TabIndex = 61;
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
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.BtnNuevaReservacion);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.lblNombreSistema);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.btnAcercaDe);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 547);
            this.panel1.TabIndex = 60;
            // 
            // BtnNuevaReservacion
            // 
            this.BtnNuevaReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaReservacion.Location = new System.Drawing.Point(0, 269);
            this.BtnNuevaReservacion.Name = "BtnNuevaReservacion";
            this.BtnNuevaReservacion.Size = new System.Drawing.Size(175, 57);
            this.BtnNuevaReservacion.TabIndex = 7;
            this.BtnNuevaReservacion.Text = "Regresar";
            this.BtnNuevaReservacion.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(0, 162);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(175, 57);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            // BtnEliminar
            // 
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(0, 218);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(175, 57);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 595);
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
            // txtCodigoDeCliente
            // 
            this.txtCodigoDeCliente.Location = new System.Drawing.Point(362, 234);
            this.txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            this.txtCodigoDeCliente.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoDeCliente.TabIndex = 64;
            // 
            // lblCódigoDeCliente
            // 
            this.lblCódigoDeCliente.AutoSize = true;
            this.lblCódigoDeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoDeCliente.Location = new System.Drawing.Point(359, 218);
            this.lblCódigoDeCliente.Name = "lblCódigoDeCliente";
            this.lblCódigoDeCliente.Size = new System.Drawing.Size(123, 15);
            this.lblCódigoDeCliente.TabIndex = 63;
            this.lblCódigoDeCliente.Text = "Código de cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(552, 234);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 66;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(549, 218);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 65;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(723, 218);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(70, 15);
            this.lblApellidos.TabIndex = 67;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(726, 234);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(137, 20);
            this.txtApellidos.TabIndex = 68;
            // 
            // lblNúmeroTelefónico
            // 
            this.lblNúmeroTelefónico.AutoSize = true;
            this.lblNúmeroTelefónico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroTelefónico.Location = new System.Drawing.Point(461, 272);
            this.lblNúmeroTelefónico.Name = "lblNúmeroTelefónico";
            this.lblNúmeroTelefónico.Size = new System.Drawing.Size(129, 15);
            this.lblNúmeroTelefónico.TabIndex = 69;
            this.lblNúmeroTelefónico.Text = "Número telefónico:";
            // 
            // txtNúmeroTelefónico
            // 
            this.txtNúmeroTelefónico.Location = new System.Drawing.Point(464, 288);
            this.txtNúmeroTelefónico.Name = "txtNúmeroTelefónico";
            this.txtNúmeroTelefónico.Size = new System.Drawing.Size(137, 20);
            this.txtNúmeroTelefónico.TabIndex = 70;
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(635, 272);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(130, 15);
            this.lblCorreoElectrónico.TabIndex = 71;
            this.lblCorreoElectrónico.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectrónico
            // 
            this.txtCorreoElectrónico.Location = new System.Drawing.Point(638, 288);
            this.txtCorreoElectrónico.Name = "txtCorreoElectrónico";
            this.txtCorreoElectrónico.Size = new System.Drawing.Size(137, 20);
            this.txtCorreoElectrónico.TabIndex = 72;
            // 
            // LblIngresar
            // 
            this.LblIngresar.AutoSize = true;
            this.LblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngresar.Location = new System.Drawing.Point(393, 180);
            this.LblIngresar.Name = "LblIngresar";
            this.LblIngresar.Size = new System.Drawing.Size(423, 16);
            this.LblIngresar.TabIndex = 73;
            this.LblIngresar.Text = "Ingrese alguno de los siguientes datos para buscar reserva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 26);
            this.label1.TabIndex = 74;
            this.label1.Text = "*La siguiente información será utilizada con el fin de establecer contacto \r\n  en" +
    "tre el cliente y el hotel seleccionado y demás acciones relacionadas.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1047, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblIngresar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblNúmeroTelefónico);
            this.Controls.Add(this.txtNúmeroTelefónico);
            this.Controls.Add(this.lblCorreoElectrónico);
            this.Controls.Add(this.txtCorreoElectrónico);
            this.Controls.Add(this.txtCodigoDeCliente);
            this.Controls.Add(this.lblCódigoDeCliente);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNuevaReservacion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtCodigoDeCliente;
        private System.Windows.Forms.Label lblCódigoDeCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNúmeroTelefónico;
        private System.Windows.Forms.TextBox txtNúmeroTelefónico;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtCorreoElectrónico;
        private System.Windows.Forms.Label LblIngresar;
        private System.Windows.Forms.Label label1;
    }
}