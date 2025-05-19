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
    public partial class FormModificarPersona : Form
    {
        Credencial credencial_actual;
        PersonaNegocio personaNegocio = new PersonaNegocio();
        OperacionNegocio operacionNegocio = new OperacionNegocio();

        public FormModificarPersona(Credencial credencial)
        {
            InitializeComponent();
            credencial_actual = credencial;
            lblNombreUsuario.Text = credencial.Bienvenida();
            lblPerfil.Text = credencial.DescripcionPerfil;

            CargarListaPersonas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(credencial_actual);
            formMenu.ShowDialog();
            this.Close();
        }

        private void lstPersonas_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = lstPersonas.SelectedItems;

            if (itemSeleccionado.Count != 0)
            {
                Persona persona = (Persona)itemSeleccionado[0];
                CargarDatosPersona(persona);
                FormatosC();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormatosE();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPersonaSel();
            FormatosI();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Boolean con_errores = false;
            errNombre.Visible = false;
            errApellido.Visible = false;
            errDNI.Visible = false;
            errFhIngreso.Visible = false;
            errMsj.Visible = false;
            errMsj.Text = "";

            // Validaciones:
            // Datos obligatorios
            if (txtNombreSel.Text.Equals("")||
                txtApellidoSel.Text.Equals("")||
                txtDNISel.Text.Equals(""))
            {
                if (txtNombreSel.Text.Equals(""))
                {
                    errNombre.Visible = true;                                                      // Marcar error en el campo de usuario
                }

                if (txtApellidoSel.Text.Equals(""))
                {
                    errApellido.Visible = true;                                                    // Marcar error en el campo de clave
                }

                if (txtDNISel.Text.Equals(""))
                {
                    errDNI.Visible = true;                                                    // Marcar error en el campo de clave
                }

                errMsj.Text = "* Completar datos obligatorios\r\n";
                errMsj.Visible = true;
                con_errores = true;
            }

            // Validación sobre documento
            if(!int.TryParse(txtDNISel.Text, out int nroDNI))
            {
                errDNI.Visible = true;
                errMsj.Text = errMsj.Text + "* El número de documento no es numérico\r\n";
                errMsj.Visible = true;
                con_errores = true;
            }
            else if(nroDNI <10000000 || nroDNI > 100000000)
            {
                errDNI.Visible = true;
                errMsj.Text = errMsj.Text + "* Número de documento fuera de rango\r\n";
                errMsj.Visible = true;
                con_errores = true;
            }

            // Validación sobre la fecha de ingreso
            if(txtFhIngresoSel.Value > DateTime.Now)
            {
                errFhIngreso.Visible = true;
                errMsj.Text = errMsj.Text + "* No se puede registrar con fecha futura\r\n";
                errMsj.Visible = true;
                con_errores = true;
            }else if (txtFhIngresoSel.Value < DateTime.Parse("1/1/2017 12:00:00 AM"))
            {
                errFhIngreso.Visible = true;
                errMsj.Text = errMsj.Text + "* No se puede registrar fecha anterior al 1/1/2017\r\n";
                errMsj.Visible = true;
                con_errores = true;
            }

            // Agrega la operación a autorizar si pasó todas las validaciones
            if (!con_errores)
            {
                var itemSeleccionado = lstPersonas.SelectedItems;
                Persona persona = (Persona)itemSeleccionado[0];
                Persona persona_modificada = new Persona(persona.ToStringCSV());
                persona_modificada.Nombre = txtNombreSel.Text;
                persona_modificada.Apellido = txtApellidoSel.Text;
                persona_modificada.Dni = nroDNI;
                persona_modificada.FechaIngreso = txtFhIngresoSel.Value;

                //personaNegocio.ActualizarPersona(persona_modificada);
                operacionNegocio.AltaOpeCambioPersona(credencial_actual, persona_modificada);
                CargarListaPersonas();

            }

        }


        private void CargarListaPersonas()
        {

            lstPersonas.Items.Clear();
            List<Persona> Personas = personaNegocio.ListPersonas();

            foreach (Persona persona in Personas)
            {
                lstPersonas.Items.Add(persona);
                LimpiarPersonaSel();
                FormatosI();
            }

        }

        private void CargarDatosPersona(Persona p)
        {
            txtLegajoSel.Text = p.Legajo.ToString();
            txtNombreSel.Text = p.Nombre;
            txtApellidoSel.Text = p.Apellido;
            txtDNISel.Text = p.Dni.ToString();
            txtFhIngresoTxt.Text = p.FechaIngreso.ToString("D");
            txtFhIngresoSel.Value = p.FechaIngreso;

        }

        private void LimpiarPersonaSel()
        {
            txtLegajoSel.Text = "";
            txtNombreSel.Text = "";
            txtApellidoSel.Text = "";
            txtDNISel.Text = "";
            txtFhIngresoTxt.Text = "";

            errNombre.Visible = false;
            errApellido.Visible = false;
            errDNI.Visible = false;
            errFhIngreso.Visible = false;
            errMsj.Visible = false;
            errMsj.Text = "";
        }
        private void FormatosI()
        {
            // Modo inicial
            lstPersonas.Enabled = true;             // Listado: permite seleccionar otra persona

            txtNombreSel.ReadOnly = true;           // Campos solo lectura
            txtApellidoSel.ReadOnly = true;
            txtDNISel.ReadOnly = true;
            txtFhIngresoSel.Visible = false;        //      (campo fecha siempre editable queda oculto)
            txtFhIngresoTxt.Visible = true;         //      (fecha en campo texto visible, siempre readonly)

            btnModificar.Visible = true;            // Botón modificar visible pero deshabilitado
            btnModificar.Enabled = false;
            btnConfirmar.Visible = false;           // y se ocultan los botones Confirmar y Cancelar
            btnCancelar.Visible = false;


            lstPersonas.Focus();                    // Lleva el foco a la lista

        }
        private void FormatosC()
        {
            // Modo consulta:
            
            lstPersonas.Enabled = true;             // Listado: permite seleccionar otra persona
            
            txtNombreSel.ReadOnly = true;           // Campos solo lectura
            txtApellidoSel.ReadOnly = true;
            txtDNISel.ReadOnly = true;
            txtFhIngresoSel.Visible = false;        //      (campo fecha siempre editable queda oculto)
            txtFhIngresoTxt.Visible = true;         //      (fecha en campo texto visible, siempre readonly)

            btnModificar.Visible = true;            // Botón modificar visible y habilitado
            btnModificar.Enabled = true;
            btnConfirmar.Visible = false;           // y se ocultan los botones Confirmar y Cancelar
            btnCancelar.Visible = false;


            txtNombreSel.Focus();                   // Lleva el foco al primer campo
        }
        private void FormatosE()
        {
            // Modo edición de datos:

            lstPersonas.Enabled = false;            // Listado: ya no permite seleccionar otra persona

            txtNombreSel.ReadOnly = false;          // Campos editables
            txtApellidoSel.ReadOnly = false;
            txtDNISel.ReadOnly = false;
            txtFhIngresoSel.Visible = true;         //      (campo fecha editable se hace visible)
            txtFhIngresoTxt.Visible = false;        //      (fecha en campo texto se oculta)

            btnModificar.Visible = false;           // Botón modificar oculto
            btnConfirmar.Visible = true;            // Se muestran y habilitan los botones Confirmar y Cancelar
            btnCancelar.Visible = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;


            txtNombreSel.Focus();                   // Lleva el foco al primer campo
        }


    }
}
