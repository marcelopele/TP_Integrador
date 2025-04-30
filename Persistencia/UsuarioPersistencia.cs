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

    }
}
