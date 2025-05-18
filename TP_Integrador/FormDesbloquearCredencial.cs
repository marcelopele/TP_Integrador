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
    public partial class FormDesbloquearCredencial : Form
    {
        Credencial credencial_actual;
        OperacionNegocio operacionNegocio = new OperacionNegocio();

        public FormDesbloquearCredencial(Credencial credencial)
        {
            InitializeComponent();
            credencial_actual = credencial;
            lblNombreUsuario.Text = credencial.Bienvenida();
            lblPerfil.Text = credencial.DescripcionPerfil;

            CargarListaCredenciales();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(credencial_actual);
            formMenu.ShowDialog();
            this.Close();
        }

        private void lstCredenciales_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstCredenciales.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Credencial credencial = (Credencial)itemSeleccionado[0];
                CargarDatosCredencial(credencial);
                FormatosC();
            }
        }


        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            FormatosD();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCredencialSel();
            FormatosI();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            errContrasena.Visible = false;
            errMsj.Visible = false;

            // Validaciones:
            // Obligatorio completar contraseña de desbloqueo
            if (txtContrasenaSel.Text.Equals(""))
            {
                errContrasena.Visible = true;
                errMsj.Text = "* Se debe completar una contraseña";
                errMsj.Visible = true;
            }
            else
            {
            // Si pasa las validaciones registra la operación Desbloquear Credencial
                var itemSeleccionado = lstCredenciales.SelectedItems;
                Credencial credencial = (Credencial)itemSeleccionado[0];

                credencial.Contrasena = txtContrasenaSel.Text;

                operacionNegocio.AltaOpeDesbloqueo(credencial_actual, credencial);

                CargarListaCredenciales();
            }

        }


        private void CargarListaCredenciales()
        {

            lstCredenciales.Items.Clear();
            LoginNegocio loginNegocio = new LoginNegocio();
            List<Credencial> credenciales = loginNegocio.ListCredenciales();

            foreach (Credencial credencial in credenciales)
            {
                lstCredenciales.Items.Add(credencial);
                LimpiarCredencialSel();
                FormatosI();
            }

        }
        private void CargarDatosCredencial(Credencial c)
        {
            txtLegajoSel.Text = c.Legajo;
            txtUsuarioSel.Text = c.NombreUsuario;
            txtContrasenaSel.Text = "";

        }
        private void LimpiarCredencialSel()
        {
            txtLegajoSel.Text = "";
            txtUsuarioSel.Text = "";
            txtContrasenaSel.Text = "";
        }
        private void FormatosI()
        {
            // Modo inicial
            lstCredenciales.Enabled = true;         // Listado: permite seleccionar otra credencial

            txtContrasenaSel.ReadOnly = true;       // Campo solo lectura en modo inicial

            btnDesbloquear.Visible = true;          // Botón desbloquear visible pero deshabilitado
            btnDesbloquear.Enabled = false;
            btnConfirmar.Visible = false;           // y se ocultan los botones Confirmar y Cancelar
            btnCancelar.Visible = false;

            lstCredenciales.Focus();                // Lleva el foco a la lista

        }
        private void FormatosC()
        {
            // Modo consulta:
            lstCredenciales.Enabled = true;        // Listado: ya no permite seleccionar otra credencial

            txtContrasenaSel.ReadOnly = true;       // Campo no editable en modo consulta

            btnDesbloquear.Visible = true;          // Botón Desbloquear visible y habilitado
            btnDesbloquear.Enabled = true;
            btnConfirmar.Visible = false;           // y se ocultan los botones Confirmar y Cancelar
            btnCancelar.Visible = false;

            txtContrasenaSel.Focus();               // Lleva el foco al campo de contraseña para definir una
        }
        private void FormatosD()
        {
            // Modo desbloqueo:
            lstCredenciales.Enabled = false;        // Listado: ya no permite seleccionar otra credencial

            txtContrasenaSel.ReadOnly = false;      // Campo editable en modo desbloqueo

            btnDesbloquear.Visible = false;         // Botón Desbloquear oculto
            btnConfirmar.Visible = true;            // Se muestran y habilitan los botones Confirmar y Cancelar
            btnCancelar.Visible = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
                        
            txtContrasenaSel.Focus();               // Lleva el foco al campo de contraseña para definir una
        }
    }
}
