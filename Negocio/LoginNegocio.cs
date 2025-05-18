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
        public Credencial Login(String usuario, String password)
        {
            Credencial salida = null;

            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            Credencial credencial = usuarioPersistencia.Login(usuario);

            if (credencial != null && credencial.Contrasena.Equals(password))       // EL USUARIO EXISTE Y LA CLAVE ES CORRECTA
            {
                if (!credencial.Bloqueo)                                            //      Si no está bloqueado:
                {
                    credencial.FechaUltimoLogin = DateTime.Now;                     //          actualiza el último ingreso en el objeto
                    usuarioPersistencia.ActualizarCredencial(credencial);           //          actualiza el último ingreso en el archivo
                    usuarioPersistencia.LimpiarIntentosFallidos(credencial);        //          limpia los intentos fallidos
                }

                salida = credencial;                                                // Devuelve la credencial => Si está bloqueada va a enviar su credencial bloqueada sin registrar el ingreso ni limpiar los intentos fallidos
            }
            else if (credencial != null)                                            // EL USUARIO EXISTE PERO LA CLAVE ES INCORRECTA
            {
                credencial.IntentosFallidos++;                                      //      sumo el intento fallido en el objeto
                usuarioPersistencia.RegistrarIntentoFallido(credencial);            //      agrega el intento fallido en el archivo

                if (credencial.IntentosFallidos >= 3 && !credencial.Bloqueo)        //      Si llegó a los 3 intentos y aún no está bloqueado                     
                {
                        usuarioPersistencia.RegistrarBloqueo(credencial);           //      registra el bloqueo en el archivo
                }                                                                   // Devuelve credencial=null => clave incorrecta va a mostrar mensaje de "usuario o clave incorrectos"
            }
                                                                                    // EL USUARIO NO EXISTE
            return salida;                                                          // Devuelve credencial=null => usuario incorrecto va a mostrar mensaje de "usuario o clave incorrectos"
        }

        public void CambiarClave(Credencial credencial_con_nueva_clave)
        {
            credencial_con_nueva_clave.FechaCambioClave = DateTime.Now;            // Actualiza la fecha de cambio de clave en el objeto
            credencial_con_nueva_clave.PrimerIngreso = false;                      // Cambia el primer ingreso a false
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            usuarioPersistencia.ActualizarCredencial(credencial_con_nueva_clave);
        }

        public List<Credencial> ListCredenciales()
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            List<Credencial> salida = usuarioPersistencia.ListCredenciales();

            return salida;
        }

        public void DesbloquearUsuario(OpeCambioCredencial opeDC)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            usuarioPersistencia.DesbloquearUsuario(opeDC);
        }
    }
}
