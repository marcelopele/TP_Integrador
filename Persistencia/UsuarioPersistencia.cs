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
                    List<String> intentosFallidos = dataBaseUtils.BuscarRegistro("login_intentos.csv");
                    List<String> intentosFallidosUser = intentosFallidos.Where(linea => linea.Split(';')[0].Equals(campos[0])).ToList();

                    List<String> bloqueos = dataBaseUtils.BuscarRegistro("usuario_bloqueado.csv");
                    List<String> bloqueosUser = bloqueos.Where(linea => linea.Split(';')[0].Equals(campos[0])).ToList();
                    Boolean bloqueo = false;
                    if (bloqueosUser.Count > 0) 
                    {
                        bloqueo = true;
                    }

                    credencial = new Credencial(registro, intentosFallidosUser.Count(), bloqueo);
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
