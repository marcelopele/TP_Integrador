using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia.DataBase;

namespace Persistencia
{
    public class PersonaPersistencia
    {

        public List<Persona> ListPersonas()
        {
            List<Persona> salida = new List<Persona>();

            DataBaseUtils dataBaseUtils = new DataBaseUtils();

            List<String> lstPersonas = dataBaseUtils.BuscarRegistrosPorValor("persona.csv", -1, "");
            if (lstPersonas.Count() > 0)
            {
                foreach (String persona in lstPersonas)        //   Recorre la lista de personas
                {
                    salida.Add(new Persona(persona));
                }
            }
            
            return salida;
        }

        public void ActualizarPersona(Persona persona)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.ModificarRegistro("persona.csv", 0, persona.Legajo, persona.ToStringCSV());

        }


    }
}
