namespace medicApp.Views
{
    partial class FrmVacunaBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacunaBusq));
            this.TipoVacunatxt = new System.Windows.Forms.ComboBox();
            this.TipoVacunaChk = new System.Windows.Forms.CheckBox();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.LoteTxt = new System.Windows.Forms.TextBox();
            this.CantidadChk = new System.Windows.Forms.CheckBox();
            this.LoteChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoVacunatxt
            // 
            this.TipoVacunatxt.DisplayMember = "Nombre";
            this.TipoVacunatxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVacunatxt.Enabled = false;
            this.TipoVacunatxt.FormattingEnabled = true;
            this.TipoVacunatxt.Location = new System.Drawing.Point(93, 12);
            this.TipoVacunatxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoVacunatxt.Name = "TipoVacunatxt";
            this.TipoVacunatxt.Size = new System.Drawing.Size(147, 21);
            this.TipoVacunatxt.TabIndex = 2;
            this.TipoVacunatxt.ValueMember = "Id";
            // 
            // TipoVacunaChk
            // 
            this.TipoVacunaChk.AutoSize = true;
            this.TipoVacunaChk.Location = new System.Drawing.Point(5, 14);
            this.TipoVacunaChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoVacunaChk.Name = "TipoVacunaChk";
            this.TipoVacunaChk.Size = new System.Drawing.Size(86, 17);
            this.TipoVacunaChk.TabIndex = 1;
            this.TipoVacunaChk.Text = "Tipo vacuna";
            this.TipoVacunaChk.UseVisualStyleBackColor = true;
            this.TipoVacunaChk.CheckedChanged += new System.EventHandler(this.TipoVacunaChk_CheckedChanged);
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Enabled = false;
            this.CantidadTxt.Location = new System.Drawing.Point(93, 14);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(30, 20);
            this.CantidadTxt.TabIndex = 4;
            this.CantidadTxt.Tag = "Cantidad";
            this.CantidadTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // LoteTxt
            // 
            this.LoteTxt.Enabled = false;
            this.LoteTxt.Location = new System.Drawing.Point(57, 14);
            this.LoteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LoteTxt.Name = "LoteTxt";
            this.LoteTxt.Size = new System.Drawing.Size(37, 20);
            this.LoteTxt.TabIndex = 6;
            this.LoteTxt.Tag = "lote";
            this.LoteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // CantidadChk
            // 
            this.CantidadChk.AutoSize = true;
            this.CantidadChk.Location = new System.Drawing.Point(5, 14);
            this.CantidadChk.Name = "CantidadChk";
            this.CantidadChk.Size = new System.Drawing.Size(68, 17);
            this.CantidadChk.TabIndex = 3;
            this.CantidadChk.Text = "Cantidad";
            this.CantidadChk.UseVisualStyleBackColor = true;
            this.CantidadChk.CheckedChanged += new System.EventHandler(this.CantidadChk_CheckedChanged);
            // 
            // LoteChk
            // 
            this.LoteChk.AutoSize = true;
            this.LoteChk.Location = new System.Drawing.Point(5, 14);
            this.LoteChk.Name = "LoteChk";
            this.LoteChk.Size = new System.Drawing.Size(47, 17);
            this.LoteChk.TabIndex = 5;
            this.LoteChk.Text = "Lote";
            this.LoteChk.UseVisualStyleBackColor = true;
            this.LoteChk.CheckedChanged += new System.EventHandler(this.LoteChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(205, 86);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(143, 86);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 7;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoVacunatxt);
            this.groupBox1.Controls.Add(this.TipoVacunaChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 39);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CantidadChk);
            this.groupBox2.Controls.Add(this.CantidadTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 39);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoteChk);
            this.groupBox3.Controls.Add(this.LoteTxt);
            this.groupBox3.Location = new System.Drawing.Point(158, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 41);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // FrmVacunaBusq
            // 
            this.AcceptButton = this.BuscarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(271, 126);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVacunaBusq";
            this.Text = "Búsqueda de vacunas";
            this.Activated += new System.EventHandler(this.FrmVacunaBusq_Activated);
            this.Deactivate += new System.EventHandler(this.FrmVacunaBusq_Deactivate);
            this.Load += new System.EventHandler(this.FrmVacunaBusq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TipoVacunatxt;
        private System.Windows.Forms.CheckBox TipoVacunaChk;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.TextBox LoteTxt;
        private System.Windows.Forms.CheckBox CantidadChk;
        private System.Windows.Forms.CheckBox LoteChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}