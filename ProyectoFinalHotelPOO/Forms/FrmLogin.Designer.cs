namespace ProyectoFinalHotelPOO
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbrLogin = new System.Windows.Forms.ProgressBar();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.GbIngresar = new System.Windows.Forms.GroupBox();
            this.cB_Mostrar = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.GbIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbrLogin
            // 
            this.pbrLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbrLogin.Location = new System.Drawing.Point(259, 372);
            this.pbrLogin.Name = "pbrLogin";
            this.pbrLogin.Size = new System.Drawing.Size(332, 41);
            this.pbrLogin.TabIndex = 10;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLogin.Location = new System.Drawing.Point(419, 37);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(10, 320);
            this.pnlLogin.TabIndex = 9;
            // 
            // GbIngresar
            // 
            this.GbIngresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbIngresar.Controls.Add(this.lblCrearCuenta);
            this.GbIngresar.Controls.Add(this.cB_Mostrar);
            this.GbIngresar.Controls.Add(this.btnSalir);
            this.GbIngresar.Controls.Add(this.btnIngresar);
            this.GbIngresar.Controls.Add(this.txtContraseña);
            this.GbIngresar.Controls.Add(this.txtUsuario);
            this.GbIngresar.Controls.Add(this.lblContraseña);
            this.GbIngresar.Controls.Add(this.lblUsuario);
            this.GbIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIngresar.Location = new System.Drawing.Point(47, 64);
            this.GbIngresar.Name = "GbIngresar";
            this.GbIngresar.Size = new System.Drawing.Size(321, 277);
            this.GbIngresar.TabIndex = 8;
            this.GbIngresar.TabStop = false;
            this.GbIngresar.Text = "Ingresar";
            // 
            // cB_Mostrar
            // 
            this.cB_Mostrar.AutoSize = true;
            this.cB_Mostrar.Location = new System.Drawing.Point(225, 154);
            this.cB_Mostrar.Name = "cB_Mostrar";
            this.cB_Mostrar.Size = new System.Drawing.Size(75, 19);
            this.cB_Mostrar.TabIndex = 5;
            this.cB_Mostrar.Text = "Mostrar";
            this.cB_Mostrar.UseVisualStyleBackColor = true;
            this.cB_Mostrar.CheckedChanged += new System.EventHandler(this.cB_Mostrar_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(178, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(58, 198);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(93, 27);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(27, 152);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(181, 21);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 21);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(24, 122);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(84, 15);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(24, 46);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pBLogin
            // 
            this.pBLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBLogin.Image")));
            this.pBLogin.Location = new System.Drawing.Point(471, 64);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(292, 277);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogin.TabIndex = 7;
            this.pBLogin.TabStop = false;
            // 
            // tmrLogin
            // 
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Location = new System.Drawing.Point(117, 242);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(91, 15);
            this.lblCrearCuenta.TabIndex = 6;
            this.lblCrearCuenta.Text = "Crear Cuenta";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbrLogin);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.GbIngresar);
            this.Controls.Add(this.pBLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.GbIngresar.ResumeLayout(false);
            this.GbIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.GroupBox GbIngresar;
        private System.Windows.Forms.CheckBox cB_Mostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.Label lblCrearCuenta;
    }
}

