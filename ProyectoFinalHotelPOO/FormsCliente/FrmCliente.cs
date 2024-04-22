using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

         
            BtnNuevaReservacion.Enabled = false;
            txtTotal.ReadOnly = true;
            txtCodigoDeCliente.ReadOnly = true;
        }

        
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

        }

        private SqlConnection conexion = new SqlConnection("Data Source = localhost; initial catalog = HotelClientes; integrated security = true");

        private DataSet ds;
        public DataTable mostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select * from Clientes", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BtnCancelar.Enabled = false;
            BtnNuevaReservacion.Enabled = true;
            
          
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
            if (cmbHoteles.Text == "Hotel RDG")
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
            else if (cmbHoteles.Text == "Hotel Nicte")
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
            else if (cmbHoteles.Text == "Hotel Holiday Inn Convention Center")
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
            else if (cmbHoteles.Text == "Hotel Globales Camino Real Managua")
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
            txtTotal.ReadOnly = true;

            //Se guardan los datos ingresados por el usuario
            txtCodigoDeCliente.Text = dgvClientes.Rows.Count.ToString();
            if (sql.insertar(txtCodigoDeCliente.Text, txtNombre.Text, txtApellidos.Text, txtNumeroTelefonico.Text, txtCorreoElectronico.Text, txtDireccion.Text, cmbHoteles.Text, cmbHabitaciones.Text, cmbTipoHabitacion.Text, cmbAdultos.Text, cmbNiños.Text, dtpEntrada.Text, dtpSalida.Text, txtTotal.Text))
            {
                MessageBox.Show("¡La reserva se ha completado con éxito!");
                dgvClientes.DataSource = sql.mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al registrar reserva, intente de nuevo.");
            }
       
        }

        private void txtCódigoDeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //btnCancelar_Click
        private void btnReservar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Desea cancelar la reserva? Eliminará todos los datos en el proceso", "Sistema de Planilla",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "delete from Clientes where Código = @Código";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Código", txtCodigoDeCliente.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro de cliente eliminado.");
                dgvClientes.DataSource = sql.mostrarDatos();
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
                if (cmbHoteles.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
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

        private void txtDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre direccion y hoteles
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtDireccion.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su dirección.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbHoteles.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtCorreoElectrónico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre correo electronico y direccion
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCorreoElectronico.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su correo electrónico.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtDireccion.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtNúmeroTelefónico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario solo puede ingresar numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Se habilita la funcion enter entre numero telefonico y correo electronico
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNumeroTelefonico.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su número telefónico.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtCorreoElectronico.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario solo pueda ingresar letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Se habilita la funcion enter entre apellidos y numero telofonico
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtApellidos.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese sus apellidos.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtNumeroTelefonico.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario solo puede ingresar letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //Se habilita la funcion enter entre nombre y apellidos
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNombre.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su nombre.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtApellidos.Focus();
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
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtNumeroTelefonico.Text = "";
            txtCorreoElectronico.Text = "";
            cmbHoteles.Text = "";
            cmbHabitaciones.Text = "";
            cmbTipoHabitacion.Text = "";
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            cmbAdultos.Text = "";
            cmbNiños.Text = "";
            txtTotal.Text = "";
            txtCodigoDeCliente.Text = "";
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            FrmBuscar frm = new FrmBuscar();
            frm.Show();
            this.Hide();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                //Se muestra los datos en el data grid view
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                txtCodigoDeCliente.Text = Convert.ToString(fila.Cells[0].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
                txtApellidos.Text = Convert.ToString(fila.Cells[2].Value);
                txtNumeroTelefonico.Text = Convert.ToString(fila.Cells[3].Value);
                txtCorreoElectronico.Text = Convert.ToString(fila.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[5].Value);
                cmbHoteles.Text = Convert.ToString(fila.Cells[6].Value);
                cmbHabitaciones.Text = Convert.ToString(fila.Cells[7].Value);
                cmbTipoHabitacion.Text = Convert.ToString(fila.Cells[8].Value);
                cmbAdultos.Text = Convert.ToString(fila.Cells[9].Value);
                cmbNiños.Text = Convert.ToString(fila.Cells[10].Value);
                dtpEntrada.Text = Convert.ToString(fila.Cells[11].Value);
                dtpSalida.Text = Convert.ToString(fila.Cells[12].Value);
                txtTotal.Text = Convert.ToString(fila.Cells[13].Value);
            }
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {

        }
    }
}
