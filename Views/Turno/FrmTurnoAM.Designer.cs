namespace medicApp.Views
{
    partial class FrmTurnoAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnoAM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnfermoCbo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VacunaCbo = new System.Windows.Forms.ComboBox();
            this.Dosistxt = new System.Windows.Forms.NumericUpDown();
            this.AsistioChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.horaslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minutotxt = new System.Windows.Forms.NumericUpDown();
            this.Horatxt = new System.Windows.Forms.NumericUpDown();
            this.FechaTurnoDtp = new System.Windows.Forms.DateTimePicker();
            this.Localidadlbl = new System.Windows.Forms.Label();
            this.CentroAtencionlbl = new System.Windows.Forms.Label();
            this.FechaVencLbl = new System.Windows.Forms.Label();
            this.DniLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.NroDocPacienteTxt = new System.Windows.Forms.TextBox();
            this.DocPacienteLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dosistxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutotxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horatxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EnfermoCbo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VacunaCbo);
            this.groupBox1.Controls.Add(this.Dosistxt);
            this.groupBox1.Controls.Add(this.AsistioChk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.horaslbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minutotxt);
            this.groupBox1.Controls.Add(this.Horatxt);
            this.groupBox1.Controls.Add(this.FechaTurnoDtp);
            this.groupBox1.Controls.Add(this.Localidadlbl);
            this.groupBox1.Controls.Add(this.CentroAtencionlbl);
            this.groupBox1.Controls.Add(this.FechaVencLbl);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.CentroAtencionCbo);
            this.groupBox1.Controls.Add(this.NroDocPacienteTxt);
            this.groupBox1.Controls.Add(this.DocPacienteLbl);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enfermero (*)";
            // 
            // EnfermoCbo
            // 
            this.EnfermoCbo.DisplayMember = "Nombre";
            this.EnfermoCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnfermoCbo.FormattingEnabled = true;
            this.EnfermoCbo.Location = new System.Drawing.Point(120, 97);
            this.EnfermoCbo.Margin = new System.Windows.Forms.Padding(2);
            this.EnfermoCbo.Name = "EnfermoCbo";
            this.EnfermoCbo.Size = new System.Drawing.Size(148, 21);
            this.EnfermoCbo.TabIndex = 4;
            this.EnfermoCbo.Tag = "NroDocEnfermero";
            this.EnfermoCbo.ValueMember = "nombres";
            this.EnfermoCbo.SelectedIndexChanged += new System.EventHandler(this.EnfermoCbo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Vacuna (*)";
            // 
            // VacunaCbo
            // 
            this.VacunaCbo.DisplayMember = "Nombre";
            this.VacunaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VacunaCbo.FormattingEnabled = true;
            this.VacunaCbo.Location = new System.Drawing.Point(120, 157);
            this.VacunaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.VacunaCbo.Name = "VacunaCbo";
            this.VacunaCbo.Size = new System.Drawing.Size(148, 21);
            this.VacunaCbo.TabIndex = 6;
            this.VacunaCbo.Tag = "CodVacuna";
            this.VacunaCbo.ValueMember = "Id";
            this.VacunaCbo.SelectedIndexChanged += new System.EventHandler(this.VacunaCbo_SelectedIndexChanged);
            this.VacunaCbo.Click += new System.EventHandler(this.VacunaCbo_Click);
            // 
            // Dosistxt
            // 
            this.Dosistxt.Location = new System.Drawing.Point(120, 190);
            this.Dosistxt.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Dosistxt.Name = "Dosistxt";
            this.Dosistxt.Size = new System.Drawing.Size(33, 20);
            this.Dosistxt.TabIndex = 7;
            this.Dosistxt.Tag = "NroDosis";
            this.Dosistxt.ValueChanged += new System.EventHandler(this.Dosistxt_ValueChanged);
            // 
            // AsistioChk
            // 
            this.AsistioChk.AutoSize = true;
            this.AsistioChk.Location = new System.Drawing.Point(177, 193);
            this.AsistioChk.Margin = new System.Windows.Forms.Padding(2);
            this.AsistioChk.Name = "AsistioChk";
            this.AsistioChk.Size = new System.Drawing.Size(56, 17);
            this.AsistioChk.TabIndex = 8;
            this.AsistioChk.Text = "Asistio";
            this.AsistioChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Horario Disponible (*)";
            // 
            // horaslbl
            // 
            this.horaslbl.AutoSize = true;
            this.horaslbl.Location = new System.Drawing.Point(209, 223);
            this.horaslbl.Name = "horaslbl";
            this.horaslbl.Size = new System.Drawing.Size(24, 13);
            this.horaslbl.TabIndex = 24;
            this.horaslbl.Text = "hrs.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = ":";
            // 
            // minutotxt
            // 
            this.minutotxt.Location = new System.Drawing.Point(165, 220);
            this.minutotxt.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.minutotxt.Name = "minutotxt";
            this.minutotxt.Size = new System.Drawing.Size(38, 20);
            this.minutotxt.TabIndex = 10;
            this.minutotxt.ValueChanged += new System.EventHandler(this.minutotxt_ValueChanged);
            // 
            // Horatxt
            // 
            this.Horatxt.Location = new System.Drawing.Point(120, 220);
            this.Horatxt.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Horatxt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Horatxt.Name = "Horatxt";
            this.Horatxt.Size = new System.Drawing.Size(33, 20);
            this.Horatxt.TabIndex = 9;
            this.Horatxt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // FechaTurnoDtp
            // 
            this.FechaTurnoDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaTurnoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTurnoDtp.Location = new System.Drawing.Point(120, 127);
            this.FechaTurnoDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTurnoDtp.MaxDate = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDtp.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDtp.Name = "FechaTurnoDtp";
            this.FechaTurnoDtp.Size = new System.Drawing.Size(88, 20);
            this.FechaTurnoDtp.TabIndex = 5;
            this.FechaTurnoDtp.Tag = "Fecha";
            this.FechaTurnoDtp.ValueChanged += new System.EventHandler(this.FechaTurnoDtp_ValueChanged);
            // 
            // Localidadlbl
            // 
            this.Localidadlbl.Location = new System.Drawing.Point(44, 43);
            this.Localidadlbl.Name = "Localidadlbl";
            this.Localidadlbl.Size = new System.Drawing.Size(70, 21);
            this.Localidadlbl.TabIndex = 18;
            this.Localidadlbl.Text = " Localidad (*)";
            // 
            // CentroAtencionlbl
            // 
            this.CentroAtencionlbl.Location = new System.Drawing.Point(19, 73);
            this.CentroAtencionlbl.Name = "CentroAtencionlbl";
            this.CentroAtencionlbl.Size = new System.Drawing.Size(95, 18);
            this.CentroAtencionlbl.TabIndex = 17;
            this.CentroAtencionlbl.Text = "Centro atencion (*)";
            // 
            // FechaVencLbl
            // 
            this.FechaVencLbl.AutoSize = true;
            this.FechaVencLbl.Location = new System.Drawing.Point(64, 130);
            this.FechaVencLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaVencLbl.Name = "FechaVencLbl";
            this.FechaVencLbl.Size = new System.Drawing.Size(50, 13);
            this.FechaVencLbl.TabIndex = 19;
            this.FechaVencLbl.Text = "Fecha (*)";
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(48, 192);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(66, 13);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "Nro Dosis (*)";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(120, 43);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(148, 21);
            this.LocalidadCbo.TabIndex = 2;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            this.LocalidadCbo.SelectedIndexChanged += new System.EventHandler(this.LocalidadCbo_SelectedIndexChanged);
            // 
            // CentroAtencionCbo
            // 
            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroAtencionCbo.FormattingEnabled = true;
            this.CentroAtencionCbo.Location = new System.Drawing.Point(120, 70);
            this.CentroAtencionCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionCbo.Name = "CentroAtencionCbo";
            this.CentroAtencionCbo.Size = new System.Drawing.Size(148, 21);
            this.CentroAtencionCbo.TabIndex = 3;
            this.CentroAtencionCbo.Tag = "CodCentroAtencion";
            this.CentroAtencionCbo.ValueMember = "Id";
            this.CentroAtencionCbo.SelectedIndexChanged += new System.EventHandler(this.CentroAtencionCbo_SelectedIndexChanged);
            // 
            // NroDocPacienteTxt
            // 
            this.NroDocPacienteTxt.Location = new System.Drawing.Point(120, 17);
            this.NroDocPacienteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NroDocPacienteTxt.Name = "NroDocPacienteTxt";
            this.NroDocPacienteTxt.Size = new System.Drawing.Size(148, 20);
            this.NroDocPacienteTxt.TabIndex = 1;
            this.NroDocPacienteTxt.Tag = "NroDocPaciente";
            this.NroDocPacienteTxt.TextChanged += new System.EventHandler(this.NroDocPacienteTxt_TextChanged);
            this.NroDocPacienteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // DocPacienteLbl
            // 
            this.DocPacienteLbl.AutoSize = true;
            this.DocPacienteLbl.Location = new System.Drawing.Point(10, 20);
            this.DocPacienteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocPacienteLbl.Name = "DocPacienteLbl";
            this.DocPacienteLbl.Size = new System.Drawing.Size(104, 13);
            this.DocPacienteLbl.TabIndex = 0;
            this.DocPacienteLbl.Text = "Doc del paciente  (*)";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(233, 286);
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
            this.GuardarBtn.Enabled = false;
            this.GuardarBtn.Location = new System.Drawing.Point(161, 286);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmTurnoAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(300, 324);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurnoAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Turno...";
            this.Activated += new System.EventHandler(this.FrmTurnoAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmTurnoAM_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dosistxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutotxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horatxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DniLbl;

        private System.Windows.Forms.ComboBox CentroAtencionCbo;

        private System.Windows.Forms.ComboBox LocalidadCbo;
        
        private System.Windows.Forms.TextBox NroDocPacienteTxt;
        private System.Windows.Forms.Label DocPacienteLbl;
        
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label CentroAtencionlbl;
        private System.Windows.Forms.Label Localidadlbl;
        private System.Windows.Forms.DateTimePicker FechaTurnoDtp;
        private System.Windows.Forms.Label FechaVencLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minutotxt;
        private System.Windows.Forms.NumericUpDown Horatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label horaslbl;
        private System.Windows.Forms.NumericUpDown Dosistxt;
        private System.Windows.Forms.CheckBox AsistioChk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VacunaCbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EnfermoCbo;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}