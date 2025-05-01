using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Credencial
    {
        //Atributos
        private String _legajo;
        private String _nombreUsuario;
        private String _contrasena;
        private DateTime _fechaAlta;
        private DateTime _fechaUltimoLogin;

        //Propiedades
        public String Legajo { get => _legajo; set => _legajo = value; }
        public String NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public String Contrasena { get => _contrasena; set => _contrasena = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; }

        //Constructor
        public Credencial(String registro)
        {
            String[] datos = registro.Split(';');
            this._legajo = datos[0];
            this._nombreUsuario = datos[1];
            this._contrasena = datos[2];
            this._fechaAlta = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);
            this._fechaUltimoLogin = DateTime.ParseExact(datos[4], "d/M/yyyy", CultureInfo.InvariantCulture);
        }

        // Método para convertir al formato de registro del CSV
        public String ToStringCSV()
        {
            return  this.Legajo + ";"+
                    this.NombreUsuario + ";" +
                    this.Contrasena + ";" +
                    this.FechaAlta.ToString("dd/MM/yyyy") + ";" +
                    this.FechaUltimoLogin.ToString("dd/MM/yyyy");
        }


    }
}
