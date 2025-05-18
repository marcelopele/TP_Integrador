using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Operacion
    {
        //Atributos
        protected String _idOperacion;
        protected String _tipoOperacion;
        protected String _estado;
        protected String _legajoSolicitante;
        protected DateTime _fechaSolicitud;
        protected String _legajoAutorizador;
        protected DateTime _fechaAutorizacion;

        //Propiedades
        public String IdOperacion {  get => _idOperacion; set => _idOperacion = value; }
        public String TipoOperacion { get => _tipoOperacion; set =>_tipoOperacion = value; } 
        public String Estado { get => _estado; }
        public String LegajoSolicitante { get => _legajoSolicitante; set => _legajoSolicitante = value; }
        public DateTime FechaSolicitud { get => _fechaSolicitud; set => _fechaSolicitud = value; }
        public String LegajoAutorizador { get => _legajoAutorizador; set => _legajoAutorizador = value; }
        public DateTime FechaAutorizacion { get => _fechaAutorizacion; set => _fechaAutorizacion = value; }

        //Métodos
        public void Aprobar(String LegajoAutorizador)
        {
            _estado = "A";
            _legajoAutorizador= LegajoAutorizador;
            _fechaAutorizacion=DateTime.Now;
        }
        public void Rechazar(String LegajoAutorizador)
        {
            _estado = "R";
            _legajoAutorizador = LegajoAutorizador;
            _fechaAutorizacion = DateTime.Now;
        }

        public String ToStringOperacionCSV()
        {
            String idOperacion = this.IdOperacion;
            String tipoOperacion = this.TipoOperacion;
            String estado = this.Estado;
            String legajoSolicitante = this.LegajoSolicitante;
            String fechaSolicitud = this.FechaSolicitud.ToString("dd/MM/yyyy");
            String legajoAutorizador = this.LegajoAutorizador;
            String fechaAutorizacion = this.FechaAutorizacion.ToString("dd/MM/yyyy");

            return idOperacion + ";" +
                   tipoOperacion + ";" +
                   estado + ";" +
                   legajoSolicitante + ";" +
                   fechaSolicitud + ";" +
                   legajoAutorizador + ";" +
                   fechaAutorizacion;

        }

        public override string ToString()
        {
            return this.IdOperacion;
        }
    }
}
