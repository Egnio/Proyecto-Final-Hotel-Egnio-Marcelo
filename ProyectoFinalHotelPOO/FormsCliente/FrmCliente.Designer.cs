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
            this.TxtHoteles = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDeseleccionar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvHoteles = new System.Windows.Forms.DataGridView();
            this.grpHotel = new System.Windows.Forms.GroupBox();
            this.CboServicioHabitacion = new System.Windows.Forms.ComboBox();
            this.LblServicioHabitacion = new System.Windows.Forms.Label();
            this.CboGimnasio = new System.Windows.Forms.ComboBox();
            this.LblGimnasio = new System.Windows.Forms.Label();
            this.CboPiscina = new System.Windows.Forms.ComboBox();
            this.LblPiscina = new System.Windows.Forms.Label();
            this.CboWIFI = new System.Windows.Forms.ComboBox();
            this.LblServicioWIFI = new System.Windows.Forms.Label();
            this.CboOpiniones = new System.Windows.Forms.ComboBox();
            this.LblOpiniones = new System.Windows.Forms.Label();
            this.CboValoracion = new System.Windows.Forms.ComboBox();
            this.LblValoraciones = new System.Windows.Forms.Label();
            this.txtCodigoDelHotel = new System.Windows.Forms.TextBox();
            this.lblCódigoDeCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).BeginInit();
            this.grpHotel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlUsuario.Controls.Add(this.TxtHoteles);
            this.pnlUsuario.Controls.Add(this.lblClienteNombre);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Controls.Add(this.lblHotel);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(175, 75);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(982, 85);
            this.pnlUsuario.TabIndex = 8;
            // 
            // TxtHoteles
            // 
            this.TxtHoteles.Location = new System.Drawing.Point(485, 37);
            this.TxtHoteles.Name = "TxtHoteles";
            this.TxtHoteles.ReadOnly = true;
            this.TxtHoteles.Size = new System.Drawing.Size(212, 20);
            this.TxtHoteles.TabIndex = 31;
            this.TxtHoteles.TextChanged += new System.EventHandler(this.TxtHoteles_TextChanged);
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
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(370, 40);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(109, 13);
            this.lblHotel.TabIndex = 27;
            this.lblHotel.Text = "Nombre del Hotel:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.PaleGoldenrod;
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
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.BtnDeseleccionar);
            this.panel1.Controls.Add(this.BtnSeleccionar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.lblNombreSistema);
            this.panel1.Controls.Add(this.BtnReservar);
            this.panel1.Controls.Add(this.btnAcercaDe);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 652);
            this.panel1.TabIndex = 6;
            // 
            // BtnDeseleccionar
            // 
            this.BtnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeseleccionar.Location = new System.Drawing.Point(0, 270);
            this.BtnDeseleccionar.Name = "BtnDeseleccionar";
            this.BtnDeseleccionar.Size = new System.Drawing.Size(175, 57);
            this.BtnDeseleccionar.TabIndex = 8;
            this.BtnDeseleccionar.Text = "Deseleccionar";
            this.BtnDeseleccionar.UseVisualStyleBackColor = true;
            this.BtnDeseleccionar.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(0, 218);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(175, 57);
            this.BtnSeleccionar.TabIndex = 7;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnNuevaReservacion_Click);
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
            this.BtnBuscar.Click += new System.EventHandler(this.button1_Click);
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
            // BtnReservar
            // 
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservar.Location = new System.Drawing.Point(0, 380);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(175, 57);
            this.BtnReservar.TabIndex = 1;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.btnReservar_Click);
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
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
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
            // dgvHoteles
            // 
            this.dgvHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoteles.Location = new System.Drawing.Point(288, 476);
            this.dgvHoteles.Name = "dgvHoteles";
            this.dgvHoteles.Size = new System.Drawing.Size(743, 150);
            this.dgvHoteles.TabIndex = 30;
            this.dgvHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // grpHotel
            // 
            this.grpHotel.BackColor = System.Drawing.Color.Transparent;
            this.grpHotel.Controls.Add(this.CboServicioHabitacion);
            this.grpHotel.Controls.Add(this.LblServicioHabitacion);
            this.grpHotel.Controls.Add(this.CboGimnasio);
            this.grpHotel.Controls.Add(this.LblGimnasio);
            this.grpHotel.Controls.Add(this.CboPiscina);
            this.grpHotel.Controls.Add(this.LblPiscina);
            this.grpHotel.Controls.Add(this.CboWIFI);
            this.grpHotel.Controls.Add(this.LblServicioWIFI);
            this.grpHotel.Controls.Add(this.CboOpiniones);
            this.grpHotel.Controls.Add(this.LblOpiniones);
            this.grpHotel.Controls.Add(this.CboValoracion);
            this.grpHotel.Controls.Add(this.LblValoraciones);
            this.grpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHotel.ForeColor = System.Drawing.SystemColors.Window;
            this.grpHotel.Location = new System.Drawing.Point(736, 182);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Size = new System.Drawing.Size(397, 282);
            this.grpHotel.TabIndex = 29;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Filtros de Búsqueda:";
            this.grpHotel.Enter += new System.EventHandler(this.grpHotel_Enter);
            // 
            // CboServicioHabitacion
            // 
            this.CboServicioHabitacion.FormattingEnabled = true;
            this.CboServicioHabitacion.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CboServicioHabitacion.Location = new System.Drawing.Point(206, 110);
            this.CboServicioHabitacion.Name = "CboServicioHabitacion";
            this.CboServicioHabitacion.Size = new System.Drawing.Size(160, 23);
            this.CboServicioHabitacion.TabIndex = 42;
            // 
            // LblServicioHabitacion
            // 
            this.LblServicioHabitacion.AutoSize = true;
            this.LblServicioHabitacion.Location = new System.Drawing.Point(203, 95);
            this.LblServicioHabitacion.Name = "LblServicioHabitacion";
            this.LblServicioHabitacion.Size = new System.Drawing.Size(163, 15);
            this.LblServicioHabitacion.TabIndex = 41;
            this.LblServicioHabitacion.Text = "Servicio a la Habitación:";
            // 
            // CboGimnasio
            // 
            this.CboGimnasio.FormattingEnabled = true;
            this.CboGimnasio.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CboGimnasio.Location = new System.Drawing.Point(206, 41);
            this.CboGimnasio.Name = "CboGimnasio";
            this.CboGimnasio.Size = new System.Drawing.Size(160, 23);
            this.CboGimnasio.TabIndex = 40;
            // 
            // LblGimnasio
            // 
            this.LblGimnasio.AutoSize = true;
            this.LblGimnasio.BackColor = System.Drawing.Color.Transparent;
            this.LblGimnasio.ForeColor = System.Drawing.SystemColors.Window;
            this.LblGimnasio.Location = new System.Drawing.Point(203, 26);
            this.LblGimnasio.Name = "LblGimnasio";
            this.LblGimnasio.Size = new System.Drawing.Size(72, 15);
            this.LblGimnasio.TabIndex = 39;
            this.LblGimnasio.Text = "Gimnasio:";
            // 
            // CboPiscina
            // 
            this.CboPiscina.FormattingEnabled = true;
            this.CboPiscina.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CboPiscina.Location = new System.Drawing.Point(43, 112);
            this.CboPiscina.Name = "CboPiscina";
            this.CboPiscina.Size = new System.Drawing.Size(131, 23);
            this.CboPiscina.TabIndex = 38;
            this.CboPiscina.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // LblPiscina
            // 
            this.LblPiscina.AutoSize = true;
            this.LblPiscina.Location = new System.Drawing.Point(40, 98);
            this.LblPiscina.Name = "LblPiscina";
            this.LblPiscina.Size = new System.Drawing.Size(58, 15);
            this.LblPiscina.TabIndex = 37;
            this.LblPiscina.Text = "Piscina:";
            this.LblPiscina.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CboWIFI
            // 
            this.CboWIFI.FormattingEnabled = true;
            this.CboWIFI.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CboWIFI.Location = new System.Drawing.Point(43, 41);
            this.CboWIFI.Name = "CboWIFI";
            this.CboWIFI.Size = new System.Drawing.Size(131, 23);
            this.CboWIFI.TabIndex = 36;
            this.CboWIFI.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LblServicioWIFI
            // 
            this.LblServicioWIFI.AutoSize = true;
            this.LblServicioWIFI.Location = new System.Drawing.Point(40, 26);
            this.LblServicioWIFI.Name = "LblServicioWIFI";
            this.LblServicioWIFI.Size = new System.Drawing.Size(94, 15);
            this.LblServicioWIFI.TabIndex = 35;
            this.LblServicioWIFI.Text = "Servicio WIFI:";
            this.LblServicioWIFI.Click += new System.EventHandler(this.LblServicioWIFI_Click);
            // 
            // CboOpiniones
            // 
            this.CboOpiniones.FormattingEnabled = true;
            this.CboOpiniones.Items.AddRange(new object[] {
            "Bueno",
            "Muy Bueno ",
            "Fantástico",
            "Fabuloso"});
            this.CboOpiniones.Location = new System.Drawing.Point(43, 239);
            this.CboOpiniones.Name = "CboOpiniones";
            this.CboOpiniones.Size = new System.Drawing.Size(132, 23);
            this.CboOpiniones.TabIndex = 34;
            // 
            // LblOpiniones
            // 
            this.LblOpiniones.AutoSize = true;
            this.LblOpiniones.Location = new System.Drawing.Point(40, 224);
            this.LblOpiniones.Name = "LblOpiniones";
            this.LblOpiniones.Size = new System.Drawing.Size(76, 15);
            this.LblOpiniones.TabIndex = 33;
            this.LblOpiniones.Text = "Opiniones:";
            // 
            // CboValoracion
            // 
            this.CboValoracion.FormattingEnabled = true;
            this.CboValoracion.Items.AddRange(new object[] {
            "Una Estrella",
            "Dos Estrellas",
            "Tres Estrellas",
            "Cuatro Estrellas ",
            "Cinco Estrellas"});
            this.CboValoracion.Location = new System.Drawing.Point(43, 171);
            this.CboValoracion.Name = "CboValoracion";
            this.CboValoracion.Size = new System.Drawing.Size(132, 23);
            this.CboValoracion.TabIndex = 32;
            // 
            // LblValoraciones
            // 
            this.LblValoraciones.AutoSize = true;
            this.LblValoraciones.Location = new System.Drawing.Point(40, 156);
            this.LblValoraciones.Name = "LblValoraciones";
            this.LblValoraciones.Size = new System.Drawing.Size(79, 15);
            this.LblValoraciones.TabIndex = 31;
            this.LblValoraciones.Text = "Valoración:";
            // 
            // txtCodigoDelHotel
            // 
            this.txtCodigoDelHotel.Location = new System.Drawing.Point(358, 116);
            this.txtCodigoDelHotel.Name = "txtCodigoDelHotel";
            this.txtCodigoDelHotel.Size = new System.Drawing.Size(132, 21);
            this.txtCodigoDelHotel.TabIndex = 19;
            this.txtCodigoDelHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCódigoDeCliente_KeyPress);
            // 
            // lblCódigoDeCliente
            // 
            this.lblCódigoDeCliente.AutoSize = true;
            this.lblCódigoDeCliente.Location = new System.Drawing.Point(358, 98);
            this.lblCódigoDeCliente.Name = "lblCódigoDeCliente";
            this.lblCódigoDeCliente.Size = new System.Drawing.Size(118, 15);
            this.lblCódigoDeCliente.TabIndex = 18;
            this.lblCódigoDeCliente.Text = "Código del Hotel:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(355, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total $:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(358, 48);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 21);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(22, 233);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(311, 21);
            this.dtpSalida.TabIndex = 26;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(22, 174);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(311, 21);
            this.dtpEntrada.TabIndex = 20;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(19, 158);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(61, 15);
            this.lblEntrada.TabIndex = 24;
            this.lblEntrada.Text = "Entrada:";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Matrimonial",
            "Familiar"});
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(22, 116);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(137, 23);
            this.cmbTipoHabitacion.TabIndex = 23;
            this.cmbTipoHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTpoHabitación_KeyPress);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(19, 215);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(52, 15);
            this.lblSalida.TabIndex = 25;
            this.lblSalida.Text = "Salida:";
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHabitaciones.Location = new System.Drawing.Point(22, 47);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(137, 23);
            this.cmbHabitaciones.TabIndex = 22;
            this.cmbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cmbHabitaciones_SelectedIndexChanged);
            this.cmbHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHabitaciones_KeyPress);
            // 
            // cmbNiños
            // 
            this.cmbNiños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNiños.FormattingEnabled = true;
            this.cmbNiños.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNiños.Location = new System.Drawing.Point(196, 115);
            this.cmbNiños.Name = "cmbNiños";
            this.cmbNiños.Size = new System.Drawing.Size(137, 23);
            this.cmbNiños.TabIndex = 21;
            this.cmbNiños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNiños_KeyPress);
            // 
            // cmbAdultos
            // 
            this.cmbAdultos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdultos.FormattingEnabled = true;
            this.cmbAdultos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbAdultos.Location = new System.Drawing.Point(196, 47);
            this.cmbAdultos.Name = "cmbAdultos";
            this.cmbAdultos.Size = new System.Drawing.Size(137, 23);
            this.cmbAdultos.TabIndex = 20;
            this.cmbAdultos.SelectedIndexChanged += new System.EventHandler(this.cmbAdultos_SelectedIndexChanged);
            this.cmbAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAdultos_KeyPress);
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(193, 32);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(58, 15);
            this.lblAdultos.TabIndex = 0;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(193, 99);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(48, 15);
            this.lblNiños.TabIndex = 2;
            this.lblNiños.Text = "Niños:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(19, 32);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(95, 15);
            this.lblHabitaciones.TabIndex = 4;
            this.lblHabitaciones.Text = "Habitaciones:";
            // 
            // lblTipoDeHabitación
            // 
            this.lblTipoDeHabitación.AutoSize = true;
            this.lblTipoDeHabitación.Location = new System.Drawing.Point(19, 100);
            this.lblTipoDeHabitación.Name = "lblTipoDeHabitación";
            this.lblTipoDeHabitación.Size = new System.Drawing.Size(130, 15);
            this.lblTipoDeHabitación.TabIndex = 6;
            this.lblTipoDeHabitación.Text = "Tipo de habitación:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(0, 324);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(175, 57);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblCódigoDeCliente);
            this.groupBox1.Controls.Add(this.txtCodigoDelHotel);
            this.groupBox1.Controls.Add(this.lblHabitaciones);
            this.groupBox1.Controls.Add(this.dtpEntrada);
            this.groupBox1.Controls.Add(this.lblNiños);
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.lblAdultos);
            this.groupBox1.Controls.Add(this.cmbAdultos);
            this.groupBox1.Controls.Add(this.lblEntrada);
            this.groupBox1.Controls.Add(this.cmbNiños);
            this.groupBox1.Controls.Add(this.lblTipoDeHabitación);
            this.groupBox1.Controls.Add(this.cmbTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblSalida);
            this.groupBox1.Controls.Add(this.cmbHabitaciones);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(208, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 282);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para Reservación:";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoteles);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.grpHotel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Text = "Reserva de Hoteles Managua";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).EndInit();
            this.grpHotel.ResumeLayout(false);
            this.grpHotel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dgvHoteles;
        private System.Windows.Forms.GroupBox grpHotel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
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
        private System.Windows.Forms.TextBox txtCodigoDelHotel;
        private System.Windows.Forms.Label lblCódigoDeCliente;
        private System.Windows.Forms.Button BtnDeseleccionar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.ComboBox CboValoracion;
        private System.Windows.Forms.Label LblValoraciones;
        private System.Windows.Forms.ComboBox CboWIFI;
        private System.Windows.Forms.Label LblServicioWIFI;
        private System.Windows.Forms.ComboBox CboOpiniones;
        private System.Windows.Forms.Label LblOpiniones;
        private System.Windows.Forms.ComboBox CboServicioHabitacion;
        private System.Windows.Forms.Label LblServicioHabitacion;
        private System.Windows.Forms.ComboBox CboGimnasio;
        private System.Windows.Forms.Label LblGimnasio;
        private System.Windows.Forms.ComboBox CboPiscina;
        private System.Windows.Forms.Label LblPiscina;
        private System.Windows.Forms.TextBox TxtHoteles;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}