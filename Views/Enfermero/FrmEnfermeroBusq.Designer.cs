namespace medicApp.Views
{
    partial class FrmEnfermeroBusq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnfermeroBusq));
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CentroChk = new System.Windows.Forms.CheckBox();
            this.MatriculaTxt = new System.Windows.Forms.TextBox();
            this.MatriculaChk = new System.Windows.Forms.CheckBox();
            this.CentroCbo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(7, 18);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 3;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(76, 18);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(125, 20);
            this.ApellidoTxt.TabIndex = 4;
            this.ApellidoTxt.TextChanged += new System.EventHandler(this.ApellidoTxt_TextChanged);
            // 
            // NombresTxt
            // 
            this.NombresTxt.Enabled = false;
            this.NombresTxt.Location = new System.Drawing.Point(76, 14);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(125, 20);
            this.NombresTxt.TabIndex = 2;
            this.NombresTxt.TextChanged += new System.EventHandler(this.NombresTxt_TextChanged);
            // 
            // NombresChk
            // 
            this.NombresChk.AutoSize = true;
            this.NombresChk.Location = new System.Drawing.Point(5, 16);
            this.NombresChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombresChk.Name = "NombresChk";
            this.NombresChk.Size = new System.Drawing.Size(68, 17);
            this.NombresChk.TabIndex = 1;
            this.NombresChk.Text = "Nombres";
            this.NombresChk.UseVisualStyleBackColor = true;
            this.NombresChk.CheckedChanged += new System.EventHandler(this.NombresChk_CheckedChanged);
            // 
            // DniTxt
            // 
            this.DniTxt.Enabled = false;
            this.DniTxt.Location = new System.Drawing.Point(76, 16);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(122, 20);
            this.DniTxt.TabIndex = 6;
            this.DniTxt.TextChanged += new System.EventHandler(this.DniTxt_TextChanged);
            // 
            // DniChk
            // 
            this.DniChk.AutoSize = true;
            this.DniChk.Location = new System.Drawing.Point(6, 19);
            this.DniChk.Margin = new System.Windows.Forms.Padding(2);
            this.DniChk.Name = "DniChk";
            this.DniChk.Size = new System.Drawing.Size(42, 17);
            this.DniChk.TabIndex = 5;
            this.DniChk.Text = "Dni";
            this.DniChk.UseVisualStyleBackColor = true;
            this.DniChk.CheckedChanged += new System.EventHandler(this.DniChk_CheckedChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(342, 122);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(268, 122);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 11;
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
            this.LocalidadCbo.Location = new System.Drawing.Point(83, 14);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(122, 21);
            this.LocalidadCbo.TabIndex = 10;
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(7, 18);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 9;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CentroChk
            // 
            this.CentroChk.AutoSize = true;
            this.CentroChk.Location = new System.Drawing.Point(7, 11);
            this.CentroChk.Margin = new System.Windows.Forms.Padding(2);
            this.CentroChk.Name = "CentroChk";
            this.CentroChk.Size = new System.Drawing.Size(57, 17);
            this.CentroChk.TabIndex = 14;
            this.CentroChk.Text = "Centro";
            this.CentroChk.UseVisualStyleBackColor = true;
            this.CentroChk.CheckedChanged += new System.EventHandler(this.CentroChk_CheckedChanged);
            // 
            // MatriculaTxt
            // 
            this.MatriculaTxt.Enabled = false;
            this.MatriculaTxt.Location = new System.Drawing.Point(83, 17);
            this.MatriculaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.MatriculaTxt.Name = "MatriculaTxt";
            this.MatriculaTxt.Size = new System.Drawing.Size(122, 20);
            this.MatriculaTxt.TabIndex = 8;
            this.MatriculaTxt.TextChanged += new System.EventHandler(this.MatriculaTxt_TextChanged);
            // 
            // MatriculaChk
            // 
            this.MatriculaChk.AutoSize = true;
            this.MatriculaChk.Location = new System.Drawing.Point(6, 17);
            this.MatriculaChk.Margin = new System.Windows.Forms.Padding(2);
            this.MatriculaChk.Name = "MatriculaChk";
            this.MatriculaChk.Size = new System.Drawing.Size(69, 17);
            this.MatriculaChk.TabIndex = 7;
            this.MatriculaChk.Text = "Matricula";
            this.MatriculaChk.UseVisualStyleBackColor = true;
            this.MatriculaChk.CheckedChanged += new System.EventHandler(this.MatriculaChk_CheckedChanged);
            this.MatriculaChk.TextChanged += new System.EventHandler(this.MatriculaChk_CheckedChanged);
            // 
            // CentroCbo
            // 
            this.CentroCbo.DisplayMember = "Nombre";
            this.CentroCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroCbo.Enabled = false;
            this.CentroCbo.FormattingEnabled = true;
            this.CentroCbo.Location = new System.Drawing.Point(78, 9);
            this.CentroCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroCbo.Name = "CentroCbo";
            this.CentroCbo.Size = new System.Drawing.Size(122, 21);
            this.CentroCbo.TabIndex = 15;
            this.CentroCbo.ValueMember = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 42);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CentroCbo);
            this.groupBox6.Controls.Add(this.CentroChk);
            this.groupBox6.Location = new System.Drawing.Point(310, 50);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 43);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ApellidoTxt);
            this.groupBox2.Controls.Add(this.ApellidoChk);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 43);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DniTxt);
            this.groupBox3.Controls.Add(this.DniChk);
            this.groupBox3.Location = new System.Drawing.Point(12, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 47);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MatriculaTxt);
            this.groupBox4.Controls.Add(this.MatriculaChk);
            this.groupBox4.Location = new System.Drawing.Point(224, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 41);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LocalidadCbo);
            this.groupBox5.Controls.Add(this.LocalidadChk);
            this.groupBox5.Location = new System.Drawing.Point(224, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 43);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // FrmEnfermeroBusq
            // 
            this.AcceptButton = this.BuscarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(454, 173);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnfermeroBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda del enfermero...";
            this.Activated += new System.EventHandler(this.FrmEnfermeroBusq_Activated);
            this.Deactivate += new System.EventHandler(this.FrmEnfermeroBusq_Deactivate);
            this.Load += new System.EventHandler(this.FrmEnfermeroBusq_Load);
            this.Enter += new System.EventHandler(this.BuscarBtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox CentroChk;
        private System.Windows.Forms.TextBox MatriculaTxt;
        private System.Windows.Forms.CheckBox MatriculaChk;
        private System.Windows.Forms.ComboBox CentroCbo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}