using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class OperacionNegocio
    {
        OperacionPersistencia operacionPersistencia = new OperacionPersistencia();

        public void AltaOpeCambioPersona(Credencial solicitante, Persona persona_modificada)
        {
            // Registro autorizacion.csv:
            String idOperacion = DateTime.Now.ToString("yyyyMMddmmssffff");
            String tipoOperacion = "MP";                                                //MP: Modificar Persona
            String estado = "P";                                                        //P:  Pendiente
            String legajoSolicitante = solicitante.Legajo;
            String fechaSolicitud = DateTime.Now.ToString("dd/MM/yyyy");
            String legajoAutorizador = "";
            String fechaAutorizacion = "";

            String operacion = idOperacion + ";" +
                   tipoOperacion + ";" +
                   estado + ";" +
                   legajoSolicitante + ";" +
                   fechaSolicitud + ";" +
                   legajoAutorizador + ";" +
                   fechaAutorizacion;

            // Registro operacion_cambio_persona.csv:
            String legajo = persona_modificada.Legajo;
            String nombre = persona_modificada.Nombre;
            String apellido = persona_modificada.Apellido;
            String dni = persona_modificada.Dni.ToString();
            String fechaIngreso = persona_modificada.FechaIngreso.ToString("dd/MM/yyyy");

            String opeCambioPersona = idOperacion + ";" +
                   legajo + ";" +
                   nombre + ";" +
                   apellido + ";" +
                   dni + ";" +
                   fechaIngreso;

            operacionPersistencia.AltaOpeCambioPersona(operacion, opeCambioPersona);

        }

        public void AltaOpeDesbloqueo(Credencial solicitante, Credencial credencial_modificada)
        {
            // Registro autorizacion.csv:
            String idOperacion = DateTime.Now.ToString("yyyyMMddmmssffff");
            String tipoOperacion = "DC";                                                //DC: Desbloquear credencial
            String estado = "P";                                                        //P:  Pendiente
            String legajoSolicitante = solicitante.Legajo;
            String fechaSolicitud = DateTime.Now.ToString("dd/MM/yyyy");
            String legajoAutorizador = "";
            String fechaAutorizacion = "";

            String operacion = idOperacion + ";" +
                   tipoOperacion + ";" +
                   estado + ";" +
                   legajoSolicitante + ";" +
                   fechaSolicitud + ";" +
                   legajoAutorizador + ";" +
                   fechaAutorizacion;

            // Registro operacion_cambio_credencial.csv:

            String opeCambioCredencial = idOperacion + ";" +
                   credencial_modificada.Legajo + ";" +
                   credencial_modificada.NombreUsuario + ";" +
                   credencial_modificada.Contrasena + ";" +
                   "1" + ";" +                                                          //pendiente agregar idPerfil en la credencial
                   credencial_modificada.FechaAlta.ToString("dd/MM/yyyy") + ";";        //Septima columna del csv va siempre vacía => fecha último login

            operacionPersistencia.AltaOpeDesbloqueo(operacion, opeCambioCredencial);

        }

        public List<OpeCambioPersona> ListarOpeMP_Pendientes()
        {
            return operacionPersistencia.ListarOpeMP_Pendientes();
        }
        public List<OpeCambioCredencial> ListarOpeDC_Pendientes()
        {
            return operacionPersistencia.ListarOpeDC_Pendientes();
        }

        public void AprobarOperacionMP(OpeCambioPersona opeMP, Credencial aprobador)
        {
            opeMP.Aprobar(aprobador.Legajo);
            operacionPersistencia.CambioEstadoAutorizaciónMP(opeMP);
        }
        public void RechazarOperacionMP(OpeCambioPersona opeMP, Credencial aprobador)
        {
            opeMP.Rechazar(aprobador.Legajo);
            operacionPersistencia.CambioEstadoAutorizaciónMP(opeMP);
        }

        public void AprobarOperacionDC(OpeCambioCredencial opeDC, Credencial aprobador)
        {
            opeDC.Aprobar(aprobador.Legajo);
            operacionPersistencia.CambioEstadoAutorizaciónDC(opeDC);
        }
        public void RechazarOperacionDC(OpeCambioCredencial opeDC, Credencial aprobador)
        {
            opeDC.Rechazar(aprobador.Legajo);
            operacionPersistencia.CambioEstadoAutorizaciónDC(opeDC);
        }

    }
}
