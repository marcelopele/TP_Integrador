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
        public Credencial login(String nombreUsuario)
        {
            Credencial credencial = null;

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> registros = dataBaseUtils.BuscarRegistro("credenciales.csv");

            foreach (String registro in registros) {
                String[] campos = registro.Split(';');
                if (campos[1].Equals(nombreUsuario))
                {
                    // Obtengo cantidad de intentos fallidos para enviar al constructor
                    List<String> intentosFallidos = dataBaseUtils.BuscarRegistro("login_intentos.csv");
                    List<String> intentosFallidosUser = intentosFallidos.Where(linea => linea.Split(';')[0].Equals(campos[0])).ToList();
                    int intentos = intentosFallidosUser.Count();

                    // Obtengo si el usuario está bloqueado
                    List<String> bloqueos = dataBaseUtils.BuscarRegistro("usuario_bloqueado.csv");
                    List<String> bloqueosUser = bloqueos.Where(linea => linea.Split(';')[0].Equals(campos[0])).ToList();
                    Boolean bloqueo = false;
                    if (bloqueosUser.Count > 0) 
                    {
                        bloqueo = true;
                    }

                    // Obtengo el perfil del usuario
                    List<String> Perfiles = dataBaseUtils.BuscarRegistro("usuario_perfil.csv");
                    int usuarioPerfil=0;
                    foreach (String PerfilUser in Perfiles)
                    {
                        String[] camposPerfilUser = PerfilUser.Split(';');
                        if (camposPerfilUser[0].Equals(campos[0]))
                        {
                            usuarioPerfil = Int32.Parse(camposPerfilUser[1]);
                            break;
                        }
                    }
                    // Obtengo la descripción del perfil
                    List<String> PerfilesDescripciones = dataBaseUtils.BuscarRegistro("perfil.csv");
                    String descripcionPerfil = "";
                    foreach (String Perfil in PerfilesDescripciones)
                    {
                        String[] camposPerfil = Perfil.Split(';');
                        if (camposPerfil[0].Equals(usuarioPerfil.ToString()))
                        {
                            descripcionPerfil = camposPerfil[1];
                            break;
                        }
                    }

                    // Obtengo los roles del usuario y la denominación de cada rol
                    List<String> Roles = dataBaseUtils.BuscarRegistro("perfil_rol.csv");
                    List<Roles> roles = new List<Roles>();
                    foreach (String RolNro in Roles) {
                        String[] camposRolNro = RolNro.Split(';');
                        if (camposRolNro[0].Equals(usuarioPerfil.ToString()))
                        {
                            List<String> RolesDescripciones = dataBaseUtils.BuscarRegistro("rol.csv");
                            foreach (String Rol in RolesDescripciones)
                            {
                                String[] camposRol = Rol.Split(';');
                                if (camposRol[0].Equals(camposRolNro[1]))
                                {
                                    roles.Add(new Roles(Int32.Parse(camposRol[0]), camposRol[1]));
                                    break;
                                }
                            }
                        }
                    }

                    credencial = new Credencial(registro, intentos, bloqueo, descripcionPerfil, roles);
                    break;
                }
            }
            return credencial;
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
