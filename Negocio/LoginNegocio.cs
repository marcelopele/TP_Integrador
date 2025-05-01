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

            if (credencial != null && credencial.Contrasena.Equals(password))       // El usuario existe y la clave es correcta
            {
                if (!credencial.Bloqueo)                                            //      Si no está bloqueado:
                {
                    credencial.FechaUltimoLogin = DateTime.Now;                     //      actualiza el último ingreso en el objeto
                    usuarioPersistencia.ActualizarCredencial(credencial);           //      actualiza el último ingreso en el archivo
                    usuarioPersistencia.LimpiarIntentosFallidos(credencial);        //      limpia los intentos fallidos
                }

                salida = credencial;                                                // Devuelve la credencial => Si está bloqueada va a enviar su credencial bloqueada
            }
            else if (credencial != null)                                            // El usuario existe pero la clave es incorrecta
            {
                credencial.IntentosFallidos++;                                      //      sumo el intento fallido en el objeto
                usuarioPersistencia.RegistrarIntentoFallido(credencial);            //      agrega el intento fallido en el archivo

                if (credencial.IntentosFallidos >= 3)                               //      Si llegó a los 3 intentos                             
                {
                    if (!credencial.Bloqueo)                                        //      y aún no está bloqueado
                    {
                        usuarioPersistencia.RegistrarBloqueo(credencial);           //      registra el bloqueo en el archivo
                    }
                }                                                                   // No devuelve la credencial => clave incorrecta va a dar mensaje de "usuario o clave incorrectos"
            }
                                                                                    // El usuario no existe
            return salida;                                                          // No devuelve la credencial => usuario incorrecto va a dar mensaje de "usuario o clave incorrectos"
        }

        public void CambiarClave(Credencial credencial_con_nueva_clave)
        {
            credencial_con_nueva_clave.FechaCambioClave = DateTime.Now;            // Actualiza la fecha de cambio de clave en el objeto
            credencial_con_nueva_clave.PrimerIngreso = false;                      // Cambia el primer ingreso a false
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            usuarioPersistencia.ActualizarCredencial(credencial_con_nueva_clave);
        }

    }
}
