namespace TP_Integrador
{
    partial class FormAutorizarMP
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lstAutorizacionesPendientes = new System.Windows.Forms.ListBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.lblNombreSel = new System.Windows.Forms.Label();
            this.txtNombreSel = new System.Windows.Forms.TextBox();
            this.lblLegajoSel = new System.Windows.Forms.Label();
            this.txtLegajoSel = new System.Windows.Forms.TextBox();
            this.lblIdOperacionSel = new System.Windows.Forms.Label();
            this.lblFechaSolicitudSel = new System.Windows.Forms.Label();
            this.txtFechaSolicitudSel = new System.Windows.Forms.TextBox();
            this.txtIdOperacionSel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellidoSel = new System.Windows.Forms.Label();
            this.txtApellidoSel = new System.Windows.Forms.TextBox();
            this.lblDNISel = new System.Windows.Forms.Label();
            this.txtDNISel = new System.Windows.Forms.TextBox();
            this.lblFechaIngresoSel = new System.Windows.Forms.Label();
            this.txtFechaIngresoSel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(82, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(142, 23);
            this.btnVolver.TabIndex = 76;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Location = new System.Drawing.Point(406, 9);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(180, 13);
            this.lblPerfil.TabIndex = 78;
            this.lblPerfil.Text = "label1";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 77;
            this.lblNombreUsuario.Text = "label1";
            // 
            // lstAutorizacionesPendientes
            // 
            this.lstAutorizacionesPendientes.FormattingEnabled = true;
            this.lstAutorizacionesPendientes.Location = new System.Drawing.Point(15, 43);
            this.lstAutorizacionesPendientes.Name = "lstAutorizacionesPendientes";
            this.lstAutorizacionesPendientes.Size = new System.Drawing.Size(328, 316);
            this.lstAutorizacionesPendientes.TabIndex = 79;
            this.lstAutorizacionesPendientes.Click += new System.EventHandler(this.lstAutorizacionesPendientes_Click);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(372, 336);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(114, 23);
            this.btnAutorizar.TabIndex = 80;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(492, 336);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(114, 23);
            this.btnRechazar.TabIndex = 81;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // lblNombreSel
            // 
            this.lblNombreSel.AutoSize = true;
            this.lblNombreSel.Location = new System.Drawing.Point(389, 183);
            this.lblNombreSel.Name = "lblNombreSel";
            this.lblNombreSel.Size = new System.Drawing.Size(44, 13);
            this.lblNombreSel.TabIndex = 89;
            this.lblNombreSel.Text = "Nombre";
            // 
            // txtNombreSel
            // 
            this.txtNombreSel.Location = new System.Drawing.Point(372, 161);
            this.txtNombreSel.Name = "txtNombreSel";
            this.txtNombreSel.ReadOnly = true;
            this.txtNombreSel.Size = new System.Drawing.Size(234, 20);
            this.txtNombreSel.TabIndex = 85;
            // 
            // lblLegajoSel
            // 
            this.lblLegajoSel.AutoSize = true;
            this.lblLegajoSel.Location = new System.Drawing.Point(389, 145);
            this.lblLegajoSel.Name = "lblLegajoSel";
            this.lblLegajoSel.Size = new System.Drawing.Size(39, 13);
            this.lblLegajoSel.TabIndex = 88;
            this.lblLegajoSel.Text = "Legajo";
            // 
            // txtLegajoSel
            // 
            this.txtLegajoSel.Location = new System.Drawing.Point(372, 122);
            this.txtLegajoSel.Name = "txtLegajoSel";
            this.txtLegajoSel.ReadOnly = true;
            this.txtLegajoSel.Size = new System.Drawing.Size(234, 20);
            this.txtLegajoSel.TabIndex = 84;
            // 
            // lblIdOperacionSel
            // 
            this.lblIdOperacionSel.AutoSize = true;
            this.lblIdOperacionSel.Location = new System.Drawing.Point(377, 66);
            this.lblIdOperacionSel.Name = "lblIdOperacionSel";
            this.lblIdOperacionSel.Size = new System.Drawing.Size(68, 13);
            this.lblIdOperacionSel.TabIndex = 87;
            this.lblIdOperacionSel.Text = "Id Operacion";
            // 
            // lblFechaSolicitudSel
            // 
            this.lblFechaSolicitudSel.AutoSize = true;
            this.lblFechaSolicitudSel.Location = new System.Drawing.Point(497, 66);
            this.lblFechaSolicitudSel.Name = "lblFechaSolicitudSel";
            this.lblFechaSolicitudSel.Size = new System.Drawing.Size(93, 13);
            this.lblFechaSolicitudSel.TabIndex = 86;
            this.lblFechaSolicitudSel.Text = "Fecha de solicitud";
            // 
            // txtFechaSolicitudSel
            // 
            this.txtFechaSolicitudSel.Location = new System.Drawing.Point(492, 43);
            this.txtFechaSolicitudSel.Name = "txtFechaSolicitudSel";
            this.txtFechaSolicitudSel.ReadOnly = true;
            this.txtFechaSolicitudSel.Size = new System.Drawing.Size(114, 20);
            this.txtFechaSolicitudSel.TabIndex = 83;
            this.txtFechaSolicitudSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdOperacionSel
            // 
            this.txtIdOperacionSel.Enabled = false;
            this.txtIdOperacionSel.Location = new System.Drawing.Point(372, 43);
            this.txtIdOperacionSel.Name = "txtIdOperacionSel";
            this.txtIdOperacionSel.ReadOnly = true;
            this.txtIdOperacionSel.Size = new System.Drawing.Size(114, 20);
            this.txtIdOperacionSel.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Datos a modificar";
            // 
            // lblApellidoSel
            // 
            this.lblApellidoSel.AutoSize = true;
            this.lblApellidoSel.Location = new System.Drawing.Point(389, 221);
            this.lblApellidoSel.Name = "lblApellidoSel";
            this.lblApellidoSel.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoSel.TabIndex = 92;
            this.lblApellidoSel.Text = "Apellido";
            // 
            // txtApellidoSel
            // 
            this.txtApellidoSel.Location = new System.Drawing.Point(372, 199);
            this.txtApellidoSel.Name = "txtApellidoSel";
            this.txtApellidoSel.ReadOnly = true;
            this.txtApellidoSel.Size = new System.Drawing.Size(234, 20);
            this.txtApellidoSel.TabIndex = 91;
            // 
            // lblDNISel
            // 
            this.lblDNISel.AutoSize = true;
            this.lblDNISel.Location = new System.Drawing.Point(389, 259);
            this.lblDNISel.Name = "lblDNISel";
            this.lblDNISel.Size = new System.Drawing.Size(26, 13);
            this.lblDNISel.TabIndex = 94;
            this.lblDNISel.Text = "DNI";
            // 
            // txtDNISel
            // 
            this.txtDNISel.Location = new System.Drawing.Point(372, 237);
            this.txtDNISel.Name = "txtDNISel";
            this.txtDNISel.ReadOnly = true;
            this.txtDNISel.Size = new System.Drawing.Size(234, 20);
            this.txtDNISel.TabIndex = 93;
            // 
            // lblFechaIngresoSel
            // 
            this.lblFechaIngresoSel.AutoSize = true;
            this.lblFechaIngresoSel.Location = new System.Drawing.Point(389, 297);
            this.lblFechaIngresoSel.Name = "lblFechaIngresoSel";
            this.lblFechaIngresoSel.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngresoSel.TabIndex = 96;
            this.lblFechaIngresoSel.Text = "Fecha de Ingreso";
            // 
            // txtFechaIngresoSel
            // 
            this.txtFechaIngresoSel.Location = new System.Drawing.Point(372, 275);
            this.txtFechaIngresoSel.Name = "txtFechaIngresoSel";
            this.txtFechaIngresoSel.ReadOnly = true;
            this.txtFechaIngresoSel.Size = new System.Drawing.Size(234, 20);
            this.txtFechaIngresoSel.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Operaciones Pendientes";
            // 
            // FormAutorizarMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaIngresoSel);
            this.Controls.Add(this.txtFechaIngresoSel);
            this.Controls.Add(this.lblDNISel);
            this.Controls.Add(this.txtDNISel);
            this.Controls.Add(this.lblApellidoSel);
            this.Controls.Add(this.txtApellidoSel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreSel);
            this.Controls.Add(this.txtNombreSel);
            this.Controls.Add(this.lblLegajoSel);
            this.Controls.Add(this.txtLegajoSel);
            this.Controls.Add(this.lblIdOperacionSel);
            this.Controls.Add(this.lblFechaSolicitudSel);
            this.Controls.Add(this.txtFechaSolicitudSel);
            this.Controls.Add(this.txtIdOperacionSel);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.lstAutorizacionesPendientes);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAutorizarMP";
            this.Text = "Autorizar Modificación de datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ListBox lstAutorizacionesPendientes;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Label lblNombreSel;
        private System.Windows.Forms.TextBox txtNombreSel;
        private System.Windows.Forms.Label lblLegajoSel;
        private System.Windows.Forms.TextBox txtLegajoSel;
        private System.Windows.Forms.Label lblIdOperacionSel;
        private System.Windows.Forms.Label lblFechaSolicitudSel;
        private System.Windows.Forms.TextBox txtFechaSolicitudSel;
        private System.Windows.Forms.TextBox txtIdOperacionSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellidoSel;
        private System.Windows.Forms.TextBox txtApellidoSel;
        private System.Windows.Forms.Label lblDNISel;
        private System.Windows.Forms.TextBox txtDNISel;
        private System.Windows.Forms.Label lblFechaIngresoSel;
        private System.Windows.Forms.TextBox txtFechaIngresoSel;
        private System.Windows.Forms.Label label2;
    }
}