using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinalHotelPOO.FormsGerente
{
    class Clientes_Gerente
    {
        //Se connecta con la base de datos
        //Recordar cambiarlo 
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

        public bool insertar(string codigo, string nombre, string apellidos, string numero_telefonico, string correo_electronico, string direccion, string hotel, string habitaciones, string tipo_de_habitacion, string adultos, string ninos, string entrada, string salida, string total)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Clientes values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", new string[] { codigo, nombre, apellidos, numero_telefonico, correo_electronico, direccion, hotel, habitaciones, tipo_de_habitacion, adultos, ninos, entrada, salida, total }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if(filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class ClientesGerente
    {
    }
}
