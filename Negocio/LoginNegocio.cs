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
            Credencial salida = null;

            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            Credencial credencial = usuarioPersistencia.login(usuario);

            //Si el usuario existe y coincide la clave actualiza fecha de login
            if (credencial != null && credencial.Contrasena.Equals(password))
            {
                credencial.FechaUltimoLogin = DateTime.Now;
                usuarioPersistencia.ActualizarIngreso(credencial);

                salida = credencial;
            }
            //Si el usuario existe pero no coincide la clave registrar intento fallido
            //Si hay 3 o más intentos fallidos ver que esté en usuario_bloqueado.csv
            else if (credencial != null)
            {



            }

            return salida;
        }

        public Boolean EsUsuarioBloqueado(String usuario)
        {
            Boolean salida = false;



            return salida;
        }



    }
}
