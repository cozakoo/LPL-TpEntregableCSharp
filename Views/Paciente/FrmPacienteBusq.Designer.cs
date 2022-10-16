namespace medicApp.Views
{
    partial class FrmPacienteBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacienteBusq));
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresChk = new System.Windows.Forms.CheckBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(7, 14);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 1;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(70, 14);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(123, 20);
            this.ApellidoTxt.TabIndex = 2;
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // NombresTxt
            // 
            this.NombresTxt.Enabled = false;
            this.NombresTxt.Location = new System.Drawing.Point(89, 13);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(130, 20);
            this.NombresTxt.TabIndex = 6;
            this.NombresTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // NombresChk
            // 
            this.NombresChk.AutoSize = true;
            this.NombresChk.Location = new System.Drawing.Point(17, 15);
            this.NombresChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombresChk.Name = "NombresChk";
            this.NombresChk.Size = new System.Drawing.Size(68, 17);
            this.NombresChk.TabIndex = 5;
            this.NombresChk.Text = "Nombres";
            this.NombresChk.UseVisualStyleBackColor = true;
            this.NombresChk.CheckedChanged += new System.EventHandler(this.NombresChk_CheckedChanged);
            // 
            // DniTxt
            // 
            this.DniTxt.Enabled = false;
            this.DniTxt.Location = new System.Drawing.Point(70, 13);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(123, 20);
            this.DniTxt.TabIndex = 4;
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // DniChk
            // 
            this.DniChk.AutoSize = true;
            this.DniChk.Location = new System.Drawing.Point(5, 13);
            this.DniChk.Margin = new System.Windows.Forms.Padding(2);
            this.DniChk.Name = "DniChk";
            this.DniChk.Size = new System.Drawing.Size(42, 17);
            this.DniChk.TabIndex = 3;
            this.DniChk.Text = "Dni";
            this.DniChk.UseVisualStyleBackColor = true;
            this.DniChk.CheckedChanged += new System.EventHandler(this.DniChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(396, 93);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 10;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(318, 93);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 9;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(89, 11);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(130, 21);
            this.LocalidadCbo.TabIndex = 8;
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(17, 15);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 7;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DniTxt);
            this.groupBox2.Controls.Add(this.DniChk);
            this.groupBox2.Location = new System.Drawing.Point(9, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 41);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NombresTxt);
            this.groupBox3.Controls.Add(this.NombresChk);
            this.groupBox3.Location = new System.Drawing.Point(222, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 42);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LocalidadChk);
            this.groupBox4.Controls.Add(this.LocalidadCbo);
            this.groupBox4.Location = new System.Drawing.Point(222, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 41);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // FrmPacienteBusq
            // 
            this.AcceptButton = this.BuscarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(463, 127);
            this.Controls.Add(this.groupBox4);
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
            this.Name = "FrmPacienteBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de paciente...";
            this.Activated += new System.EventHandler(this.FrmPacienteBusq_Activated);
            this.Deactivate += new System.EventHandler(this.FrmPacienteBusq_Deactivate);
            this.Load += new System.EventHandler(this.FrmPacienteBusq_Load);
            this.Enter += new System.EventHandler(this.BuscarBtn_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.CheckBox NombresChk;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.CheckBox DniChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}