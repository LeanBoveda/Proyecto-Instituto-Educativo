using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class _274LJBmp_alumnos
    {
        private Acceso acceso = new Acceso();
        public int AgregarA(_274LJBAlumno alumno)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", SqlDbType.VarChar) { Value = alumno._274LJBDNI },
                new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = alumno._274LJBNombre },
                new SqlParameter("@Apellido", SqlDbType.VarChar) { Value = alumno._274LJBApellido },
                new SqlParameter("@FechaNacimiento", SqlDbType.DateTime) { Value = alumno._274LJBFechaNacimiento },
                new SqlParameter("@Direccion", SqlDbType.VarChar) { Value = alumno._274LJBDireccion},
                new SqlParameter("@Telefono", SqlDbType.VarChar) { Value = alumno._274LJBTelefono}
                
            };
            return acceso.Escribir("PA_Alumno_Insertar", parametros);
        }
        public int ModificarA(_274LJBAlumno alumno)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", SqlDbType.VarChar) {Value = alumno._274LJBDNI},
                new SqlParameter("@Nombre", SqlDbType.VarChar) {Value = alumno._274LJBNombre },
                new SqlParameter("@Apellido", SqlDbType.VarChar) {Value = alumno._274LJBApellido },
                new SqlParameter("@FechaNacimiento", SqlDbType.DateTime) { Value = alumno._274LJBFechaNacimiento },
                new SqlParameter("@Direccion", SqlDbType.VarChar) { Value = alumno._274LJBDireccion},
                new SqlParameter("@Telefono", SqlDbType.VarChar) {Value = alumno._274LJBTelefono }
            };
            return acceso.Escribir("PA_Alumno_Modificar", parametros);
        }
        public int EliminarA(string dni)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", SqlDbType.VarChar) { Value = dni }
            };
            return acceso.Escribir("PA_Alumno_Eliminar", parametros);
        }
        public DataTable Listar()
        {
            SqlParameter[] parametros = { };
            return acceso.Leer("PA_Alumno_Listar", parametros);
        }
        public DataTable BuscarPorDNI(string dni)
        {
            SqlParameter[] parametros = {
        new SqlParameter("@DNI", dni)
    };
            return acceso.Leer("PA_Alumno_BuscarPorDNI", parametros);
        }
    }
}
