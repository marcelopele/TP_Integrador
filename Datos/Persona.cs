using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Datos
{
    public class Persona
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
        public Persona(String registro)
        {
            String[] datos = registro.Split(';');

            this._legajo = datos[0];
            this._nombre = datos[1];
            this._apellido = datos[2];
            this._dni = Int32.Parse(datos[3]);
            if (DateTime.TryParseExact(datos[4], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaIngreso))
            {
                this._fechaIngreso = fechaIngreso;
            }
        }

        //ToString personalizado
        public override String ToString()
        {
            return " (" + this.Legajo + ") " + this.Apellido + ", " + this.Nombre;
        }

        // Método para convertir al formato de registro del CSV
        public String ToStringCSV()
        {
            String legajo = this.Legajo;
            String nombre = this.Nombre;
            String apellido = this.Apellido;
            String dni = this.Dni.ToString();
            String fecha_ingreso = this.FechaIngreso.ToString("dd/MM/yyyy");

            return legajo + ";" +
                   nombre + ";" +
                   apellido + ";" +
                   dni + ";" +
                   fecha_ingreso;
        }

    }
}
