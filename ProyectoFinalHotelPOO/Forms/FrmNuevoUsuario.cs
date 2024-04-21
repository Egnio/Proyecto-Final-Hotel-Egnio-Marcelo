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

namespace ProyectoFinalHotelPOO.Forms
{
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        //Se conecta a la base de datos HotelClientes
        SqlConnection conexion = new SqlConnection("Data Source = localhost; initial catalog = HotelClientes; integrated security = true");

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Se regresar al formulario Login
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Se registra un nuevo usuario
            if(conexion.State != ConnectionState.Open)
            {
                try
                {
                    conexion.Open();
                    string revisarUsuario = "Select * from Usuarios where Usuario = '" + txtUsuario.Text.Trim() + "'";

                    using (SqlCommand revisar_Usuario = new SqlCommand(revisarUsuario, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(revisar_Usuario);
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        if(tabla.Rows.Count >= 1)
                        {
                            //Se revisa si el nuevo usuario ya existe
                            MessageBox.Show("El usuario " + txtUsuario.Text + " ya existe. ", "Error Mensaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Se guarda el usario y contraseña
                            string GuardarUsuario = "Insert into Usuarios (Usuario,Contraseña) values (@Usuario,@Contraseña)";

                            using (SqlCommand cmd = new SqlCommand(GuardarUsuario, conexion))
                            {
                                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text.Trim());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Nuevo usuario registrado exitosamente.", "Mensaje de Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Se regresa al formulario login 
                                FrmLogin frm = new FrmLogin();
                                frm.Show();
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex, "Error Mensaje.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que el usuario solo pueda ingresar letras
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsSeparator(e.KeyChar))
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
                    MessageBox.Show("Por favor ingrese un nombre de usuario.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(txtContraseña.Text == "")
                {
                    //Se valida que el usuario no deje la casilla en blanco
                    MessageBox.Show("Por favor ingrese una contraseña.", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = false;
                }
                else
                {
                    btnRegistrar.PerformClick();
                    e.Handled= true;
                }
            }
        }

        private void cB_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            //Botón para mostrar y ocultar la contraseña 
            if(cB_Mostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
