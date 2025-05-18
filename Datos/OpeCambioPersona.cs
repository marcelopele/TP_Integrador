using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Datos
{
    public class OpeCambioPersona:Operacion
    {
        //Atributos
        private String _legajo;
        private String _nombre;
        private String _apellido;
        private int _dni;
        private DateTime _fechaIngreso;


        //Propiedades
        public String Legajo { get => _legajo; set => _legajo = value; }
        public String Nombre { get => _nombre; set => _nombre = value; }
        public String Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }


        //Constructor
        public OpeCambioPersona(String registro1, String registro2)
        {
            String[] datos1 = registro1.Split(';');
            String[] datos2 = registro2.Split(';');

            if (datos1[0] == datos2[0])
            {
                // Clase padre
                base.IdOperacion = datos1[0];
                base.TipoOperacion = datos1[1];
                base._estado = datos1[2];
                base.LegajoSolicitante = datos1[3];
                if (DateTime.TryParseExact(datos1[4], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaSolicitud))
                {
                    base.FechaSolicitud = fechaSolicitud;
                }
                base.LegajoAutorizador = datos1[5];
                if (DateTime.TryParseExact(datos1[6], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaAutorizacion))
                {
                    base.FechaAutorizacion = fechaAutorizacion;
                }

                // Clase hijo
                this.Legajo = datos2[1];
                this.Nombre = datos2[2];
                this.Apellido = datos2[3];
                this.Dni = Int32.Parse(datos2[4]);
                if (DateTime.TryParseExact(datos2[5], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaIngreso))
                {
                    this.FechaIngreso = fechaIngreso;
                }
            }
        }

        public String ToStringOpeCambioPersonaCSV()
        {
            String idOperacion = this.IdOperacion;
            String legajo = this.Legajo;
            String nombre = this.Nombre;
            String apellido = this.Apellido;
            String dni = this.Dni.ToString();
            String fechaIngreso = this.FechaIngreso.ToString("dd/MM/yyyy");

            return idOperacion + ";" +
                   legajo + ";" +
                   nombre + ";" +
                   apellido + ";" +
                   dni + ";" +
                   fechaIngreso;
        }
        public String ToStringCSV_PersonaModificada()
        {
            String legajo = this.Legajo;
            String nombre = this.Nombre;
            String apellido = this.Apellido;
            String dni = this.Dni.ToString();
            String fechaIngreso = this.FechaIngreso.ToString("dd/MM/yyyy");
            return legajo + ";" +
                   nombre + ";" +
                   apellido + ";" +
                   dni + ";" +
                   fechaIngreso;
        }
    }
}
