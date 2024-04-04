namespace ProyectoFinalHotelPOO.FormsCliente
{
    partial class FrmGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerente));
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblGerenteNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grpHotel = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.cmbTpoHabitación = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.cmbNiños = new System.Windows.Forms.ComboBox();
            this.cmbAdultos = new System.Windows.Forms.ComboBox();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblTipoDeHabitación = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCódigoDeCliente = new System.Windows.Forms.TextBox();
            this.lblCódigoDeCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNúmeroTelefónico = new System.Windows.Forms.Label();
            this.txtNúmeroTelefónico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtCorreoElectrónico = new System.Windows.Forms.TextBox();
            this.pnlGerente = new System.Windows.Forms.Panel();
            this.pnlUsuario.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpHotel.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUsuario.Controls.Add(this.lblGerenteNombre);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(175, 75);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(1048, 91);
            this.pnlUsuario.TabIndex = 11;
            // 
            // lblGerenteNombre
            // 
            this.lblGerenteNombre.AutoSize = true;
            this.lblGerenteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenteNombre.Location = new System.Drawing.Point(106, 38);
            this.lblGerenteNombre.Name = "lblGerenteNombre";
            this.lblGerenteNombre.Size = new System.Drawing.Size(82, 15);
            this.lblGerenteNombre.TabIndex = 1;
            this.lblGerenteNombre.Text = "Egnio Isaac";
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
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 597);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(175, 72);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnBuscar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnLimpiar);
            this.pnlBotones.Controls.Add(this.btnRegistrar);
            this.pnlBotones.Controls.Add(this.btnCerrarSesion);
            this.pnlBotones.Controls.Add(this.lblNombreSistema);
            this.pnlBotones.Controls.Add(this.picLogo);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(175, 669);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 57);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(0, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(175, 57);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(0, 318);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 57);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(0, 268);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(175, 57);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(0, 214);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 57);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.dgvClientes.Location = new System.Drawing.Point(317, 481);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(771, 173);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // grpHotel
            // 
            this.grpHotel.Controls.Add(this.lblTotal);
            this.grpHotel.Controls.Add(this.txtTotal);
            this.grpHotel.Controls.Add(this.cmbHoteles);
            this.grpHotel.Controls.Add(this.lblHotel);
            this.grpHotel.Controls.Add(this.dtpSalida);
            this.grpHotel.Controls.Add(this.dtpEntrada);
            this.grpHotel.Controls.Add(this.lblEntrada);
            this.grpHotel.Controls.Add(this.cmbTpoHabitación);
            this.grpHotel.Controls.Add(this.lblSalida);
            this.grpHotel.Controls.Add(this.cmbHabitaciones);
            this.grpHotel.Controls.Add(this.cmbNiños);
            this.grpHotel.Controls.Add(this.cmbAdultos);
            this.grpHotel.Controls.Add(this.lblAdultos);
            this.grpHotel.Controls.Add(this.lblNiños);
            this.grpHotel.Controls.Add(this.lblHabitaciones);
            this.grpHotel.Controls.Add(this.lblTipoDeHabitación);
            this.grpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHotel.Location = new System.Drawing.Point(634, 182);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Size = new System.Drawing.Size(544, 281);
            this.grpHotel.TabIndex = 26;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Hotel:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(378, 206);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total $:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(381, 222);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 21);
            this.txtTotal.TabIndex = 30;
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
            this.dtpEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpEntrada_KeyPress);
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
            // cmbTpoHabitación
            // 
            this.cmbTpoHabitación.FormattingEnabled = true;
            this.cmbTpoHabitación.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Matrimonial",
            "Familiar"});
            this.cmbTpoHabitación.Location = new System.Drawing.Point(38, 126);
            this.cmbTpoHabitación.Name = "cmbTpoHabitación";
            this.cmbTpoHabitación.Size = new System.Drawing.Size(137, 23);
            this.cmbTpoHabitación.TabIndex = 23;
            this.cmbTpoHabitación.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTpoHabitación_KeyPress);
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
            this.grpDatosPersonales.Controls.Add(this.txtCódigoDeCliente);
            this.grpDatosPersonales.Controls.Add(this.lblCódigoDeCliente);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.txtDirección);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.lblDirección);
            this.grpDatosPersonales.Controls.Add(this.lblApellidos);
            this.grpDatosPersonales.Controls.Add(this.txtApellidos);
            this.grpDatosPersonales.Controls.Add(this.lblNúmeroTelefónico);
            this.grpDatosPersonales.Controls.Add(this.txtNúmeroTelefónico);
            this.grpDatosPersonales.Controls.Add(this.lblCorreoElectrónico);
            this.grpDatosPersonales.Controls.Add(this.txtCorreoElectrónico);
            this.grpDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPersonales.Location = new System.Drawing.Point(217, 182);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(383, 281);
            this.grpDatosPersonales.TabIndex = 25;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales:";
            // 
            // txtCódigoDeCliente
            // 
            this.txtCódigoDeCliente.Location = new System.Drawing.Point(137, 241);
            this.txtCódigoDeCliente.Name = "txtCódigoDeCliente";
            this.txtCódigoDeCliente.Size = new System.Drawing.Size(137, 21);
            this.txtCódigoDeCliente.TabIndex = 19;
            this.txtCódigoDeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCódigoDeCliente_KeyPress);
            // 
            // lblCódigoDeCliente
            // 
            this.lblCódigoDeCliente.AutoSize = true;
            this.lblCódigoDeCliente.Location = new System.Drawing.Point(134, 225);
            this.lblCódigoDeCliente.Name = "lblCódigoDeCliente";
            this.lblCódigoDeCliente.Size = new System.Drawing.Size(123, 15);
            this.lblCódigoDeCliente.TabIndex = 18;
            this.lblCódigoDeCliente.Text = "Código de cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 21);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(40, 184);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(312, 21);
            this.txtDirección.TabIndex = 17;
            this.txtDirección.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirección_KeyPress);
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
            this.lblDirección.Location = new System.Drawing.Point(37, 168);
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
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // lblNúmeroTelefónico
            // 
            this.lblNúmeroTelefónico.AutoSize = true;
            this.lblNúmeroTelefónico.Location = new System.Drawing.Point(37, 109);
            this.lblNúmeroTelefónico.Name = "lblNúmeroTelefónico";
            this.lblNúmeroTelefónico.Size = new System.Drawing.Size(129, 15);
            this.lblNúmeroTelefónico.TabIndex = 4;
            this.lblNúmeroTelefónico.Text = "Número telefónico:";
            // 
            // txtNúmeroTelefónico
            // 
            this.txtNúmeroTelefónico.Location = new System.Drawing.Point(40, 125);
            this.txtNúmeroTelefónico.Name = "txtNúmeroTelefónico";
            this.txtNúmeroTelefónico.Size = new System.Drawing.Size(137, 21);
            this.txtNúmeroTelefónico.TabIndex = 5;
            this.txtNúmeroTelefónico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNúmeroTelefónico_KeyPress);
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(211, 109);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(130, 15);
            this.lblCorreoElectrónico.TabIndex = 6;
            this.lblCorreoElectrónico.Text = "Correo Electrónico:";
            // 
            // txtCorreoElectrónico
            // 
            this.txtCorreoElectrónico.Location = new System.Drawing.Point(214, 125);
            this.txtCorreoElectrónico.Name = "txtCorreoElectrónico";
            this.txtCorreoElectrónico.Size = new System.Drawing.Size(137, 21);
            this.txtCorreoElectrónico.TabIndex = 7;
            this.txtCorreoElectrónico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoElectrónico_KeyPress);
            // 
            // pnlGerente
            // 
            this.pnlGerente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGerente.Location = new System.Drawing.Point(175, 0);
            this.pnlGerente.Name = "pnlGerente";
            this.pnlGerente.Size = new System.Drawing.Size(1048, 75);
            this.pnlGerente.TabIndex = 10;
            // 
            // FrmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1223, 669);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpHotel);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlGerente);
            this.Controls.Add(this.pnlBotones);
            this.Name = "FrmGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerente";
            this.Load += new System.EventHandler(this.FrmGerente_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
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
        private System.Windows.Forms.Label lblGerenteNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grpHotel;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.ComboBox cmbTpoHabitación;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.ComboBox cmbNiños;
        private System.Windows.Forms.ComboBox cmbAdultos;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblTipoDeHabitación;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNúmeroTelefónico;
        private System.Windows.Forms.TextBox txtNúmeroTelefónico;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtCorreoElectrónico;
        private System.Windows.Forms.Panel pnlGerente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCódigoDeCliente;
        private System.Windows.Forms.Label lblCódigoDeCliente;
        private System.Windows.Forms.ComboBox cmbHoteles;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}