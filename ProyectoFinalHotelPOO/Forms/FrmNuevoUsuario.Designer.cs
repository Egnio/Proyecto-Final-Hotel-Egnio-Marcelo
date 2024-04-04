namespace ProyectoFinalHotelPOO.Forms
{
    partial class FrmNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoUsuario));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.GbRegistrar = new System.Windows.Forms.GroupBox();
            this.cB_Mostrar = new System.Windows.Forms.CheckBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.GbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLogin.Location = new System.Drawing.Point(418, 73);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(10, 304);
            this.pnlLogin.TabIndex = 12;
            // 
            // GbRegistrar
            // 
            this.GbRegistrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbRegistrar.Controls.Add(this.cB_Mostrar);
            this.GbRegistrar.Controls.Add(this.btnRegresar);
            this.GbRegistrar.Controls.Add(this.btnRegistrar);
            this.GbRegistrar.Controls.Add(this.txtContraseña);
            this.GbRegistrar.Controls.Add(this.txtUsuario);
            this.GbRegistrar.Controls.Add(this.lblContraseña);
            this.GbRegistrar.Controls.Add(this.lblUsuario);
            this.GbRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRegistrar.Location = new System.Drawing.Point(47, 100);
            this.GbRegistrar.Name = "GbRegistrar";
            this.GbRegistrar.Size = new System.Drawing.Size(321, 257);
            this.GbRegistrar.TabIndex = 11;
            this.GbRegistrar.TabStop = false;
            this.GbRegistrar.Text = "Registrar";
            // 
            // cB_Mostrar
            // 
            this.cB_Mostrar.AutoSize = true;
            this.cB_Mostrar.Location = new System.Drawing.Point(225, 164);
            this.cB_Mostrar.Name = "cB_Mostrar";
            this.cB_Mostrar.Size = new System.Drawing.Size(75, 19);
            this.cB_Mostrar.TabIndex = 5;
            this.cB_Mostrar.Text = "Mostrar";
            this.cB_Mostrar.UseVisualStyleBackColor = true;
            this.cB_Mostrar.CheckedChanged += new System.EventHandler(this.cB_Mostrar_CheckedChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(178, 208);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(93, 27);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(58, 208);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 27);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(27, 162);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(181, 21);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 21);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(24, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(84, 15);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 56);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pBLogin
            // 
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(471, 100);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(282, 257);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.TabIndex = 10;
            this.pBLogin.TabStop = false;
            // 
            // FrmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.GbRegistrar);
            this.Controls.Add(this.pBLogin);
            this.Name = "FrmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoUsuario";
            this.GbRegistrar.ResumeLayout(false);
            this.GbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.GroupBox GbRegistrar;
        private System.Windows.Forms.CheckBox cB_Mostrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pBLogin;
    }
}