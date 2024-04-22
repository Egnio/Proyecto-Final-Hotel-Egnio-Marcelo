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
            this.lblHotel = new System.Windows.Forms.Label();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistorial = new System.Windows.Forms.Button();
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
            this.txtCodigoDeCliente = new System.Windows.Forms.TextBox();
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
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).BeginInit();
            this.grpHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlUsuario.Controls.Add(this.lblClienteNombre);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Controls.Add(this.lblHotel);
            this.pnlUsuario.Controls.Add(this.cmbHoteles);
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
            // cmbHoteles
            // 
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Items.AddRange(new object[] {
            "Hotel RDG",
            "Hotel Nicte",
            "Hotel Holiday Inn Convention Center",
            "Hotel Globales Camino Real Managua",
            "Hotel Real Intercontinental Metrocentro Managua"});
            this.cmbHoteles.Location = new System.Drawing.Point(373, 55);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(312, 21);
            this.cmbHoteles.TabIndex = 28;
            this.cmbHoteles.SelectedIndexChanged += new System.EventHandler(this.cmbHoteles_SelectedIndexChanged);
            this.cmbHoteles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHoteles_KeyPress);
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
            this.panel1.Controls.Add(this.BtnHistorial);
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
            // BtnHistorial
            // 
            this.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.Location = new System.Drawing.Point(0, 270);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(175, 57);
            this.BtnHistorial.TabIndex = 8;
            this.BtnHistorial.Text = "Deseleccionar";
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
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
            this.BtnReservar.Location = new System.Drawing.Point(0, 325);
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
            this.grpHotel.Controls.Add(this.txtCodigoDeCliente);
            this.grpHotel.Controls.Add(this.lblCódigoDeCliente);
            this.grpHotel.Controls.Add(this.lblTotal);
            this.grpHotel.Controls.Add(this.txtTotal);
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
            this.grpHotel.ForeColor = System.Drawing.SystemColors.Window;
            this.grpHotel.Location = new System.Drawing.Point(221, 177);
            this.grpHotel.Name = "grpHotel";
            this.grpHotel.Size = new System.Drawing.Size(906, 282);
            this.grpHotel.TabIndex = 29;
            this.grpHotel.TabStop = false;
            this.grpHotel.Text = "Buscar Hoteles:";
            this.grpHotel.Enter += new System.EventHandler(this.grpHotel_Enter);
            // 
            // CboServicioHabitacion
            // 
            this.CboServicioHabitacion.FormattingEnabled = true;
            this.CboServicioHabitacion.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CboServicioHabitacion.Location = new System.Drawing.Point(721, 126);
            this.CboServicioHabitacion.Name = "CboServicioHabitacion";
            this.CboServicioHabitacion.Size = new System.Drawing.Size(160, 23);
            this.CboServicioHabitacion.TabIndex = 42;
            // 
            // LblServicioHabitacion
            // 
            this.LblServicioHabitacion.AutoSize = true;
            this.LblServicioHabitacion.Location = new System.Drawing.Point(718, 111);
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
            this.CboGimnasio.Location = new System.Drawing.Point(721, 55);
            this.CboGimnasio.Name = "CboGimnasio";
            this.CboGimnasio.Size = new System.Drawing.Size(160, 23);
            this.CboGimnasio.TabIndex = 40;
            // 
            // LblGimnasio
            // 
            this.LblGimnasio.AutoSize = true;
            this.LblGimnasio.BackColor = System.Drawing.Color.Transparent;
            this.LblGimnasio.ForeColor = System.Drawing.SystemColors.Window;
            this.LblGimnasio.Location = new System.Drawing.Point(718, 40);
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
            this.CboPiscina.Location = new System.Drawing.Point(555, 126);
            this.CboPiscina.Name = "CboPiscina";
            this.CboPiscina.Size = new System.Drawing.Size(131, 23);
            this.CboPiscina.TabIndex = 38;
            this.CboPiscina.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // LblPiscina
            // 
            this.LblPiscina.AutoSize = true;
            this.LblPiscina.Location = new System.Drawing.Point(552, 112);
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
            this.CboWIFI.Location = new System.Drawing.Point(555, 55);
            this.CboWIFI.Name = "CboWIFI";
            this.CboWIFI.Size = new System.Drawing.Size(131, 23);
            this.CboWIFI.TabIndex = 36;
            this.CboWIFI.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LblServicioWIFI
            // 
            this.LblServicioWIFI.AutoSize = true;
            this.LblServicioWIFI.Location = new System.Drawing.Point(552, 40);
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
            this.CboOpiniones.Location = new System.Drawing.Point(381, 127);
            this.CboOpiniones.Name = "CboOpiniones";
            this.CboOpiniones.Size = new System.Drawing.Size(132, 23);
            this.CboOpiniones.TabIndex = 34;
            // 
            // LblOpiniones
            // 
            this.LblOpiniones.AutoSize = true;
            this.LblOpiniones.Location = new System.Drawing.Point(378, 112);
            this.LblOpiniones.Name = "LblOpiniones";
            this.LblOpiniones.Size = new System.Drawing.Size(76, 15);
            this.LblOpiniones.TabIndex = 33;
            this.LblOpiniones.Text = "Opiniones:";
            // 
            // CboValoracion
            // 
            this.CboValoracion.FormattingEnabled = true;
            this.CboValoracion.Items.AddRange(new object[] {
            "1 Estrella",
            "2 Estrellas",
            "3 Estrellas",
            "4 Estrellas ",
            "5 Estrellas"});
            this.CboValoracion.Location = new System.Drawing.Point(381, 55);
            this.CboValoracion.Name = "CboValoracion";
            this.CboValoracion.Size = new System.Drawing.Size(132, 23);
            this.CboValoracion.TabIndex = 32;
            // 
            // LblValoraciones
            // 
            this.LblValoraciones.AutoSize = true;
            this.LblValoraciones.Location = new System.Drawing.Point(378, 40);
            this.LblValoraciones.Name = "LblValoraciones";
            this.LblValoraciones.Size = new System.Drawing.Size(79, 15);
            this.LblValoraciones.TabIndex = 31;
            this.LblValoraciones.Text = "Valoración:";
            // 
            // txtCodigoDeCliente
            // 
            this.txtCodigoDeCliente.Location = new System.Drawing.Point(378, 243);
            this.txtCodigoDeCliente.Name = "txtCodigoDeCliente";
            this.txtCodigoDeCliente.Size = new System.Drawing.Size(132, 21);
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
            this.lblTotal.Location = new System.Drawing.Point(378, 168);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 15);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total $:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(381, 184);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(132, 21);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
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
            this.cmbHabitaciones.Location = new System.Drawing.Point(38, 57);
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
            this.cmbNiños.Location = new System.Drawing.Point(212, 126);
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
            this.cmbAdultos.Location = new System.Drawing.Point(212, 55);
            this.cmbAdultos.Name = "cmbAdultos";
            this.cmbAdultos.Size = new System.Drawing.Size(137, 23);
            this.cmbAdultos.TabIndex = 20;
            this.cmbAdultos.SelectedIndexChanged += new System.EventHandler(this.cmbAdultos_SelectedIndexChanged);
            this.cmbAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAdultos_KeyPress);
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(209, 40);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(58, 15);
            this.lblAdultos.TabIndex = 0;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(209, 110);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(48, 15);
            this.lblNiños.TabIndex = 2;
            this.lblNiños.Text = "Niños:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(35, 42);
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
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 652);
            this.Controls.Add(this.dgvHoteles);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.grpHotel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).EndInit();
            this.grpHotel.ResumeLayout(false);
            this.grpHotel.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCodigoDeCliente;
        private System.Windows.Forms.Label lblCódigoDeCliente;
        private System.Windows.Forms.Button BtnHistorial;
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
    }
}