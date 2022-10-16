namespace medicApp.Views
{
    partial class FrmVacunaAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacunaAM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoVacunaCbo = new System.Windows.Forms.ComboBox();
            this.FechaVencDtp = new System.Windows.Forms.DateTimePicker();
            this.CodTipoVacunaLbl = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.CantidadLbl = new System.Windows.Forms.Label();
            this.FechaVencLbl = new System.Windows.Forms.Label();
            this.LoteTxt = new System.Windows.Forms.TextBox();
            this.LoteLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoVacunaCbo);
            this.groupBox1.Controls.Add(this.FechaVencDtp);
            this.groupBox1.Controls.Add(this.CodTipoVacunaLbl);
            this.groupBox1.Controls.Add(this.CantidadTxt);
            this.groupBox1.Controls.Add(this.CantidadLbl);
            this.groupBox1.Controls.Add(this.FechaVencLbl);
            this.groupBox1.Controls.Add(this.LoteTxt);
            this.groupBox1.Controls.Add(this.LoteLbl);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(241, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // TipoVacunaCbo
            // 
            this.TipoVacunaCbo.DisplayMember = "Nombre";
            this.TipoVacunaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVacunaCbo.FormattingEnabled = true;
            this.TipoVacunaCbo.Location = new System.Drawing.Point(94, 39);
            this.TipoVacunaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.TipoVacunaCbo.Name = "TipoVacunaCbo";
            this.TipoVacunaCbo.Size = new System.Drawing.Size(139, 21);
            this.TipoVacunaCbo.TabIndex = 2;
            this.TipoVacunaCbo.Tag = "CodTipoVacuna";
            this.TipoVacunaCbo.ValueMember = "Id";
            // 
            // FechaVencDtp
            // 
            this.FechaVencDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaVencDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencDtp.Location = new System.Drawing.Point(94, 15);
            this.FechaVencDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaVencDtp.Name = "FechaVencDtp";
            this.FechaVencDtp.Size = new System.Drawing.Size(111, 20);
            this.FechaVencDtp.TabIndex = 1;
            this.FechaVencDtp.Tag = "FechaVenc";
            this.FechaVencDtp.ValueChanged += new System.EventHandler(this.FechaVencDtp_ValueChanged);
            // 
            // CodTipoVacunaLbl
            // 
            this.CodTipoVacunaLbl.AutoSize = true;
            this.CodTipoVacunaLbl.Location = new System.Drawing.Point(4, 41);
            this.CodTipoVacunaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodTipoVacunaLbl.Name = "CodTipoVacunaLbl";
            this.CodTipoVacunaLbl.Size = new System.Drawing.Size(81, 13);
            this.CodTipoVacunaLbl.TabIndex = 16;
            this.CodTipoVacunaLbl.Text = "Tipo Vacuna (*)";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Location = new System.Drawing.Point(94, 64);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(30, 20);
            this.CantidadTxt.TabIndex = 3;
            this.CantidadTxt.Tag = "Cantidad";
            this.CantidadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // CantidadLbl
            // 
            this.CantidadLbl.AutoSize = true;
            this.CantidadLbl.Location = new System.Drawing.Point(23, 67);
            this.CantidadLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CantidadLbl.Name = "CantidadLbl";
            this.CantidadLbl.Size = new System.Drawing.Size(62, 13);
            this.CantidadLbl.TabIndex = 10;
            this.CantidadLbl.Text = "Cantidad (*)";
            // 
            // FechaVencLbl
            // 
            this.FechaVencLbl.AutoSize = true;
            this.FechaVencLbl.Location = new System.Drawing.Point(7, 15);
            this.FechaVencLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaVencLbl.Name = "FechaVencLbl";
            this.FechaVencLbl.Size = new System.Drawing.Size(78, 13);
            this.FechaVencLbl.TabIndex = 4;
            this.FechaVencLbl.Text = "Fecha.Venc (*)";
            // 
            // LoteTxt
            // 
            this.LoteTxt.Location = new System.Drawing.Point(203, 64);
            this.LoteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LoteTxt.Name = "LoteTxt";
            this.LoteTxt.Size = new System.Drawing.Size(30, 20);
            this.LoteTxt.TabIndex = 4;
            this.LoteTxt.Tag = "Lote";
            this.LoteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // LoteLbl
            // 
            this.LoteLbl.AutoSize = true;
            this.LoteLbl.Location = new System.Drawing.Point(164, 67);
            this.LoteLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoteLbl.Name = "LoteLbl";
            this.LoteLbl.Size = new System.Drawing.Size(41, 13);
            this.LoteLbl.TabIndex = 2;
            this.LoteLbl.Text = "Lote (*)";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(193, 108);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(123, 108);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmVacunaAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVacunaAM";
            this.Text = "Registro de Vacuna";
            this.Activated += new System.EventHandler(this.FrmVacunaAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmVacunaAM_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodTipoVacunaLbl;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.Label CantidadLbl;
        private System.Windows.Forms.Label FechaVencLbl;
        private System.Windows.Forms.TextBox LoteTxt;
        private System.Windows.Forms.Label LoteLbl;
        private System.Windows.Forms.DateTimePicker FechaVencDtp;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox TipoVacunaCbo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}