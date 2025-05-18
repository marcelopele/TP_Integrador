namespace TP_Integrador
{
    partial class FormModificarPersona
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDNISel = new System.Windows.Forms.Label();
            this.txtDNISel = new System.Windows.Forms.TextBox();
            this.lblApellidoSel = new System.Windows.Forms.Label();
            this.txtApellidoSel = new System.Windows.Forms.TextBox();
            this.lblLegajoSel = new System.Windows.Forms.Label();
            this.lblNombreSel = new System.Windows.Forms.Label();
            this.txtNombreSel = new System.Windows.Forms.TextBox();
            this.txtLegajoSel = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblFhIngresoSel = new System.Windows.Forms.Label();
            this.txtFhIngresoTxt = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtFhIngresoSel = new System.Windows.Forms.DateTimePicker();
            this.errMsj = new System.Windows.Forms.Label();
            this.errApellido = new System.Windows.Forms.Label();
            this.errNombre = new System.Windows.Forms.Label();
            this.errFhIngreso = new System.Windows.Forms.Label();
            this.errDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.Location = new System.Drawing.Point(271, 9);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(180, 13);
            this.lblPerfil.TabIndex = 59;
            this.lblPerfil.Text = "label1";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 58;
            this.lblNombreUsuario.Text = "label1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(42, 400);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(142, 23);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDNISel
            // 
            this.lblDNISel.AutoSize = true;
            this.lblDNISel.Location = new System.Drawing.Point(276, 245);
            this.lblDNISel.Name = "lblDNISel";
            this.lblDNISel.Size = new System.Drawing.Size(26, 13);
            this.lblDNISel.TabIndex = 68;
            this.lblDNISel.Text = "DNI";
            // 
            // txtDNISel
            // 
            this.txtDNISel.Location = new System.Drawing.Point(260, 223);
            this.txtDNISel.Name = "txtDNISel";
            this.txtDNISel.ReadOnly = true;
            this.txtDNISel.Size = new System.Drawing.Size(179, 20);
            this.txtDNISel.TabIndex = 64;
            // 
            // lblApellidoSel
            // 
            this.lblApellidoSel.AutoSize = true;
            this.lblApellidoSel.Location = new System.Drawing.Point(276, 196);
            this.lblApellidoSel.Name = "lblApellidoSel";
            this.lblApellidoSel.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoSel.TabIndex = 67;
            this.lblApellidoSel.Text = "Apellido";
            // 
            // txtApellidoSel
            // 
            this.txtApellidoSel.Location = new System.Drawing.Point(260, 173);
            this.txtApellidoSel.Name = "txtApellidoSel";
            this.txtApellidoSel.ReadOnly = true;
            this.txtApellidoSel.Size = new System.Drawing.Size(179, 20);
            this.txtApellidoSel.TabIndex = 63;
            // 
            // lblLegajoSel
            // 
            this.lblLegajoSel.AutoSize = true;
            this.lblLegajoSel.Location = new System.Drawing.Point(276, 100);
            this.lblLegajoSel.Name = "lblLegajoSel";
            this.lblLegajoSel.Size = new System.Drawing.Size(39, 13);
            this.lblLegajoSel.TabIndex = 66;
            this.lblLegajoSel.Text = "Legajo";
            // 
            // lblNombreSel
            // 
            this.lblNombreSel.AutoSize = true;
            this.lblNombreSel.Location = new System.Drawing.Point(276, 148);
            this.lblNombreSel.Name = "lblNombreSel";
            this.lblNombreSel.Size = new System.Drawing.Size(44, 13);
            this.lblNombreSel.TabIndex = 65;
            this.lblNombreSel.Text = "Nombre";
            // 
            // txtNombreSel
            // 
            this.txtNombreSel.Location = new System.Drawing.Point(260, 125);
            this.txtNombreSel.Name = "txtNombreSel";
            this.txtNombreSel.ReadOnly = true;
            this.txtNombreSel.Size = new System.Drawing.Size(179, 20);
            this.txtNombreSel.TabIndex = 62;
            // 
            // txtLegajoSel
            // 
            this.txtLegajoSel.Enabled = false;
            this.txtLegajoSel.Location = new System.Drawing.Point(260, 77);
            this.txtLegajoSel.Name = "txtLegajoSel";
            this.txtLegajoSel.ReadOnly = true;
            this.txtLegajoSel.Size = new System.Drawing.Size(179, 20);
            this.txtLegajoSel.TabIndex = 61;
            // 
            // lblPersona
            // 
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(259, 43);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(180, 13);
            this.lblPersona.TabIndex = 69;
            this.lblPersona.Text = "Persona Seleccionada";
            this.lblPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFhIngresoSel
            // 
            this.lblFhIngresoSel.AutoSize = true;
            this.lblFhIngresoSel.Location = new System.Drawing.Point(276, 293);
            this.lblFhIngresoSel.Name = "lblFhIngresoSel";
            this.lblFhIngresoSel.Size = new System.Drawing.Size(90, 13);
            this.lblFhIngresoSel.TabIndex = 71;
            this.lblFhIngresoSel.Text = "Fecha de Ingreso";
            // 
            // txtFhIngresoTxt
            // 
            this.txtFhIngresoTxt.Location = new System.Drawing.Point(260, 271);
            this.txtFhIngresoTxt.Name = "txtFhIngresoTxt";
            this.txtFhIngresoTxt.ReadOnly = true;
            this.txtFhIngresoTxt.Size = new System.Drawing.Size(179, 20);
            this.txtFhIngresoTxt.TabIndex = 70;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(260, 338);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 23);
            this.btnConfirmar.TabIndex = 72;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(352, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(15, 43);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(197, 316);
            this.lstPersonas.TabIndex = 74;
            this.lstPersonas.Click += new System.EventHandler(this.lstPersonas_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(261, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(177, 23);
            this.btnModificar.TabIndex = 75;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtFhIngresoSel
            // 
            this.txtFhIngresoSel.Location = new System.Drawing.Point(260, 271);
            this.txtFhIngresoSel.Name = "txtFhIngresoSel";
            this.txtFhIngresoSel.Size = new System.Drawing.Size(181, 20);
            this.txtFhIngresoSel.TabIndex = 76;
            this.txtFhIngresoSel.Visible = false;
            // 
            // errMsj
            // 
            this.errMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errMsj.AutoSize = true;
            this.errMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsj.ForeColor = System.Drawing.Color.Red;
            this.errMsj.Location = new System.Drawing.Point(211, 364);
            this.errMsj.Name = "errMsj";
            this.errMsj.Size = new System.Drawing.Size(55, 15);
            this.errMsj.TabIndex = 77;
            this.errMsj.Text = "mensaje";
            this.errMsj.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errMsj.Visible = false;
            // 
            // errApellido
            // 
            this.errApellido.AutoSize = true;
            this.errApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errApellido.ForeColor = System.Drawing.Color.Red;
            this.errApellido.Location = new System.Drawing.Point(440, 173);
            this.errApellido.Name = "errApellido";
            this.errApellido.Size = new System.Drawing.Size(15, 20);
            this.errApellido.TabIndex = 79;
            this.errApellido.Text = "*";
            this.errApellido.Visible = false;
            // 
            // errNombre
            // 
            this.errNombre.AutoSize = true;
            this.errNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errNombre.ForeColor = System.Drawing.Color.Red;
            this.errNombre.Location = new System.Drawing.Point(440, 125);
            this.errNombre.Name = "errNombre";
            this.errNombre.Size = new System.Drawing.Size(15, 20);
            this.errNombre.TabIndex = 78;
            this.errNombre.Text = "*";
            this.errNombre.Visible = false;
            // 
            // errFhIngreso
            // 
            this.errFhIngreso.AutoSize = true;
            this.errFhIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFhIngreso.ForeColor = System.Drawing.Color.Red;
            this.errFhIngreso.Location = new System.Drawing.Point(440, 272);
            this.errFhIngreso.Name = "errFhIngreso";
            this.errFhIngreso.Size = new System.Drawing.Size(15, 20);
            this.errFhIngreso.TabIndex = 81;
            this.errFhIngreso.Text = "*";
            this.errFhIngreso.Visible = false;
            // 
            // errDNI
            // 
            this.errDNI.AutoSize = true;
            this.errDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errDNI.ForeColor = System.Drawing.Color.Red;
            this.errDNI.Location = new System.Drawing.Point(440, 223);
            this.errDNI.Name = "errDNI";
            this.errDNI.Size = new System.Drawing.Size(15, 20);
            this.errDNI.TabIndex = 80;
            this.errDNI.Text = "*";
            this.errDNI.Visible = false;
            // 
            // FormModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.errFhIngreso);
            this.Controls.Add(this.errDNI);
            this.Controls.Add(this.errApellido);
            this.Controls.Add(this.errNombre);
            this.Controls.Add(this.errMsj);
            this.Controls.Add(this.txtFhIngresoSel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblFhIngresoSel);
            this.Controls.Add(this.txtFhIngresoTxt);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblDNISel);
            this.Controls.Add(this.txtDNISel);
            this.Controls.Add(this.lblApellidoSel);
            this.Controls.Add(this.txtApellidoSel);
            this.Controls.Add(this.lblLegajoSel);
            this.Controls.Add(this.lblNombreSel);
            this.Controls.Add(this.txtNombreSel);
            this.Controls.Add(this.txtLegajoSel);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormModificarPersona";
            this.Text = "Modificar Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDNISel;
        private System.Windows.Forms.TextBox txtDNISel;
        private System.Windows.Forms.Label lblApellidoSel;
        private System.Windows.Forms.TextBox txtApellidoSel;
        private System.Windows.Forms.Label lblLegajoSel;
        private System.Windows.Forms.Label lblNombreSel;
        private System.Windows.Forms.TextBox txtNombreSel;
        private System.Windows.Forms.TextBox txtLegajoSel;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblFhIngresoSel;
        private System.Windows.Forms.TextBox txtFhIngresoTxt;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker txtFhIngresoSel;
        private System.Windows.Forms.Label errMsj;
        private System.Windows.Forms.Label errApellido;
        private System.Windows.Forms.Label errNombre;
        private System.Windows.Forms.Label errFhIngreso;
        private System.Windows.Forms.Label errDNI;
    }
}