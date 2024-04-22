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
                comando.Parameters.AddWithValue("@Código", txtCodigoDeCliente.Text);
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



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


