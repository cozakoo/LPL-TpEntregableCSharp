namespace medicApp.Views
{
    partial class FrmPacienteAM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacienteAM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.VacunadoChk = new System.Windows.Forms.CheckBox();
            this.DeRiesgoChk = new System.Windows.Forms.CheckBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.FechaNacDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObservacionesTxt);
            this.groupBox1.Controls.Add(this.VacunadoChk);
            this.groupBox1.Controls.Add(this.DeRiesgoChk);
            this.groupBox1.Controls.Add(this.DniTxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Controls.Add(this.DomicilioTxt);
            this.groupBox1.Controls.Add(this.DomicilioLbl);
            this.groupBox1.Controls.Add(this.FechaNacDtp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoLbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ObservacionesTxt
            // 
            this.ObservacionesTxt.Location = new System.Drawing.Point(19, 277);
            this.ObservacionesTxt.Multiline = true;
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Size = new System.Drawing.Size(255, 71);
            this.ObservacionesTxt.TabIndex = 10;
            this.ObservacionesTxt.Tag = "Observaciones";
            // 
            // VacunadoChk
            // 
            this.VacunadoChk.AutoSize = true;
            this.VacunadoChk.Location = new System.Drawing.Point(199, 254);
            this.VacunadoChk.Name = "VacunadoChk";
            this.VacunadoChk.Size = new System.Drawing.Size(75, 17);
            this.VacunadoChk.TabIndex = 9;
            this.VacunadoChk.Tag = "Vacunado";
            this.VacunadoChk.Text = "&Vacunado";
            this.VacunadoChk.UseVisualStyleBackColor = true;
            // 
            // DeRiesgoChk
            // 
            this.DeRiesgoChk.AutoSize = true;
            this.DeRiesgoChk.Location = new System.Drawing.Point(19, 254);
            this.DeRiesgoChk.Name = "DeRiesgoChk";
            this.DeRiesgoChk.Size = new System.Drawing.Size(71, 17);
            this.DeRiesgoChk.TabIndex = 8;
            this.DeRiesgoChk.Tag = "DeRiesgo";
            this.DeRiesgoChk.Text = "De &riesgo";
            this.DeRiesgoChk.UseVisualStyleBackColor = true;
            // 
            // DniTxt
            // 
            this.DniTxt.Location = new System.Drawing.Point(92, 87);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.MaxLength = 15;
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(96, 20);
            this.DniTxt.TabIndex = 3;
            this.DniTxt.Tag = "NroDocumento";
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(16, 90);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(72, 13);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "Documento(*)";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(92, 224);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(182, 21);
            this.LocalidadCbo.TabIndex = 7;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            this.LocalidadLbl.AutoSize = true;
            this.LocalidadLbl.Location = new System.Drawing.Point(16, 227);
            this.LocalidadLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LocalidadLbl.Name = "LocalidadLbl";
            this.LocalidadLbl.Size = new System.Drawing.Size(66, 13);
            this.LocalidadLbl.TabIndex = 12;
            this.LocalidadLbl.Text = "Localidad (*)";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(92, 190);
            this.TelefonoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(96, 20);
            this.TelefonoTxt.TabIndex = 6;
            this.TelefonoTxt.Tag = "Telefono";
            this.TelefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(16, 193);
            this.TelefonoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 10;
            this.TelefonoLbl.Text = "Telefono";
            // 
            // DomicilioTxt
            // 
            this.DomicilioTxt.Location = new System.Drawing.Point(92, 156);
            this.DomicilioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Size = new System.Drawing.Size(182, 20);
            this.DomicilioTxt.TabIndex = 5;
            this.DomicilioTxt.Tag = "Domicilio";
            this.DomicilioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLinea_Numerot_KeyPress);
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(16, 159);
            this.DomicilioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(62, 13);
            this.DomicilioLbl.TabIndex = 8;
            this.DomicilioLbl.Text = "Domicilio (*)";
            // 
            // FechaNacDtp
            // 
            this.FechaNacDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaNacDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacDtp.Location = new System.Drawing.Point(92, 125);
            this.FechaNacDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaNacDtp.MaxDate = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.FechaNacDtp.MinDate = new System.DateTime(1890, 6, 27, 0, 0, 0, 0);
            this.FechaNacDtp.Name = "FechaNacDtp";
            this.FechaNacDtp.Size = new System.Drawing.Size(96, 20);
            this.FechaNacDtp.TabIndex = 4;
            this.FechaNacDtp.Tag = "FechaNac";
            this.FechaNacDtp.Value = new System.DateTime(2020, 6, 25, 0, 0, 0, 0);
            this.FechaNacDtp.ValueChanged += new System.EventHandler(this.FechaNacDtp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha.Nac (*)";
            // 
            // NombresTxt
            // 
            this.NombresTxt.Location = new System.Drawing.Point(92, 49);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.MaxLength = 90;
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(182, 20);
            this.NombresTxt.TabIndex = 2;
            this.NombresTxt.Tag = "Nombres";
            this.NombresTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(16, 52);
            this.NombresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(62, 13);
            this.NombresLbl.TabIndex = 2;
            this.NombresLbl.Text = "Nombres (*)";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(92, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.MaxLength = 50;
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(182, 20);
            this.ApellidoTxt.TabIndex = 1;
            this.ApellidoTxt.Tag = "Apellido";
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(16, 18);
            this.ApellidoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(62, 13);
            this.ApellidoLbl.TabIndex = 0;
            this.ApellidoLbl.Text = "Apellidos (*)";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(242, 370);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(169, 370);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPacienteAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(318, 408);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPacienteAM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de paciente...";
            this.Activated += new System.EventHandler(this.FrmPacienteAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmPacienteAM_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.DateTimePicker FechaNacDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.CheckBox DeRiesgoChk;
        private System.Windows.Forms.CheckBox VacunadoChk;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}