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
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.BtnNuevaReservacion = new System.Windows.Forms.Button();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grpHotel = new System.Windows.Forms.GroupBox();
            this.txtCodigoDeCliente = new System.Windows.Forms.TextBox();
            this.lblCódigoDeCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.cmbNiños = new System.Windows.Forms.ComboBox();
            this.cmbAdultos = new System.Windows.Forms.ComboBox();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblTipoDeHabitación = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNúmeroTelefónico = new System.Windows.Forms.Label();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpHotel.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
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
            this.pnlUsuario.Size = new System.Drawing.Size(982, 85);
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
            this.pnlCliente.Size = new System.Drawing.Size(982, 75);
            this.pnlCliente.TabIndex = 7;
            this.pnlCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCliente_Paint);
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
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.BtnHistorial);
            this.panel1.Controls.Add(this.BtnNuevaReservacion);
            this.panel1.Controls.Add(this.BtnReservar);
            this.panel1.Controls.Add(this.lblNombreSistema);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.btnAcercaDe);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 652);
            this.panel1.TabIndex = 6;
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.Location = new System.Drawing.Point(0, 325);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(175, 57);
            this.BtnHistorial.TabIndex = 8;
            this.BtnHistorial.Text = "Eliminar Reserva";
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnNuevaReservacion
            // 
            this.BtnNuevaReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevaReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaReservacion.Location = new System.Drawing.Point(0, 269);
            this.BtnNuevaReservacion.Name = "BtnNuevaReservacion";
            this.BtnNuevaReservacion.Size = new System.Drawing.Size(175, 57);
            this.BtnNuevaReservacion.TabIndex = 7;
            this.BtnNuevaReservacion.Text = "Nueva Reservación";
            this.BtnNuevaReservacion.UseVisualStyleBackColor = true;
            this.BtnNuevaReservacion.Click += new System.EventHandler(this.BtnNuevaReservacion_Click);
            // 
            // BtnReservar
            // 
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservar.Location = new System.Drawing.Point(0, 162);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(175, 57);
            this.BtnReservar.TabIndex = 6;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.button1_Click);
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
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(0, 218);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(175, 57);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.btnReservar_Click);
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
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(288, 476);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(743, 150);
            this.dgvClientes.TabIndex = 30;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // grpHotel
            // 
            this.grpHotel.BackColor = System.Drawing.Color.PowderBlue;
            this.grpHotel.Controls.Add(this.txtCodigoDeCliente);
            this.grpHotel.Controls.Add(this.lblCódigoDeCliente);
            this.grpHotel.Controls.Add(this.lblTotal);
            this.grpHotel.Controls.Add(this.txtTotal);
            this.grpHotel.Controls.Add(this.cmbHoteles);
            this.grpHotel.Controls.Add(this.lblHotel);
            this.grpHotel.Controls.Add(this.dtpSalida);
            this.grpHotel.Controls.Add(this.dtpEntrada);
            this.grpHotel.Controls.Add(this.lblEntrada);
            this.grpHotel.Controls.Add(this.cmbTipoHabitacion);
            this.grpHotel.Controls.Add(this.lblSalida);
            this.grpHotel.Controls.Add(this.cmbHabitaciones);
            this.grpHotel.Controls.Add(this.cmbNiños);
            this.grpHotel.Controls.Add(this.cmbAdultos);
            this.grpHotel.Controls.Add(this.lblAdultos);
            this.grpHotel.Controls.Add(this.lblNiños);
            this.grpHotel.Controls.Add(this.lblHabitaciones);
            this.grpHotel.Controls.Add(this.lblTipoDeHabitación);
            this.grpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHotel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpHotel.Location = new System.Drawing.Point(605, 177);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Size = new System.Drawing.Size(544, 281);
            this.grpHotel.TabIndex = 29;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Buscar Hoteles:";
            // 
            // txtCodigoDeCliente
            // 
            this.txtCodigoDeCliente.Location = new System.Drawing.Point(378, 243);
            this.txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            this.txtCodigoDeCliente.Size = new System.Drawing.Size(137, 21);
            this.txtCodigoDeCliente.TabIndex = 19;
            this.txtCodigoDeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCódigoDeCliente_KeyPress);
            // 
            // lblCódigoDeCliente
            // 
            this.lblCódigoDeCliente.AutoSize = true;
            this.lblCódigoDeCliente.Location = new System.Drawing.Point(378, 225);
            this.lblCódigoDeCliente.Name = "lblCódigoDeCliente";
            this.lblCódigoDeCliente.Size = new System.Drawing.Size(123, 15);
            this.lblCódigoDeCliente.TabIndex = 18;
            this.lblCódigoDeCliente.Text = "Código de cliente:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(378, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total $:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(381, 185);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 21);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cmbHoteles
            // 
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Items.AddRange(new object[] {
            "Hotel RDG",
            "Hotel Nicte",
            "Hotel Holiday Inn Convention Center",
            "Hotel Globales Camino Real Managua",
            "Hotel Real Intercontinental Metrocentro Managua"});
            this.cmbHoteles.Location = new System.Drawing.Point(38, 57);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(312, 23);
            this.cmbHoteles.TabIndex = 28;
            this.cmbHoteles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHoteles_KeyPress);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(35, 42);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(45, 15);
            this.lblHotel.TabIndex = 27;
            this.lblHotel.Text = "Hotel:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(38, 243);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(311, 21);
            this.dtpSalida.TabIndex = 26;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(38, 184);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(311, 21);
            this.dtpEntrada.TabIndex = 20;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(35, 168);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(61, 15);
            this.lblEntrada.TabIndex = 24;
            this.lblEntrada.Text = "Entrada:";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Matrimonial",
            "Familiar"});
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(38, 126);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(137, 23);
            this.cmbTipoHabitacion.TabIndex = 23;
            this.cmbTipoHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTpoHabitación_KeyPress);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(35, 225);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(52, 15);
            this.lblSalida.TabIndex = 25;
            this.lblSalida.Text = "Salida:";
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHabitaciones.Location = new System.Drawing.Point(381, 58);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(137, 23);
            this.cmbHabitaciones.TabIndex = 22;
            this.cmbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cmbHabitaciones_SelectedIndexChanged);
            this.cmbHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHabitaciones_KeyPress);
            // 
            // cmbNiños
            // 
            this.cmbNiños.FormattingEnabled = true;
            this.cmbNiños.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNiños.Location = new System.Drawing.Point(381, 126);
            this.cmbNiños.Name = "cmbNiños";
            this.cmbNiños.Size = new System.Drawing.Size(137, 23);
            this.cmbNiños.TabIndex = 21;
            this.cmbNiños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNiños_KeyPress);
            // 
            // cmbAdultos
            // 
            this.cmbAdultos.FormattingEnabled = true;
            this.cmbAdultos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbAdultos.Location = new System.Drawing.Point(211, 125);
            this.cmbAdultos.Name = "cmbAdultos";
            this.cmbAdultos.Size = new System.Drawing.Size(137, 23);
            this.cmbAdultos.TabIndex = 20;
            this.cmbAdultos.SelectedIndexChanged += new System.EventHandler(this.cmbAdultos_SelectedIndexChanged);
            this.cmbAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAdultos_KeyPress);
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(208, 110);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(58, 15);
            this.lblAdultos.TabIndex = 0;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(378, 110);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(48, 15);
            this.lblNiños.TabIndex = 2;
            this.lblNiños.Text = "Niños:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(378, 43);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(95, 15);
            this.lblHabitaciones.TabIndex = 4;
            this.lblHabitaciones.Text = "Habitaciones:";
            // 
            // lblTipoDeHabitación
            // 
            this.lblTipoDeHabitación.AutoSize = true;
            this.lblTipoDeHabitación.Location = new System.Drawing.Point(35, 110);
            this.lblTipoDeHabitación.Name = "lblTipoDeHabitación";
            this.lblTipoDeHabitación.Size = new System.Drawing.Size(130, 15);
            this.lblTipoDeHabitación.TabIndex = 6;
            this.lblTipoDeHabitación.Text = "Tipo de habitación:";
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.BackColor = System.Drawing.Color.PowderBlue;
            this.grpDatosPersonales.Controls.Add(this.label1);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.lblDirección);
            this.grpDatosPersonales.Controls.Add(this.lblApellidos);
            this.grpDatosPersonales.Controls.Add(this.txtApellidos);
            this.grpDatosPersonales.Controls.Add(this.lblNúmeroTelefónico);
            this.grpDatosPersonales.Controls.Add(this.txtNumeroTelefonico);
            this.grpDatosPersonales.Controls.Add(this.lblCorreoElectrónico);
            this.grpDatosPersonales.Controls.Add(this.txtCorreoElectronico);
            this.grpDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPersonales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpDatosPersonales.Location = new System.Drawing.Point(188, 177);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(383, 281);
            this.grpDatosPersonales.TabIndex = 28;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales:";
            this.grpDatosPersonales.Enter += new System.EventHandler(this.grpDatosPersonales_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "*La siguiente información será utilizada con el fin de establecer contacto \r\nentr" +
    "e el cliente y el hotel seleccionado y demás acciones relacionadas.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 21);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(40, 117);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(312, 21);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDirección_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirección_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Location = new System.Drawing.Point(37, 101);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(72, 15);
            this.lblDirección.TabIndex = 16;
            this.lblDirección.Text = "Dirección:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(211, 42);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(70, 15);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(214, 58);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(137, 21);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // lblNúmeroTelefónico
            // 
            this.lblNúmeroTelefónico.AutoSize = true;
            this.lblNúmeroTelefónico.Location = new System.Drawing.Point(37, 175);
            this.lblNúmeroTelefónico.Name = "lblNúmeroTelefónico";
            this.lblNúmeroTelefónico.Size = new System.Drawing.Size(129, 15);
            this.lblNúmeroTelefónico.TabIndex = 4;
            this.lblNúmeroTelefónico.Text = "Número telefónico:";
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(40, 191);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(137, 21);
            this.txtNumeroTelefonico.TabIndex = 5;
            this.txtNumeroTelefonico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNúmeroTelefónico_KeyPress);
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(211, 175);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(130, 15);
            this.lblCorreoElectrónico.TabIndex = 6;
            this.lblCorreoElectrónico.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(214, 191);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(137, 21);
            this.txtCorreoElectronico.TabIndex = 7;
            this.txtCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoElectrónico_KeyPress);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 652);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.grpHotel);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grpHotel.ResumeLayout(false);
            this.grpHotel.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
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
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grpHotel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbHoteles;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.ComboBox cmbNiños;
        private System.Windows.Forms.ComboBox cmbAdultos;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblTipoDeHabitación;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtCodigoDeCliente;
        private System.Windows.Forms.Label lblCódigoDeCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNúmeroTelefónico;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Button BtnHistorial;
        private System.Windows.Forms.Button BtnNuevaReservacion;
        private System.Windows.Forms.Label label1;
    }
}