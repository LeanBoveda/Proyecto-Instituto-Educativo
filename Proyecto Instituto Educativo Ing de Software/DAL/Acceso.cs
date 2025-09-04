using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Acceso
    {
        private readonly SqlConnection conexion = new SqlConnection();
        void Abrir()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-HC66RN0\\SQLEXPRESS;Initial Catalog=ProyectoGestionAcademica;Integrated Security=True;";
            conexion.Open();
        }
        void Cerrar()
        {
            conexion.Close();
        }
        public DataTable Leer(string st, SqlParameter[] parametros)
        {
            Abrir();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = st,
                    Connection = conexion
                }
            };
            if (parametros != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            adaptador.Fill(tabla);
            Cerrar();
            return tabla;
        }

        public int Escribir(string st, SqlParameter[] parameters)
        {
            int fa;
            Abrir();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexion,
                CommandType = CommandType.StoredProcedure,
                CommandText = st
            };
            cmd.Parameters.AddRange(parameters);

            try
            {
                fa = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                fa = -1;
            }
            Cerrar();
            return fa;
        }

       
    }
}
