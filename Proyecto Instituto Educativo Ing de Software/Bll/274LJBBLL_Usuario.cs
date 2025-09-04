using DAL;
using Seguridad;
using Sevicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class _274LJBBLL_Usuario
    {
       private readonly _274LJBmp_Usuario mp = new _274LJBmp_Usuario();
        public void RegistrarUsuario(_274LJBUsuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.Contraseña))
                throw new Exception("La contraseña no puede estar vacía.");

            if (usuario.Rol != "Docente" && usuario.Rol != "Preceptor" && usuario.Rol != "Administrativo")
                throw new Exception("Rol no válido.");
            if (mp.ExisteDNI(usuario.DNI))
                throw new Exception("Ya existe un usuario con ese DNI.");
            if(mp.ExisteUsuario(usuario.NombreUsuario))
                throw new Exception("Ya existe un usuario con ese nombre de usuario.");

            usuario.Contraseña = Seguridad.Seguridad.EncriptarSHA256(usuario.Nombre + usuario.DNI);
            usuario.DebeCambiarClave = true; 
            mp.Agregar(usuario);
        }
        public void ModificarUsuario(_274LJBUsuario usuario)
        {
            if (usuario.ID <= 0)
                throw new Exception("ID de usuario inválido.");

            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                throw new Exception("Nombre de usuario obligatorio.");
            

            mp.ModificarUsuario(usuario);
        }
        public void EliminarUsuario(string dni)
        {
            
            mp.EliminarUsuario(dni);
        }
        public DataTable ListarUsuarios()
        {
            return mp.ListarUsuarios();
        }
        public _274LJBUsuario LoginSeguro(string nombreUsuario, string contraseña)
        {
            string hash = Seguridad.Seguridad.EncriptarSHA256(contraseña);
            _274LJBUsuario usuario = mp.LoginSeguro(nombreUsuario, hash);

            if (usuario == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            if (!usuario.Activo)
                throw new Exception("El usuario está inactivo.");

            if (usuario.Bloqueado)
                throw new Exception("El usuario está bloqueado.");
            if(usuario.DebeCambiarClave==true)
                throw new Exception("Debe cambiar su contraseña al iniciar sesión por primera vez.");

            return usuario;
        }
        public void DesbloquearUsuario(int id)
        {
            mp.Desbloquear(id);
        }
        public void Activar(int id)
        {
            mp.Activar(id);
        }
        public void Desactivar(int id)
        {
            mp.Desactivar(id);
        }
        public void BloquearUsuario(int id)
        {
            mp.Bloquear(id);
        }
        public void CambiarContraseña(int id, string actualPlano, string nuevaPlano)
        {
            string actualHash = Seguridad.Seguridad.EncriptarSHA256(actualPlano);
            string nuevaHash = Seguridad.Seguridad.EncriptarSHA256(nuevaPlano);

            if (actualHash == nuevaHash)
                throw new Exception("La nueva contraseña no puede ser igual a la actual.");

            mp.CambiarContraseña(id, actualHash, nuevaHash);
        }
        public void ReestablecerContraseña(string nombreUsuario, string dni, string nuevaPlano)
        {
            string nuevaHash = Seguridad.Seguridad.EncriptarSHA256(nuevaPlano);

            if (string.IsNullOrWhiteSpace(nuevaPlano) || nuevaPlano.Length < 6)
                throw new Exception("La nueva contraseña debe tener al menos 6 caracteres.");

            mp.ReestablecerContraseña(nombreUsuario, dni, nuevaHash);
        }

    }
}
