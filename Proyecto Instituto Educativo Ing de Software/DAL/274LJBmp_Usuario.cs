using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sevicios;

namespace DAL
{
    public class _274LJBmp_Usuario
    {
        private readonly Acceso datos = new Acceso();
        public void Agregar(_274LJBUsuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@Nombre", usuario.Nombre),
            new SqlParameter("@Apellido", usuario.Apellido),
            new SqlParameter("@NombreUsuario", usuario.NombreUsuario),
            new SqlParameter("@Contraseña", usuario.Contraseña),
            new SqlParameter("@Rol", usuario.Rol),
            new SqlParameter("@DNI", usuario.DNI)
        };
            datos.Escribir("PA_Usuario_Agregar", parametros);
        }
        public void ModificarUsuario(_274LJBUsuario usuario)
        {
            SqlParameter[] parametros = new SqlParameter[] {
        new SqlParameter("@ID", usuario.ID),
        new SqlParameter("@Nombre", usuario.Nombre),
        new SqlParameter("@Apellido", usuario.Apellido),
        new SqlParameter("@NombreUsuario", usuario.NombreUsuario),
        new SqlParameter("@DNI", usuario.DNI),
        new SqlParameter("@Activo", usuario.Activo)
    };
            datos.Escribir("PA_Usuario_Modificar", parametros);
        }
        public void EliminarUsuario(string dni)
        {
            SqlParameter[] parametros = new SqlParameter[] {
        new SqlParameter("@DNI", dni)
    };
            datos.Escribir("PA_Usuario_Eliminar", parametros);
        }
        public DataTable ListarUsuarios()
        {
            SqlParameter[] parametros = { };
            return datos.Leer("PA_UsuarioListar", parametros);
        }
        public void Desbloquear(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@ID", id)
        };
            datos.Escribir("PA_Usuario_Desbloquear", parametros);
        }
        public void Bloquear(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@ID", id)
        };
            datos.Escribir("PA_Usuario_Bloquear", parametros);
        }
        public void Activar(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@ID", id)
        };
            datos.Escribir("PA_Usuario_Activar", parametros);
        }
        public void Desactivar(int id)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@ID", id)
        };
            datos.Escribir("PA_Usuario_desactivar", parametros);
        }
        public void CambiarContraseña(int id, string actual, string nueva)
        {
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@ID", id),
                new SqlParameter("@ContraseñaActual", actual),
                new SqlParameter("@NuevaContraseña", nueva)
                };
            datos.Escribir("PA_Usuario_CambiarContraseña", parametros);
        }
        public _274LJBUsuario LoginSeguro(string usuario, string contraseñaHash)
        {
            SqlParameter[] parametros = new SqlParameter[] {
        new SqlParameter("@NombreUsuario", usuario),
        new SqlParameter("@Contraseña", contraseñaHash)
    };

            try
            {
                DataTable tabla = datos.Leer("PA_Usuario_LoginSeguro", parametros);
                if (tabla.Rows.Count == 0) return null;

                DataRow fila = tabla.Rows[0];
                return new _274LJBUsuario
                {
                    ID = Convert.ToInt32(fila["ID"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    NombreUsuario = usuario,
                    Rol = fila["Rol"].ToString(),
                    Bloqueado = Convert.ToBoolean(fila["Bloqueado"]),
                    Activo = Convert.ToBoolean(fila["Activo"]),
                    DebeCambiarClave = Convert.ToBoolean(fila["DebeCambiarClave"]),
                };
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                    throw new Exception(ex.Message); 
                else
                    throw;
            }
        }
        public void ReestablecerContraseña(string nombreUsuario, string dni, string nuevaContraseña)
        {
            SqlParameter[] parametros = new SqlParameter[] {
        new SqlParameter("@NombreUsuario", nombreUsuario),
        new SqlParameter("@DNI", dni),
        new SqlParameter("@NuevaContraseña", nuevaContraseña)
    };

            datos.Escribir("PA_Usuario_ReestablecerContraseña", parametros);
        }
      
        
        public bool ExisteDNI(string dni)
        {
            SqlParameter[] param = { new SqlParameter("@DNI", dni) };
            DataTable tabla = datos.Leer("PA_Usuario_ExisteDNI", param);
            return tabla.Rows.Count > 0;
        }
        public bool ExisteUsuario(string NombreUsuario)
        {
            SqlParameter[] param = { new SqlParameter("@UsuarioNombre", NombreUsuario) };
            DataTable tabla = datos.Leer("PA_Usuario_ExisteUsuario", param);
            return tabla.Rows.Count > 0;
        }
    }
}
