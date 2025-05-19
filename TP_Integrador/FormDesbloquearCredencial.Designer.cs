namespace TP_Integrador
{
    partial class FormDesbloquearCredencial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lstCredenciales = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.errContrasena = new System.Windows.Forms.Label();
            this.errMsj = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCredencial = new System.Windows.Forms.Label();
            this.lblContrasenaSel = new System.Windows.Forms.Label();
            this.txtContrasenaSel = new System.Windows.Forms.TextBox();
            this.lblLegajoSel = new System.Windows.Forms.Label();
            this.lblUsuarioSel = new System.Windows.Forms.Label();
            this.txtUsuarioSel = new System.Windows.Forms.TextBox();
            this.txtLegajoSel = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.Location = new System.Drawing.Point(251, 9);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(281, 13);
            this.lblPerfil.TabIndex = 61;
            this.lblPerfil.Text = "label1";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 60;
            this.lblNombreUsuario.Text = "label1";
            // 
            // lstCredenciales
            // 
            this.lstCredenciales.FormattingEnabled = true;
            this.lstCredenciales.Location = new System.Drawing.Point(15, 43);
            this.lstCredenciales.Name = "lstCredenciales";
            this.lstCredenciales.Size = new System.Drawing.Size(197, 316);
            this.lstCredenciales.TabIndex = 76;
            this.lstCredenciales.Click += new System.EventHandler(this.lstCredenciales_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(42, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(142, 23);
            this.btnVolver.TabIndex = 75;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // errContrasena
            // 
            this.errContrasena.AutoSize = true;
            this.errContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errContrasena.ForeColor = System.Drawing.Color.Red;
            this.errContrasena.Location = new System.Drawing.Point(520, 173);
            this.errContrasena.Name = "errContrasena";
            this.errContrasena.Size = new System.Drawing.Size(15, 20);
            this.errContrasena.TabIndex = 99;
            this.errContrasena.Text = "*";
            this.errContrasena.Visible = false;
            // 
            // errMsj
            // 
            this.errMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errMsj.AutoSize = true;
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(243, 325);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(55, 15);
            this.errMsj.TabIndex = 97;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(240, 285);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 23);
            this.btnConfirmar.TabIndex = 93;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCredencial
            // 
            this.lblCredencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredencial.Location = new System.Drawing.Point(239, 43);
            this.lblCredencial.Name = "lblCredencial";
            this.lblCredencial.Size = new System.Drawing.Size(281, 13);
            this.lblCredencial.TabIndex = 90;
            this.lblCredencial.Text = "Credencial a desbloquear";
            this.lblCredencial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContrasenaSel
            // 
            this.lblContrasenaSel.AutoSize = true;
            this.lblContrasenaSel.Location = new System.Drawing.Point(265, 196);
            this.lblContrasenaSel.Name = "lblContrasenaSel";
            this.lblContrasenaSel.Size = new System.Drawing.Size(109, 13);
            this.lblContrasenaSel.TabIndex = 88;
            this.lblContrasenaSel.Text = "Contraseña provisoria";
            // 
            // txtContrasenaSel
            // 
            this.txtContrasenaSel.Location = new System.Drawing.Point(240, 173);
            this.txtContrasenaSel.Name = "txtContrasenaSel";
            this.txtContrasenaSel.Size = new System.Drawing.Size(280, 20);
            this.txtContrasenaSel.TabIndex = 84;
            // 
            // lblLegajoSel
            // 
            this.lblLegajoSel.AutoSize = true;
            this.lblLegajoSel.Location = new System.Drawing.Point(265, 100);
            this.lblLegajoSel.Name = "lblLegajoSel";
            this.lblLegajoSel.Size = new System.Drawing.Size(39, 13);
            this.lblLegajoSel.TabIndex = 87;
            this.lblLegajoSel.Text = "Legajo";
            // 
            // lblUsuarioSel
            // 
            this.lblUsuarioSel.AutoSize = true;
            this.lblUsuarioSel.Location = new System.Drawing.Point(265, 148);
            this.lblUsuarioSel.Name = "lblUsuarioSel";
            this.lblUsuarioSel.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioSel.TabIndex = 86;
            this.lblUsuarioSel.Text = "Usuario";
            // 
            // txtUsuarioSel
            // 
            this.txtUsuarioSel.Location = new System.Drawing.Point(240, 125);
            this.txtUsuarioSel.Name = "txtUsuarioSel";
            this.txtUsuarioSel.ReadOnly = true;
            this.txtUsuarioSel.Size = new System.Drawing.Size(280, 20);
            this.txtUsuarioSel.TabIndex = 83;
            // 
            // txtLegajoSel
            // 
            this.txtLegajoSel.Enabled = false;
            this.txtLegajoSel.Location = new System.Drawing.Point(240, 77);
            this.txtLegajoSel.Name = "txtLegajoSel";
            this.txtLegajoSel.ReadOnly = true;
            this.txtLegajoSel.Size = new System.Drawing.Size(280, 20);
            this.txtLegajoSel.TabIndex = 82;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(380, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 94;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Enabled = false;
            this.btnDesbloquear.Location = new System.Drawing.Point(240, 284);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(280, 23);
            this.btnDesbloquear.TabIndex = 95;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // FormDesbloquearCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.errContrasena);
            this.Controls.Add(this.errMsj);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCredencial);
            this.Controls.Add(this.lblContrasenaSel);
            this.Controls.Add(this.txtContrasenaSel);
            this.Controls.Add(this.lblLegajoSel);
            this.Controls.Add(this.lblUsuarioSel);
            this.Controls.Add(this.txtUsuarioSel);
            this.Controls.Add(this.txtLegajoSel);
            this.Controls.Add(this.lstCredenciales);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "FormDesbloquearCredencial";
            this.Text = "Desbloquear Credencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ListBox lstCredenciales;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label errContrasena;
        private System.Windows.Forms.Label errMsj;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCredencial;
        private System.Windows.Forms.Label lblContrasenaSel;
        private System.Windows.Forms.TextBox txtContrasenaSel;
        private System.Windows.Forms.Label lblLegajoSel;
        private System.Windows.Forms.Label lblUsuarioSel;
        private System.Windows.Forms.TextBox txtUsuarioSel;
        private System.Windows.Forms.TextBox txtLegajoSel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDesbloquear;
    }
}