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
        private DateTime _fechaCambioClave;
        private int _intentosFallidos;
        private Boolean _bloqueo;
        private Boolean _primerIngreso;
        private int _idPerfil;
        private String _descripcionPerfil;
        private List<Roles> _roles = new List<Roles>();

        //Propiedades
        public String Legajo { get => _legajo; set => _legajo = value; }
        public String NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public String Contrasena { get => _contrasena; set => _contrasena = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; }
        public DateTime FechaCambioClave { get => _fechaCambioClave; set => _fechaCambioClave = value; }
        public int IntentosFallidos { get => _intentosFallidos; set => _intentosFallidos = value; }
        public Boolean Bloqueo { get => _bloqueo; set => _bloqueo = value; }
        public Boolean PrimerIngreso { get => _primerIngreso; set => _primerIngreso = value; }
        public int IdPerfil { get => _idPerfil;set => _idPerfil = value; }
        public String DescripcionPerfil { get => _descripcionPerfil; set => _descripcionPerfil = value; }
        public List<Roles> Roles { get => _roles; set => _roles = value; }

        //Constructor
        public Credencial(String registro, int intentos, Boolean bloqueo, int idPerfil, String denominacionPerfil, List<Roles>roles)
        {
            String[] datos = registro.Split(';');

            this._legajo = datos[0];
            this._nombreUsuario = datos[1];
            this._contrasena = datos[2];

            if (DateTime.TryParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaAlta))
            {
                this._fechaAlta = fechaAlta;
            }

            if (DateTime.TryParseExact(datos[4], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaUltimoLogin))
            {
                this._fechaUltimoLogin = fechaUltimoLogin;
            }

            if (DateTime.TryParseExact(datos[5], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaCambioClave))
            {
                this._fechaCambioClave = fechaCambioClave;
            }

            if (datos[5] == "")
            {
                this._primerIngreso = true;
            }
            else
            {
                this._primerIngreso = false;
            }

            this._intentosFallidos = intentos;
            this._bloqueo = bloqueo;

            this._descripcionPerfil = denominacionPerfil;
            this._roles = roles;

        }


        // Métodos:

        // Método para identificar si la clave está vencida
        public Boolean ClaveVencida()
        {
            Boolean salida = false;

            if (FechaCambioClave != null)
            {
                int días = (DateTime.Now - FechaCambioClave).Days;
                if (días > 30)
                {
                    salida = true;
                }
            }

            return salida;
        }

        public String Bienvenida()
        {
            return "Bienvenido " + this.NombreUsuario;
        }

        //ToString personalizado
        public override String ToString()
        {
            return " (" + this.Legajo + ") " + this.NombreUsuario;
        }

        // Método para convertir al formato de registro del CSV
        public String ToStringCSV()
        {
            String legajo = this.Legajo;
            String nombreUsuario = this.NombreUsuario;
            String contrasena = this.Contrasena;
            String fechaAlta = this.FechaAlta.ToString("dd/MM/yyyy");
            String fechaUltimoLogin = this.FechaUltimoLogin.ToString("dd/MM/yyyy");
            String fechaCambioClave = this.FechaCambioClave.ToString("dd/MM/yyyy");

            if(this.PrimerIngreso==true)
            {
                fechaUltimoLogin = "";
                fechaCambioClave = "";
            }

            return legajo + ";"+
                   nombreUsuario + ";" +
                   contrasena + ";" +
                   fechaAlta + ";" +
                   fechaUltimoLogin + ";" +
                   fechaCambioClave;
        }


    }
}
