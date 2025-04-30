using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class LoginNegocio
    {
        public Credencial login(String usuario, String password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();

            Credencial credencial = usuarioPersistencia.login(usuario);

            if (credencial != null)
            {
                if (credencial.Contrasena.Equals(password))
                {
                    return credencial;
                }
            }
            return null;
        }
    }
}
