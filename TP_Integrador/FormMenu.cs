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
        public FormMenu(Credencial credencial)
        {
            InitializeComponent();
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

        }
    }
}
