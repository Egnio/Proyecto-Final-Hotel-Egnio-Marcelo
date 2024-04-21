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

        private void button1_Click(object sender, EventArgs e)
        {
            BtnCancelar.Enabled = false;
            BtnNuevaReservacion.Enabled = true;

            

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
                comando.Parameters.AddWithValue("@Código", txtCódigoDeCliente.Text);
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

        }
    }
}
