using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Microsoft.Win32;
using Persistencia.DataBase;

namespace Persistencia
{
    public class OperacionPersistencia
    {
        public void AltaOpeCambioPersona(String operacion, String opeCambioPersona)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.AgregarRegistro("autorizacion.csv", operacion);
            dataBaseUtils.AgregarRegistro("operacion_cambio_persona.csv", opeCambioPersona);

        }

        public void AltaOpeDesbloqueo(String operacion, String opeDesbloqueo)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.AgregarRegistro("autorizacion.csv", operacion);
            dataBaseUtils.AgregarRegistro("operacion_cambio_credencial.csv", opeDesbloqueo);

        }

        public List<OpeCambioPersona> ListarOpeMP_Pendientes()
        {
            List<OpeCambioPersona> salida = new List<OpeCambioPersona>();

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> lstOpe = dataBaseUtils.BuscarRegistrosPorValor("autorizacion.csv", 1, "MP");
            foreach (String strOpe in lstOpe)
            {
                String[] ope = strOpe.Split(';');
                if(ope[2] == "P")
                {
                    List<String> OpeMP = dataBaseUtils.BuscarRegistrosPorValor("operacion_cambio_persona.csv", 0, ope[0]);

                    OpeCambioPersona opeCambioPersona = new OpeCambioPersona(strOpe, OpeMP[0]);
                    salida.Add(opeCambioPersona);
                }

            }

            return salida;
        }

        public List<OpeCambioCredencial> ListarOpeDC_Pendientes()
        {
            List<OpeCambioCredencial> salida = new List<OpeCambioCredencial>();

            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> lstOpe = dataBaseUtils.BuscarRegistrosPorValor("autorizacion.csv", 1, "DC");
            foreach (String strOpe in lstOpe)
            {
                String[] ope = strOpe.Split(';');
                if (ope[2] == "P")
                {
                    List<String> OpeDC = dataBaseUtils.BuscarRegistrosPorValor("operacion_cambio_credencial.csv", 0, ope[0]);

                    OpeCambioCredencial opeCambioCredencial = new OpeCambioCredencial(strOpe, OpeDC[0]);
                    salida.Add(opeCambioCredencial);
                }

            }

            return salida;
        }

        public void CambioEstadoAutorizaciónMP(OpeCambioPersona opeMP)
        {
            String idOperacion = opeMP.IdOperacion;
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.ModificarRegistro("autorizacion.csv", 0, idOperacion, opeMP.ToStringOperacionCSV());
        }

        public void CambioEstadoAutorizaciónDC(OpeCambioCredencial opeDC)
        {
            String idOperacion = opeDC.IdOperacion;
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            dataBaseUtils.ModificarRegistro("autorizacion.csv", 0, idOperacion, opeDC.ToStringOperacionCSV());
        }

    }
}
