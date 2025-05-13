using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia.DataBase;

namespace Persistencia
{
    public class UsuarioPersistencia
    {
        public Credencial Login(String nombreUsuario)
        {
            Credencial salida=null;

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> lstCredenciales = dataBaseUtils.BuscarRegistrosPorValor("credenciales.csv", 1, nombreUsuario);                     // OBTENGO DATOS PARA INSTANCIAR LA CREDENCIAL
            if (lstCredenciales.Count() > 0)                                                                                                // (solo si encuentra reistro con nombreUsuario sino queda salida = null)
            {
                String strCredencial = lstCredenciales[0];                                                                                      // 1. String con fila del arcivo para enviar al constructor
                String[] camposCredencial = strCredencial.Split(';');

                List<String> intentosFallidosUser = dataBaseUtils.BuscarRegistrosPorValor("login_intentos.csv", 0, camposCredencial[0]);        // 2. Cantidad de intentos fallidos
                int intentos = intentosFallidosUser.Count();

                List<String> bloqueosUser = dataBaseUtils.BuscarRegistrosPorValor("usuario_bloqueado.csv", 0, camposCredencial[0]);             // 3. Si está bloqueado
                Boolean bloqueo = false;
                if (bloqueosUser.Count() > 0)
                {
                    bloqueo = true;
                }

                String strUsuarioPerfil = dataBaseUtils.BuscarValor("usuario_perfil.csv", 0, camposCredencial[0], 1);                           // 4. Denominación del perfil de usuario
                int usuarioPerfil = 0;
                if (int.TryParse(strUsuarioPerfil, out int result))
                {
                    usuarioPerfil = result;                                                                                                     //      idPerfil
                }
                String descripcionPerfil = dataBaseUtils.BuscarValor("perfil.csv", 0, usuarioPerfil.ToString(), 1);                             //      denominación


                List<Roles> roles = new List<Roles>();                                                                                          // 5. Lista de roles para el perfil de usuario
                List<String> Roles = dataBaseUtils.BuscarRegistrosPorValor("perfil_rol.csv", 0, usuarioPerfil.ToString());                      //      Obtiene los roles del archivo peril_rol.csv ya filtrados por el idPerfil
                foreach (String Rol in Roles)                                                                                                   //      Recorre la lista de roles
                {
                    String[] camposRol = Rol.Split(';');
                    int idRol = Int32.Parse(camposRol[1]);                                                                                      //      idRol
                    String denRol = dataBaseUtils.BuscarValor("rol.csv", 0, idRol.ToString(), 1);                                               //      denominación del rol con el archivo rol.csv
                    roles.Add(new Roles(idRol, denRol));                                                                                        //      construye el objeto Roles y lo agrega a la lista
                }
                salida = new Credencial(strCredencial, intentos, bloqueo, descripcionPerfil, roles);                                            //  Instancia la credencial con los datos obtenidos
            }
            return salida;
        }

        public void ActualizarCredencial(Credencial credencial)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.ModificarRegistro("credenciales.csv", 1, credencial.NombreUsuario, credencial.ToStringCSV());

        }

        public void RegistrarIntentoFallido(Credencial credencial)
        {
            String registro = credencial.Legajo + ";" + DateTime.Now.ToString("dd/MM/yyyy");

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.AgregarRegistro("login_intentos.csv", registro);

        }

        public void LimpiarIntentosFallidos(Credencial credencial)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.EliminarRegistros("login_intentos.csv", 0, credencial.Legajo);
        }

        public void RegistrarBloqueo(Credencial credencial)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.AgregarRegistro("usuario_bloqueado.csv", credencial.Legajo);
        }



    }
}
