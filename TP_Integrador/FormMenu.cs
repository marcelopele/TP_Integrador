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

namespace TP_Integrador
{
    public partial class FormMenu : Form
    {
        Credencial credencial_actual;
        public FormMenu(Credencial credencial)
        {
            InitializeComponent();
            credencial_actual = credencial;
            lblNombreUsuario.Text = credencial.Bienvenida();
            lblPerfil.Text = credencial.DescripcionPerfil;

            // Habilitar opciones según permisos
            btnOperador.Enabled = false;
            btnModificarPersona.Enabled = false;
            btnAutorizarModificarPersona.Enabled = false;
            btnDesbloquearCredencial.Enabled = false;
            btnAutorizarDesbloquearCredencial.Enabled = false;
            foreach (Roles rol in credencial.Roles)
            {
                switch (rol.IdRol)
                {
                    case 1:
                        btnModificarPersona.Enabled = true;
                        break;
                    case 2:
                        btnAutorizarModificarPersona.Enabled = true;
                        break;
                    case 3:
                        btnDesbloquearCredencial.Enabled = true;
                        break;
                    case 4:
                        btnAutorizarDesbloquearCredencial.Enabled = true;
                        break;
                    case 5:
                        btnOperador.Enabled = true;
                        break;
                }
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOperador formOperador = new FormOperador(credencial_actual);
            formOperador.ShowDialog();
            this.Close();
        }

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificarPersona formModificarPersona = new FormModificarPersona(credencial_actual);
            formModificarPersona.ShowDialog();
            this.Close();
        }

        private void btnDesbloquearCredencial_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDesbloquearCredencial formDesbloquearCredencial = new FormDesbloquearCredencial(credencial_actual);
            formDesbloquearCredencial.ShowDialog();
            this.Close();
        }

        private void btnAutorizarModificarPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAutorizarMP formAutorizarMP = new FormAutorizarMP(credencial_actual);
            formAutorizarMP.ShowDialog();
            this.Close();

        }

        private void btnAutorizarDesbloquearCredencial_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAutorizarDC formAutorizarDC = new FormAutorizarDC(credencial_actual);
            formAutorizarDC.ShowDialog();
            this.Close();

        }
    }
}
