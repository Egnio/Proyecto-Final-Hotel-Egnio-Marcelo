using ProyectoFinalHotelPOO.Forms;
using ProyectoFinalHotelPOO.FormsCliente;
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

namespace ProyectoFinalHotelPOO
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Se conecta a la base de datos HotelClientes
        SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-HGB0OD39\\SQLEXPRESS; initial catalog = HotelClientes; integrated security = true");
        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            //Se declara la barra de progreso
            pbrLogin.Value = pbrLogin.Value + 4;

            if (pbrLogin.Value > 99)
            {
                //Se muestra el formulario para el gerente
                if(txtUsuario.Text == "Egnio" && txtContraseña.Text == "67890")
                {
                    FrmGerente frm = new FrmGerente();
                    frm.Show();
                    this.Hide();
                    tmrLogin.Enabled = false;
                    btnIngresar.Enabled = false;
                    
                }
                else if (txtUsuario.Text == "Marcelo" && txtContraseña.Text == "12345")
                {
                    FrmCliente frm = new FrmCliente();
                    frm.Show();
                    this.Hide();
                    tmrLogin.Enabled = false;
                    btnIngresar.Enabled = false;
                }

                //Se busca el usuario en la base de datos
                conexion.Open();
                string EscogerUsuario = "Select * from Usuarios where Usuario = @Usuario and Contraseña = @Contraseña";
                using (SqlCommand cmd = new SqlCommand(EscogerUsuario, conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count >= 1)
                    {
                        //Se muestra el formulario para el cliente
                        FrmCliente frm = new FrmCliente();
                        frm.Show();
                        this.Hide();
                        tmrLogin.Enabled = false;
                    }
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se verifica el usuario y contraseña para clientes
            if(conexion.State != ConnectionState.Open)
            {
                try
                {
                    //Se busca el usuario en la base de datos
                    conexion.Open();
                    string EscogerUsuario = "Select * from Usuarios where Usuario = @Usuario and Contraseña = @Contraseña";
                    using(SqlCommand cmd = new SqlCommand(EscogerUsuario, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        if(tabla.Rows.Count >= 1)
                        {
                            //Se activa la barra de progreso y contador
                            tmrLogin.Enabled = true;
                            pbrLogin.Value = 0;
                        }
                        
                        else if(txtUsuario.Text == "Egnio" && txtContraseña.Text == "67890") 
                        {
                            //Se activa la barra de progreso y contador
                            tmrLogin.Enabled = true;
                            pbrLogin.Value = 0;
                        }
                        else if (txtUsuario.Text == "Marcelo" && txtContraseña.Text == "12345")
                        {
                            tmrLogin.Enabled = true;
                            pbrLogin.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrecta. ", "Error Mensaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Iniciando Sesión: " + ex, "Error Mensaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
            //Bloquea el botón ingresar una vez se ha iniciado sesión
            btnIngresar.Enabled = false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Se sale del programa
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario solo puede ingresar letras
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
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

            //Se habilita la función enter entre usuario y contraseña
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtUsuario.Text == "")
                {
                    //Se valida que el usuario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su usuario.", "Requerido",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    txtContraseña.Focus();
                    e.Handled = true;
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se habilita la función enter entre contraseña y el botón ingresar
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtContraseña.Text == "")
                {
                    //Se valida que el usuario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese su contraseña.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    btnIngresar.PerformClick();
                    e.Handled = true;
                }
            }
        }

        private void cB_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            //Botón para mostrar y ocultar la contraseña 
            if (cB_Mostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            //Se muestra el formulario para crear un nuevo usuario
            FrmNuevoUsuario frm = new FrmNuevoUsuario();
            frm.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
