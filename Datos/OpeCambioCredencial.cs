using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class OpeCambioCredencial:Operacion
    {
        //Atributos
        private String _legajo;
        private String _nombreUsuario;
        private String _contrasena;
        private int _idPerfil;
        private DateTime _fechaAlta;
        private DateTime _fechaUltimoLogin;

        //Propiedades
        public String Legajo { get => _legajo; set => _legajo = value; }
        public String NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public String Contrasena { get => _contrasena; set => _contrasena = value; }
        public int IdPerfil { get => _idPerfil; set => _idPerfil = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; }

        //Constructor
        public OpeCambioCredencial(String registro1, String registro2)
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
                this.NombreUsuario = datos2[2];
                this.Contrasena = datos2[3];
                this.IdPerfil = Int32.Parse(datos2[4]);
                if (DateTime.TryParseExact(datos2[5], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaAlta))
                {
                    this.FechaAlta = fechaAlta;
                }
                if (DateTime.TryParseExact(datos2[6], "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaUltimoLogin))
                {
                    this.FechaUltimoLogin = fechaUltimoLogin;
                }
            }
        }

        public String ToStringOpeCambioCredencialCSV()
        {
            String idOperacion = this.IdOperacion;
            String legajo = this.Legajo;
            String nombreUsuario = this.NombreUsuario;
            String contrasena = this.Contrasena;
            String idPerfil = this.IdPerfil.ToString();
            String fechaAlta = this.FechaAlta.ToString("dd/MM/yyyy");
            String fechaUltimoLogin = this.FechaUltimoLogin.ToString("dd/MM/yyyy");

            return idOperacion + ";" +
                   legajo + ";" +
                   nombreUsuario + ";" +
                   contrasena + ";" +
                   idPerfil + ";" +
                   fechaAlta + ";" +
                   fechaUltimoLogin;
        }

        public String ToStringCSV_CredencialDesbloqueada()
        {
            String legajo = this.Legajo;
            String nombreUsuario = this.NombreUsuario;
            String contrasena = this.Contrasena;
            String fechaAlta = this.FechaAlta.ToString("dd/MM/yyyy");
            String fechaUltimoLogin = "";
            String fechaCambioClave = "";

            return legajo + ";" +
                   nombreUsuario + ";" +
                   contrasena + ";" +
                   fechaAlta + ";" +
                   fechaUltimoLogin + ";" +
                   fechaCambioClave;
        }

        public override string ToString()
        {
            return this.NombreUsuario+" ("+this.IdOperacion+")";
        }

    }
}
