using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using Persistencia.DataBase;

namespace Negocio
{
    public class PersonaNegocio
    {
        PersonaPersistencia personaPersistencia = new PersonaPersistencia();

        public List<Persona> ListPersonas()
        {
            List<Persona> salida = personaPersistencia.ListPersonas();

            return salida;
        }

        public void ActualizarPersona(Persona persona)
        {
            personaPersistencia.ActualizarPersona(persona);

        }
    }
}
