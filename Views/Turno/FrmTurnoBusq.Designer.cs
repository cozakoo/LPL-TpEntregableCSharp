namespace medicApp.Views
{
    partial class FrmTurnoeBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnoeBusq));
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.FechaTurnoDtp = new System.Windows.Forms.DateTimePicker();
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.FechaChk = new System.Windows.Forms.CheckBox();
            this.CentroChk = new System.Windows.Forms.CheckBox();
            this.DniPacienteChk = new System.Windows.Forms.CheckBox();
            this.NroDocPacienteTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(151, 137);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 26);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(89, 137);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 26);
            this.BuscarBtn.TabIndex = 7;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FechaTurnoDtp
            // 
            this.FechaTurnoDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaTurnoDtp.Enabled = false;
            this.FechaTurnoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTurnoDtp.Location = new System.Drawing.Point(96, 12);
            this.FechaTurnoDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTurnoDtp.MaxDate = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDtp.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDtp.Name = "FechaTurnoDtp";
            this.FechaTurnoDtp.Size = new System.Drawing.Size(97, 20);
            this.FechaTurnoDtp.TabIndex = 2;
            this.FechaTurnoDtp.Tag = "FechaTurno";
            // 
            // CentroAtencionCbo
            // 
            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroAtencionCbo.Enabled = false;
            this.CentroAtencionCbo.FormattingEnabled = true;
            this.CentroAtencionCbo.Location = new System.Drawing.Point(92, 14);
            this.CentroAtencionCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionCbo.Name = "CentroAtencionCbo";
            this.CentroAtencionCbo.Size = new System.Drawing.Size(97, 21);
            this.CentroAtencionCbo.TabIndex = 6;
            this.CentroAtencionCbo.Tag = "CodCentroAtencion";
            this.CentroAtencionCbo.ValueMember = "Id";
            // 
            // FechaChk
            // 
            this.FechaChk.AutoSize = true;
            this.FechaChk.Location = new System.Drawing.Point(8, 15);
            this.FechaChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaChk.Name = "FechaChk";
            this.FechaChk.Size = new System.Drawing.Size(56, 17);
            this.FechaChk.TabIndex = 1;
            this.FechaChk.Text = "Fecha";
            this.FechaChk.UseVisualStyleBackColor = true;
            this.FechaChk.CheckedChanged += new System.EventHandler(this.FechaChk_CheckedChanged);
            // 
            // CentroChk
            // 
            this.CentroChk.AutoSize = true;
            this.CentroChk.Location = new System.Drawing.Point(8, 14);
            this.CentroChk.Margin = new System.Windows.Forms.Padding(2);
            this.CentroChk.Name = "CentroChk";
            this.CentroChk.Size = new System.Drawing.Size(57, 17);
            this.CentroChk.TabIndex = 5;
            this.CentroChk.Text = "Centro";
            this.CentroChk.UseVisualStyleBackColor = true;
            this.CentroChk.CheckedChanged += new System.EventHandler(this.CentroChk_CheckedChanged);
            // 
            // DniPacienteChk
            // 
            this.DniPacienteChk.AutoSize = true;
            this.DniPacienteChk.Location = new System.Drawing.Point(7, 13);
            this.DniPacienteChk.Margin = new System.Windows.Forms.Padding(2);
            this.DniPacienteChk.Name = "DniPacienteChk";
            this.DniPacienteChk.Size = new System.Drawing.Size(87, 17);
            this.DniPacienteChk.TabIndex = 3;
            this.DniPacienteChk.Text = "Dni Paciente";
            this.DniPacienteChk.UseVisualStyleBackColor = true;
            this.DniPacienteChk.CheckedChanged += new System.EventHandler(this.DniPacienteChk_CheckedChanged);
            // 
            // NroDocPacienteTxt
            // 
            this.NroDocPacienteTxt.Enabled = false;
            this.NroDocPacienteTxt.Location = new System.Drawing.Point(96, 12);
            this.NroDocPacienteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NroDocPacienteTxt.Name = "NroDocPacienteTxt";
            this.NroDocPacienteTxt.Size = new System.Drawing.Size(97, 20);
            this.NroDocPacienteTxt.TabIndex = 4;
            this.NroDocPacienteTxt.Tag = "Apellido";
            this.NroDocPacienteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaChk);
            this.groupBox1.Controls.Add(this.FechaTurnoDtp);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 41);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NroDocPacienteTxt);
            this.groupBox2.Controls.Add(this.DniPacienteChk);
            this.groupBox2.Location = new System.Drawing.Point(5, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 39);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CentroAtencionCbo);
            this.groupBox3.Controls.Add(this.CentroChk);
            this.groupBox3.Location = new System.Drawing.Point(5, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 44);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // FrmTurnoeBusq
            // 
            this.AcceptButton = this.BuscarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(221, 173);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurnoeBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de turno...";
            this.Activated += new System.EventHandler(this.FrmTurnoeBusq_Activated);
            this.Deactivate += new System.EventHandler(this.FrmTurnoeBusq_Deactivate);
            this.Load += new System.EventHandler(this.FrmTurnoeBusq_Load);
            this.Enter += new System.EventHandler(this.BuscarBtn_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.DateTimePicker FechaTurnoDtp;
        private System.Windows.Forms.ComboBox CentroAtencionCbo;
        private System.Windows.Forms.CheckBox FechaChk;
        private System.Windows.Forms.CheckBox CentroChk;
        private System.Windows.Forms.CheckBox DniPacienteChk;
        private System.Windows.Forms.TextBox NroDocPacienteTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}