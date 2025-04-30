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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtClave.Text;


            //Validar datos obligatorios
            if (usuario.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Completar usuario y clave");
                return;
            }
            else
            {
                LoginNegocio loginNegocio = new LoginNegocio();
                Credencial credencial = loginNegocio.login(usuario, password);

                if (credencial == null)
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                    return;
                }
                else
                {
                    MessageBox.Show("Bienvenido " + credencial.NombreUsuario);
                }
            }


        }
    }
}
