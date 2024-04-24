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
    public partial class VerHoteles : Form
    {
        public VerHoteles()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-HGB0OD39\\SQLEXPRESS; initial catalog = HotelClientes; integrated security = true");

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerHoteles_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Hoteles";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvHoteles.DataSource = dt;
        }

        private void grpHotel_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CboValoracion.Text == "" && CboWIFI.Text == "" && CboPiscina.Text == "" && CboGimnasio.Text == "" && CboServicioHabitacion.Text == "" && CboOpiniones.Text == "")
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
                string query = "Select * from Hoteles where Valoración = '" + CboValoracion.Text + "' " + "Select * from Hoteles where Opiniones = '" + CboOpiniones.Text + "' " + "Select * from Hoteles where ServicioWIFI = '" + CboWIFI.Text + "' " + "Select * from Hoteles where Piscina = '" + CboPiscina.Text + "' " + "Select * from Hoteles where Gimnasio = '" + CboGimnasio.Text + "' " + "Select * from Hoteles where ServicioHabitación = '" + CboServicioHabitacion.Text + "' ";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla); //Error solucionado!!
                dgvHoteles.DataSource = tabla;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmGerente frm = new FrmGerente();
            frm.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CboValoracion.Text = "";
            CboWIFI.Text = "";
            CboOpiniones.Text = "";
            CboPiscina.Text = "";
            CboGimnasio.Text = "";
            CboServicioHabitacion.Text = "";
            CboValoracion.Focus();
        }
    }
}
