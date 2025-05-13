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
    public partial class FormCambioClave : Form
    {
        public FormCambioClave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            errUsr.Visible = false;
            errClaveActual.Visible = false;
            errClaveNva1.Visible = false;
            errClaveNva2.Visible = false;
            errMsj.Visible = false;

            String usuario = txtUsuario.Text;
            String clave_actual = txtClaveActual.Text;
            String clave_nva1 = txtClaveNva1.Text;
            String clave_nva2 = txtClaveNva2.Text;

            String errMsj1 = "";
            String errMsjAd = "";

            // 1. Validaciones de datos obligatorios y contenido:
            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(clave_actual) ||
                string.IsNullOrEmpty(clave_nva1) ||
                string.IsNullOrEmpty(clave_nva2) ||
                clave_nva1.Length < 8 ||
                clave_nva2.Length < 8 ||
                clave_nva2 != clave_nva1)
            {
                if (string.IsNullOrEmpty(usuario))
                {
                    errUsr.Visible = true;                                                  // Marcar error en el campo de usuario
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }

                if (string.IsNullOrEmpty(clave_actual))
                {
                    errClaveActual.Visible = true;                                          // Marcar error en el campo de clave actual
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }

                if (string.IsNullOrEmpty(clave_nva1))
                {
                    errClaveNva1.Visible = true;                                            // Marcar error en el campo de clave nueva 1
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (clave_nva1.Length < 8)
                {
                    errClaveNva1.Visible = true;                                            // Marcar error en el campo de clave nueva 1
                    errMsjAd += "* La clave debe contener 8 o más caracteres\r\n";
                }

                if (string.IsNullOrEmpty(clave_nva2))
                {
                    errClaveNva2.Visible = true;                                            // Marcar error en el campo de clave nueva 2
                    errMsj1 = "* Completar datos obligatorios\r\n";
                }
                else if (clave_nva2 != clave_nva1)
                {
                    errClaveNva2.Visible = true;                                            // Marcar error en el campo de clave nueva 2
                    errMsjAd += "* Las contraseñas no coincide\r\n";
                }

                errMsj.Text = errMsj1 + errMsjAd;                                           // Mostrar mensaje de error
                errMsj.Visible = true;
            }
            //2. Si los datos ingresados superan las validaciones:
            //   controlar que exista el usuario ingresado
            //   que la clave actual ingresada sea la correcta
            //   que la clave nueva sea distinta de la actual
            else
            {
                LoginNegocio loginNegocio = new LoginNegocio();
                Credencial credencial = loginNegocio.Login(usuario, clave_actual);

                //2.1. Validar que el usuario y contraseña sean correctos
                if (credencial == null)
                {
                    errUsr.Visible = true;                                                  // Marcar error en el campo de usuario
                    errClaveActual.Visible = true;                                          // Marcar error en el campo de clave actual
                    errMsj.Text = "* Usuario o clave incorrectos";                          // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.2. Controlar que no sea un usuario bloqueado
                else if (credencial.Bloqueo)
                {
                    errMsj.Text = "* Usuario bloqueado";                                    // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.3. Y controlar que la nueva clave no coincida con la actual
                else if (credencial.Contrasena == clave_nva1)
                {
                    errMsj.Text = "* La clave nueva no puede ser igual a la anterior";      // Mostrar mensaje de error
                    errMsj.Visible = true;
                }
                //2.4. Supera todas las validaciones: Cambia la clave y va al formulario de ingreso
                else 
                {
                    credencial.Contrasena = clave_nva1;
                    loginNegocio.CambiarClave(credencial);

                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.ShowDialog();
                    this.Close();
                }

            }

        }
    }
}
