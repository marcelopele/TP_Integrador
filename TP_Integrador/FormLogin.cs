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

            if (usuario.Equals("") || password.Equals(""))                                      // Validar datos obligatorios
            {
                MessageBox.Show("Completar usuario y clave");
                return;
            }
            else
            {
                LoginNegocio loginNegocio = new LoginNegocio();                                 
                Credencial credencial = loginNegocio.login(usuario, password);

                if (credencial == null)                                                         // Si loginNegocio.login devuelve null: usuario o clave son incorrectos
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                    return;
                }
                else if(credencial.Bloqueo)                                                     // Si devuelve una credencial verificar que no esté bloqueada
                {
                    MessageBox.Show("Usuario bloqueado, contactese con el administrador");
                    return;
                }
                else if (credencial.PrimerIngreso)                                              // Si no está bloqueada verificar si es el primer ingreso
                {
                    MessageBox.Show("Primer ingreso debe registrar una clave " + credencial.NombreUsuario);

                    this.Hide();
                    FormCambioClave formCambioClave = new FormCambioClave();
                    formCambioClave.ShowDialog();
                    this.Close();
                }
                else if(credencial.ClaveVencida())                                              // Si no está bloqueada verificar que no esté vencida la clave
                {
                    MessageBox.Show("Clave vencida se requiere cambio de clave " + credencial.NombreUsuario);

                    this.Hide();
                    FormCambioClave formCambioClave = new FormCambioClave();
                    formCambioClave.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    FormMenu formMenu= new FormMenu(credencial);
                    formMenu.ShowDialog();
                    this.Close();
                }
            }


        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCambioClave formCambioClave = new FormCambioClave();
            formCambioClave.ShowDialog();
            this.Close();
        }
    }
}
