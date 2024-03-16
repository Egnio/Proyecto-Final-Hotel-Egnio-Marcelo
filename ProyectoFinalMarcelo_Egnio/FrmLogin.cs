using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalMarcelo_Egnio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se declaran las variables para el inicio de sesion
            string usuario = "", contrasena = "";

            usuario = txtUsuario.Text;
            contrasena = txtContraseña.Text;

            if(usuario == "Marcelo" && contrasena == "12345")
            {
                MessageBox.Show("Bienvendio.");
                this.Hide();
                FrmCliente frm = new FrmCliente();
                frm.ShowDialog();
            }
            else if(usuario == "Egnio" && contrasena == "67890")
            {
                MessageBox.Show("Bienvenido.");
                this.Hide();
                FrmGerente frm = new FrmGerente();
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para cerrar la aplicacin
            Application.Exit();
        }
    }
}
