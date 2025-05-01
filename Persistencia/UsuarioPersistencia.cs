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
        public Credencial login(String username)
        {
            Credencial credencial = null;

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> registros = dataBaseUtils.BuscarRegistro("credenciales.csv");
            
            foreach(String registro in registros) {
                String[] campos = registro.Split(';');
                if (campos[1].Equals(username))
                {
                    credencial = new Credencial(registro);
                    break;
                }
            }
            return credencial;
        }

        public void BloquearUsuario(String usuario)
        {
            //Actualizar el estado del usuario a bloqueado
            //Persistir
        }

        public void ActualizarIngreso(Credencial credencial)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.ModificarRegistro("credenciales.csv", 1, credencial.NombreUsuario, credencial.ToStringCSV());

        }


    }
}
