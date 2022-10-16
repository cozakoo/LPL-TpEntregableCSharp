namespace medicApp.Views
{
    partial class FrmCentroAtencionBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentroAtencionBusq));
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(23, 17);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 3;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            this.NombreChk.Click += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(89, 15);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(119, 20);
            this.NombreTxt.TabIndex = 4;
            this.NombreTxt.Tag = "Nombre";
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(89, 18);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(119, 21);
            this.LocalidadCbo.TabIndex = 2;
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(14, 20);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 1;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.Click += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(172, 109);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(109, 109);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(59, 27);
            this.BuscarBtn.TabIndex = 5;
            this.BuscarBtn.Text = "&Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LocalidadChk);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 48);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreTxt);
            this.groupBox2.Controls.Add(this.NombreChk);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 44);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // FrmCentroAtencionBusq
            // 
            this.AcceptButton = this.BuscarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(244, 142);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCentroAtencionBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de centro de atención";
            this.Activated += new System.EventHandler(this.FrmCentroAtencionBusq_Activated);
            this.Deactivate += new System.EventHandler(this.FrmCentroAtencionBusq_Deactivate);
            this.Load += new System.EventHandler(this.FrmCentroAtencionBusq_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}