using ProyectoFinalHotelPOO.FormsGerente;
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
    public partial class FrmGerente : Form
    {
        public FrmGerente()
        {
            InitializeComponent();
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
        Clientes_Gerente sql = new Clientes_Gerente();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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
            if(cmbHoteles.Text == "Hotel RDG")
            {
                if(cmbTpoHabitación.Text == "Individual")
                {
                    total = ((60 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else if(cmbTpoHabitación.Text == "Doble")
                {
                    total = ((80 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else if(cmbTpoHabitación.Text == "Matrimonial")
                {
                    total = ((90 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
                else
                {
                    total = ((100 * habitaciones) + (adultos * 20) + (niños * 10)) * tdias;
                }
            }
            else if(cmbHoteles.Text == "Hotel Nicte")
            {
                if (cmbTpoHabitación.Text == "Individual")
                {
                    total = ((70 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Doble")
                {
                    total = ((90 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Matrimonial")
                {
                    total = ((100 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
                else
                {
                    total = ((120 * habitaciones) + (adultos * 25) + (niños * 15)) * tdias;
                }
            }
            else if(cmbHoteles.Text == "Hotel Holiday Inn Convention Center")
            {
                if (cmbTpoHabitación.Text == "Individual")
                {
                    total = ((100 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Doble")
                {
                    total = ((120 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Matrimonial")
                {
                    total = ((130 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
                else
                {
                    total = ((150 * habitaciones) + (adultos * 40) + (niños * 25)) * tdias;
                }
            }
            else if(cmbHoteles.Text == "Hotel Globales Camino Real Managua")
            {
                if (cmbTpoHabitación.Text == "Individual")
                {
                    total = ((110 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Doble")
                {
                    total = ((130 * habitaciones) + (adultos * 45) + (niños * 30)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Matrimonial")
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
                if (cmbTpoHabitación.Text == "Individual")
                {
                    total = ((240 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Doble")
                {
                    total = ((260 * habitaciones) + (adultos * 60) + (niños * 40)) * tdias;
                }
                else if (cmbTpoHabitación.Text == "Matrimonial")
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
            txtCódigoDeCliente.Text = dgvClientes.Rows.Count.ToString();
            if(sql.insertar(txtCódigoDeCliente.Text, txtNombre.Text, txtApellidos.Text, txtNúmeroTelefónico.Text, txtCorreoElectrónico.Text, txtDirección.Text, cmbHoteles.Text, cmbHabitaciones.Text, cmbTpoHabitación.Text, cmbAdultos.Text, cmbNiños.Text, dtpEntrada.Text, dtpSalida.Text, txtTotal.Text))
            {
                MessageBox.Show("Datos registrados satisfacotriamente.");
                dgvClientes.DataSource = sql.mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se registraron los datos.");
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se muestra los datos en el data grid view
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            txtCódigoDeCliente.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellidos.Text = Convert.ToString(fila.Cells[2].Value);
            txtNúmeroTelefónico.Text = Convert.ToString(fila.Cells[3].Value);
            txtCorreoElectrónico.Text = Convert.ToString(fila.Cells[4].Value);
            txtDirección.Text = Convert.ToString(fila.Cells[5].Value);
            cmbHoteles.Text = Convert.ToString(fila.Cells[6].Value);
            cmbHabitaciones.Text = Convert.ToString(fila.Cells[7].Value);
            cmbTpoHabitación.Text = Convert.ToString(fila.Cells[8].Value);
            cmbAdultos.Text = Convert.ToString(fila.Cells[9].Value);
            cmbNiños.Text = Convert.ToString(fila.Cells[10].Value);
            dtpEntrada.Text = Convert.ToString(fila.Cells[11].Value);
            dtpSalida.Text = Convert.ToString(fila.Cells[12].Value);
            txtTotal.Text = Convert.ToString(fila.Cells[13].Value);
        }

        //Se connecta con la base de datos
        //Recordar cambiarlo a localhost
        private SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-HGB0OD39\\SQLEXPRESS; initial catalog = HotelClientes; integrated security = true");

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

        private void FrmGerente_Load(object sender, EventArgs e)
        {
            //Se muestran los datos en el data grid view
            dgvClientes.DataSource = mostrarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Se editan los datos de un cliente
            string query = "update Clientes Set Código = @Código, Nombre = @Nombre, Apellidos = @Apellidos, Número_Telefónico = @Número_Telefónico, Correo_Electrónico = @Correo_Electrónico, Dirección = @Dirección, Hotel = @Hotel, Habitaciones = @Habitaciones, Tipo_de_habitación = @Tipo_de_habitación, Adultos = @Adultos, Niños = @Niños, Entrada = @Entrada, Salida = @Salida, Total = @Total where Código = @Código ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Código", txtCódigoDeCliente.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@Número_Telefónico", txtNúmeroTelefónico.Text);
            comando.Parameters.AddWithValue("@Correo_Electrónico", txtCorreoElectrónico.Text);
            comando.Parameters.AddWithValue("@Dirección", txtDirección.Text);
            comando.Parameters.AddWithValue("@Hotel", cmbHoteles.Text);
            comando.Parameters.AddWithValue("@Habitaciones", cmbHabitaciones.Text);
            comando.Parameters.AddWithValue("@Tipo_de_habitación", cmbTpoHabitación.Text);
            comando.Parameters.AddWithValue("@Adultos", cmbAdultos.Text);
            comando.Parameters.AddWithValue("@Niños", cmbNiños.Text);
            comando.Parameters.AddWithValue("@Entrada", dtpEntrada.Text);
            comando.Parameters.AddWithValue("@Salida", dtpSalida.Text);
            comando.Parameters.AddWithValue("@Total", txtTotal.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se han actualizado los datos exitosamente. ");
            dgvClientes.DataSource = sql.mostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se eliminan los dato de un cliente
            string query = "delete from Clientes where Código = @Código";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Código", txtCódigoDeCliente.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro de cliente eliminado.");
            dgvClientes.DataSource = sql.mostrarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se busca al cliente segun su codigo
            SqlDataAdapter datos = new SqlDataAdapter("Select * from Clientes where Código Like '%" + this.txtCódigoDeCliente.Text + "%'", conexion);
            DataSet ds = new DataSet();
            datos.Fill(ds, "Clientes");
            this.dgvClientes.DataSource = ds.Tables[0];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se limpian las casillas
            txtNombre.Clear();
            txtApellidos.Clear();
            txtNúmeroTelefónico.Clear();
            txtCorreoElectrónico.Clear();
            txtDirección.Clear();
            txtCódigoDeCliente.Clear();
            cmbHoteles.Text = "";
            cmbHabitaciones.Text = "";
            cmbTpoHabitación.Text = "";
            cmbAdultos.Text = "";
            cmbNiños.Text = "";
            dtpEntrada.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            txtTotal.Clear();
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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

            //Se habilita la funcion enter entre apellidos y numero telefonico
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtApellidos.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese sus apellidos.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtNúmeroTelefónico.Focus();
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
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtNúmeroTelefónico.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su número telefónico.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtCorreoElectrónico.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtCorreoElectrónico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre correo electronico y direccion
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtCorreoElectrónico.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su correo electrónico.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtDirección.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtDirección_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre direccion y hoteles
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtDirección.Text == "")
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

        private void cmbHoteles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre hoteles y habitaciones
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(cmbHoteles.Text == "")
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

        private void cmbHabitaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre habitacion y tipo de habitacion
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(cmbHabitaciones.Text == "")
                {
                    //Se valida que el usario no deje la casilla en blanco
                    MessageBox.Show("Por favor seleccione al menos una habitación.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    cmbTpoHabitación.Focus();
                    e.Handled = true;
                }
            }
        }

        private void cmbTpoHabitación_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre tipo de habitacion y adultos
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(cmbTpoHabitación.Text == "")
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

        private void cmbAdultos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre adultos y niños
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(cmbAdultos.Text == "0")
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

        private void cmbNiños_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre niños y la fecha de entrada
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpEntrada.Focus();
                e.Handled = true;
            }
        }

        private void dtpEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la funcion enter entre la fecha de entra y la fecha de salida
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Se convierte el data time picker a variables utilizables
                DateTime entrada = dtpEntrada.Value;
                DateTime salida = dtpSalida.Value;
                if (entrada > salida)
                {
                    //Se valida que el usario seleccione un tiempo de entrada apropiado
                    MessageBox.Show("Por favor seleccione una fecha de entrada apropiada.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    dtpSalida.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtCódigoDeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usario solo pueda ingresar numeros
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
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
