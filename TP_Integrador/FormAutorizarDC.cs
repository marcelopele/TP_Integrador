using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace TP_Integrador
{
    public partial class FormAutorizarDC : Form
    {
        Credencial credencial_actual;
        OperacionNegocio operacionNegocio = new OperacionNegocio();
        LoginNegocio loginNegocio = new LoginNegocio();

        public FormAutorizarDC(Credencial credencial)
        {
            InitializeComponent();
            credencial_actual = credencial;
            lblNombreUsuario.Text = credencial.Bienvenida();
            lblPerfil.Text = credencial.DescripcionPerfil;

            CargarListaOperaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(credencial_actual);
            formMenu.ShowDialog();
            this.Close();
        }

        private void CargarListaOperaciones()
        {
            lstAutorizacionesPendientes.Items.Clear();
            List<OpeCambioCredencial> Operaciones = operacionNegocio.ListarOpeDC_Pendientes();

            foreach (OpeCambioCredencial operacion in Operaciones)
            {
                lstAutorizacionesPendientes.Items.Add(operacion);
                LimpiarOperaciónSel();
            }
        }

        private void LimpiarOperaciónSel()
        {
            txtIdOperacionSel.Text = "";
            txtFechaSolicitudSel.Text = "";
            txtLegajoSel.Text = "";
            txtUsuarioSel.Text = "";
            txtFechaAltaSel.Text = "";
        }

        private void lstAutorizacionesPendientes_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                OpeCambioCredencial opeDC = (OpeCambioCredencial)itemSeleccionado[0];
                CargarDatosOperacion(opeDC);
            }
        }

        private void CargarDatosOperacion(OpeCambioCredencial opeDC)
        {
            txtIdOperacionSel.Text = opeDC.IdOperacion;
            txtFechaSolicitudSel.Text = opeDC.FechaSolicitud.ToString("d");

            txtLegajoSel.Text = opeDC.Legajo.ToString();
            txtUsuarioSel.Text = opeDC.NombreUsuario;
            txtFechaAltaSel.Text = opeDC.FechaAlta.ToString("D");

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            //Actualizar el estado de la operación
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;
            OpeCambioCredencial opeDC = (OpeCambioCredencial)itemSeleccionado[0];
            operacionNegocio.RechazarOperacionDC(opeDC, credencial_actual);

            //Recargar la lista de operaciones pendientes y limpia la operación procesada
            CargarListaOperaciones();
            LimpiarOperaciónSel();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            //Actualizar el estado de la operación
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;
            OpeCambioCredencial opeDC = (OpeCambioCredencial)itemSeleccionado[0];
            operacionNegocio.AprobarOperacionDC(opeDC, credencial_actual);

            //Actualizar la credencial
            

            //            Persona persona_modificada = new Persona(opeDC.ToStringCSV_PersonaModificada());
            //            personaNegocio.ActualizarCredencial(persona_modificada);

            //Recargar la lista de operaciones pendientes y limpia la operación procesada
            CargarListaOperaciones();
            LimpiarOperaciónSel();
        }
    }
}
