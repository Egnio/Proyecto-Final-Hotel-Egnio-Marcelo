﻿using System;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Cerrando sesion
            if(MessageBox.Show("Desear cerrar su sesión", "Reserva de Hoteles Managua", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sesión cerrada.");
                FrmLogin frm = new FrmLogin();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
