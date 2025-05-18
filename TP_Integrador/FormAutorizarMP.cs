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
    public partial class FormAutorizarMP : Form
    {
        Credencial credencial_actual;
        OperacionNegocio operacionNegocio = new OperacionNegocio();
        PersonaNegocio personaNegocio = new PersonaNegocio();

        public FormAutorizarMP(Credencial credencial)
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
            List<OpeCambioPersona> Operaciones = operacionNegocio.ListarOpeMP_Pendientes();

            foreach (OpeCambioPersona operacion in Operaciones)
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
            txtNombreSel.Text = "";
            txtApellidoSel.Text = "";
            txtDNISel.Text = "";
            txtFechaIngresoSel.Text = "";
        }

        private void lstAutorizacionesPendientes_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                OpeCambioPersona opeMP = (OpeCambioPersona)itemSeleccionado[0];
                CargarDatosOperacion(opeMP);
            }
        }

        private void CargarDatosOperacion(OpeCambioPersona opeMP)
        {
            txtIdOperacionSel.Text = opeMP.IdOperacion;
            txtFechaSolicitudSel.Text = opeMP.FechaSolicitud.ToString("d");

            txtLegajoSel.Text = opeMP.Legajo.ToString();
            txtNombreSel.Text = opeMP.Nombre;
            txtApellidoSel.Text = opeMP.Apellido;
            txtDNISel.Text = opeMP.Dni.ToString();
            txtFechaIngresoSel.Text = opeMP.FechaIngreso.ToString("D");

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            //Actualizar el estado de la operación
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;
            OpeCambioPersona opeMP = (OpeCambioPersona)itemSeleccionado[0];
            operacionNegocio.RechazarOperacionMP(opeMP, credencial_actual);

            //Recargar la lista de operaciones pendientes y limpia la operación procesada
            CargarListaOperaciones();
            LimpiarOperaciónSel();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            //Actualizar el estado de la operación
            var itemSeleccionado = lstAutorizacionesPendientes.SelectedItems;
            OpeCambioPersona opeMP = (OpeCambioPersona)itemSeleccionado[0];
            operacionNegocio.AprobarOperacionMP(opeMP, credencial_actual);

            //Actualizar la persona
            Persona persona_modificada = new Persona(opeMP.ToStringCSV_PersonaModificada());
            personaNegocio.ActualizarPersona(persona_modificada);

            //Recargar la lista de operaciones pendientes y limpia la operación procesada
            CargarListaOperaciones();
            LimpiarOperaciónSel();

        }


    }
}
