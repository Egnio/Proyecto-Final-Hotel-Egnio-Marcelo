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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        Clientes_Gerente sql = new Clientes_Gerente();

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar la reserva? Eliminará todos los datos en el proceso", "Sistema de Planilla",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string query = "delete from Hoteles where Código = @Código";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Código", TxtHotel.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro de cliente eliminado.");
                dgvClientes.DataSource = sql.mostrarDatos();

            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Se connecta con la base de datos
        //Recordar cambiarlo 
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

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            //Se muestran los datos en el data grid view
            dgvClientes.DataSource = mostrarDatos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter datos = new SqlDataAdapter("Select * from Clientes where Código Like '%" + this.txtCodigoDelCliente.Text + "%'", conexion);
            DataSet ds = new DataSet();
            datos.Fill(ds, "Clientes");
            this.dgvClientes.DataSource = ds.Tables[0];


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevaReservacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar? Perderá todos sus datos de reservación no enviados.", "Sistema de Planilla",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmCliente frm = new FrmCliente();
                frm.Show();
                this.Hide();
            }
           

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Cerrando sesión de gerente
            if (MessageBox.Show(" ¿Desea cerrar su sesión? Recuerde verificar si envío su reserva.", "Reserva de Hoteles Managua", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            txtCodigoDelCliente.Text = dgvClientes.Rows.Count.ToString();
            if (sql.insertar(txtCodigoDelCliente.Text, txtNombre.Text, txtApellidos.Text, txtNumeroTelefonico.Text, txtCorreoElectronico.Text, txtDireccion.Text, TxtHotel.Text, TxtHabitaciones.Text, TxtTipoHabitaciones.Text, TxtAdultos.Text, TxtNiños.Text, TxtEntrada.Text, TxtSalida.Text, TxtTotal.Text))
            {
                MessageBox.Show("Datos registrados satisfacotriamente.");
                dgvClientes.DataSource = sql.mostrarDatos();
            }
            else
            {
                MessageBox.Show("No se registraron los datos.");
            }
            MessageBox.Show("¡Reserva registrada éxitosamente!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "update Clientes Set Código = @Código, Nombre = @Nombre, Apellidos = @Apellidos, Número_Telefónico = @Número_Telefónico, Correo_Electrónico = @Correo_Electrónico, Dirección = @Dirección, Hotel = @Hotel, Habitaciones = @Habitaciones, Tipo_de_habitación = @Tipo_de_habitación, Adultos = @Adultos, Niños = @Niños, Entrada = @Entrada, Salida = @Salida, Total = @Total where Código = @Código ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Código", txtCodigoDelCliente.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@Número_Telefónico", txtNumeroTelefonico.Text);
            comando.Parameters.AddWithValue("@Correo_Electrónico", txtCorreoElectronico.Text);
            comando.Parameters.AddWithValue("@Dirección", txtDireccion.Text);
            comando.Parameters.AddWithValue("@Hotel", TxtHotel.Text);
            comando.Parameters.AddWithValue("@Habitaciones", TxtHabitaciones.Text);
            comando.Parameters.AddWithValue("@Tipo_de_habitación", TxtTipoHabitaciones.Text);
            comando.Parameters.AddWithValue("@Adultos", TxtAdultos.Text);
            comando.Parameters.AddWithValue("@Niños", TxtNiños.Text);
            comando.Parameters.AddWithValue("@Entrada", TxtEntrada.Text);
            comando.Parameters.AddWithValue("@Salida", TxtSalida.Text);
            comando.Parameters.AddWithValue("@Total", TxtTotal.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se han actualizado los datos exitosamente. ");
            dgvClientes.DataSource = sql.mostrarDatos();
        }
    }
}


