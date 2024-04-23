using ProyectoFinalHotelPOO.FormsGerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalHotelPOO.FormsCliente
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();

         
            txtTotal.ReadOnly = true;
            txtCodigoDelHotel.ReadOnly = true;
            BtnReservar.Enabled = false;
            BtnDeseleccionar.Enabled = false;
            /*
            BtnSeleccionar.Enabled = false;
            */

        }
        Clientes_Gerente sql = new Clientes_Gerente();

        private void pnlCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Hoteles";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion); 
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvHoteles.DataSource = dt;

        }

        //Cambiar a localhost en caso el usuario no sea Egnio 
        SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-HGB0OD39\\SQLEXPRESS; initial catalog = HotelClientes; integrated security = true");

        private DataSet ds;
        public DataTable mostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Hoteles", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(CboValoracion.Text == "" && CboWIFI.Text == "" && CboPiscina.Text == "" && CboGimnasio.Text == "" && CboServicioHabitacion.Text == "" && CboOpiniones.Text == "" )
            {
                string query = "Select * from Hoteles";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvHoteles.DataSource = tabla;

           
            }
            else
            {
                string query = "Select * from Hoteles where Valoración = '"+ CboValoracion.Text +"' " + "Select * from Hoteles where Opiniones = '"+ CboOpiniones.Text +"' " + "Select * from Hoteles where ServicioWIFI = '"+ CboWIFI.Text +"' " + "Select * from Hoteles where Piscina = '" + CboPiscina.Text + "' " + "Select * from Hoteles where Gimnasio = '" + CboGimnasio.Text + "' " + "Select * from Hoteles where ServicioHabitación = '" + CboServicioHabitacion.Text +"' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla); //Error solucionado!!
                dgvHoteles.DataSource = tabla;
            }
            /*
            BtnSeleccionar.Enabled = true;
            */
        }

        private void txtCódigoDeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //btnCancelar_Click
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (TxtHoteles.Text == "" && txtTotal.Text == "") 
            {
                MessageBox.Show("Por favor seleccione un hotel, rellene el formulario Seleccionar y luego presione el botón Seleccionar.");
               
            }
            else
            {
               
                FrmBuscar frm = new FrmBuscar();
                frm.Show();
                this.Hide();
            }
        }
        

        private void cmbAdultos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAdultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre adultos y niños
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmbAdultos.Text == "0")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor seleccione al menos un adulto.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbNiños.Focus();
                    e.Handled = true;
                }
            }
        }

        private void cmbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre habitacion y tipo de habitacion
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmbHabitaciones.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor seleccione al menos una habitación.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbTipoHabitacion.Focus();
                    e.Handled = true;
                }
            }
        }

        private void cmbNiños_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre niños y la fecha de entrada
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpEntrada.Focus();
                e.Handled = true;
            }
        }

        private void cmbTpoHabitación_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre tipo de habitacion y adultos
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cmbTipoHabitacion.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor seleccione el tipo de habitación.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbAdultos.Focus();
                    e.Handled = true;
                }
            }
        }

        private void cmbHoteles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre hoteles y habitaciones
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtHoteles.Text == "")
                {
                    //Se valida que el usuario no deje la casilla en blanco
                    MessageBox.Show("Por favor seleccione un hotel.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbHabitaciones.Focus();
                    e.Handled = true;
                }
            }
        }


        private void grpDatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDirección_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Cerrando sesión de gerente
            if (MessageBox.Show(" ¿Desea cerrar su sesión? ", "Reserva de Hoteles Managua", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void BtnNuevaReservacion_Click(object sender, EventArgs e)
        {
            if (TxtHoteles.Text == "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text == "")
            {
                MessageBox.Show("Por favor seleccione un Hotel y rellene el formulario Datos para Reservación. Utilice los Filtros si es necesario.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }

            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text != "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text != "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text != "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor rellene por completo el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text != "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }

            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text == "" && cmbHabitaciones.Text != "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y vuelva a presionar el botón Seleccionar.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y luego rellene el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y luego rellene el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text == "" && cmbNiños.Text != ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y luego rellene el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text == "" && cmbAdultos.Text != "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y luego rellene el formulario Datos para Reservación.");
            }
            else if ((TxtHoteles.Text != "" && cmbHabitaciones.Text == "" && cmbTipoHabitacion.Text != "" && cmbAdultos.Text == "" && cmbNiños.Text == ""))
            {
                MessageBox.Show("Por favor seleccione un Hotel primero y luego rellene el formulario Datos para Reservación.");
            }
            else
            {
                BtnSeleccionar.Enabled = true;
                BtnDeseleccionar.Enabled = true;
                BtnReservar.Enabled = true;
            
            //Se declaran las variables para calcular el total del hotel
            double habitaciones = 0, tdias = 0, adultos = 0, niños = 0, total = 0;


            //Se asignan valores a las variables
            habitaciones = double.Parse(cmbHabitaciones.Text);
            adultos = double.Parse(cmbAdultos.Text);
            niños = double.Parse(cmbNiños.Text);

            //Se convierte el tiempo de data time picker a una variable utilizable
            DateTime entrada = dtpEntrada.Value;
            DateTime salida = dtpSalida.Value;
            TimeSpan dias = salida.Subtract(entrada);
            dias.Days.ToString();
            tdias = dias.Days;


            //Se calcula el total del hotel
            if (TxtHoteles.Text == "Hotel RDG")
            {
                if (cmbTipoHabitacion.Text == "Individual")
                {
                    total = ((60 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Doble")
                {
                    total = ((80 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Matrimonial")
                {
                    total = ((90 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else
                {
                    total = ((100 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
            }
            else if (TxtHoteles.Text == "Hotel Nicte")
            {
                if (cmbTipoHabitacion.Text == "Individual")
                {
                    total = ((70 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Doble")
                {
                    total = ((90 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Matrimonial")
                {
                    total = ((100 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else
                {
                    total = ((120 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
            }
            else if (TxtHoteles.Text == "Hotel Holiday Inn")
            {
                if (cmbTipoHabitacion.Text == "Individual")
                {
                    total = ((100 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Doble")
                {
                    total = ((120 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Matrimonial")
                {
                    total = ((130 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else
                {
                    total = ((150 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
            }
            else if (TxtHoteles.Text == "Hotel Globales Camino Real")
            {
                if (cmbTipoHabitacion.Text == "Individual")
                {
                    total = ((110 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Doble")
                {
                    total = ((130 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Matrimonial")
                {
                    total = ((140 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
                else
                {
                    total = ((160 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
            }
            else
            {
                if (cmbTipoHabitacion.Text == "Individual")
                {
                    total = ((240 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Doble")
                {
                    total = ((260 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
                else if (cmbTipoHabitacion.Text == "Matrimonial")
                {
                    total = ((270 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
                else
                {
                    total = ((290 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
            }

            //Se muestran los resultados
            txtTotal.Text = "$" + total;

            //Se bloquea la casilla del total

            }
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            TxtHoteles.Text = "";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtHoteles.Text = dgvHoteles.SelectedCells[0].Value.ToString();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {

        }

        private void cmbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblServicioWIFI_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpHotel_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cmbHabitaciones.Text = "";
            cmbAdultos.Text = "";
            cmbNiños.Text = "";
            cmbTipoHabitacion.Text = "";
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            CboValoracion.Text = "";
            CboWIFI.Text = "";
            CboOpiniones.Text = "";
            CboPiscina.Text = "";
            CboGimnasio.Text = "";
            CboServicioHabitacion.Text = "";
            txtTotal.Text = "";
            cmbHabitaciones.Focus();

        }

        private void TxtHoteles_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
