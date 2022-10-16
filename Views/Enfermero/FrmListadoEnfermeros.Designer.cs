namespace medicApp.Views
{
    partial class FrmListadoEnfermeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoEnfermeros));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.EnfermeroGrd = new System.Windows.Forms.DataGridView();
            this.MatriculaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.CentroAtencionChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermeroGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalidadCbo);
            this.groupBox3.Controls.Add(this.LocalidadChk);
            this.groupBox3.Location = new System.Drawing.Point(13, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(227, 41);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(86, 13);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(115, 21);
            this.LocalidadCbo.TabIndex = 4;
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(10, 15);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 3;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(529, 17);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 7;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(86, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(115, 20);
            this.ApellidoTxt.TabIndex = 2;
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(4, 17);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 1;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // EnfermeroGrd
            // 
            this.EnfermeroGrd.AllowUserToAddRows = false;
            this.EnfermeroGrd.AllowUserToDeleteRows = false;
            this.EnfermeroGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EnfermeroGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EnfermeroGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnfermeroGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaCol,
            this.DniCol,
            this.ApellidoCol,
            this.NombresCol,
            this.LocCol,
            this.CenCol});
            this.EnfermeroGrd.Location = new System.Drawing.Point(13, 112);
            this.EnfermeroGrd.Margin = new System.Windows.Forms.Padding(2);
            this.EnfermeroGrd.MultiSelect = false;
            this.EnfermeroGrd.Name = "EnfermeroGrd";
            this.EnfermeroGrd.ReadOnly = true;
            this.EnfermeroGrd.RowTemplate.Height = 24;
            this.EnfermeroGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnfermeroGrd.Size = new System.Drawing.Size(592, 172);
            this.EnfermeroGrd.TabIndex = 5;
            this.EnfermeroGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EnfermeroGrd_ColumnHeaderMouseClick);
            this.EnfermeroGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EnfermeroGrd_DataBindingComplete);
            this.EnfermeroGrd.DoubleClick += new System.EventHandler(this.EnfermeroGrd_DoubleClick);
            // 
            // MatriculaCol
            // 
            this.MatriculaCol.DataPropertyName = "Matricula";
            this.MatriculaCol.HeaderText = "Matricula";
            this.MatriculaCol.Name = "MatriculaCol";
            this.MatriculaCol.ReadOnly = true;
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            // 
            // NombresCol
            // 
            this.NombresCol.DataPropertyName = "Nombres";
            this.NombresCol.HeaderText = "Nombres";
            this.NombresCol.Name = "NombresCol";
            this.NombresCol.ReadOnly = true;
            // 
            // LocCol
            // 
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // CenCol
            // 
            this.CenCol.HeaderText = "Centro atencion";
            this.CenCol.Name = "CenCol";
            this.CenCol.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CentroAtencionCbo);
            this.groupBox2.Controls.Add(this.CentroAtencionChk);
            this.groupBox2.Location = new System.Drawing.Point(254, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // CentroAtencionCbo
            // 
            this.CentroAtencionCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroAtencionCbo.Enabled = false;
            this.CentroAtencionCbo.FormattingEnabled = true;
            this.CentroAtencionCbo.Location = new System.Drawing.Point(109, 12);
            this.CentroAtencionCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionCbo.Name = "CentroAtencionCbo";
            this.CentroAtencionCbo.Size = new System.Drawing.Size(115, 21);
            this.CentroAtencionCbo.TabIndex = 6;
            // 
            // CentroAtencionChk
            // 
            this.CentroAtencionChk.AutoSize = true;
            this.CentroAtencionChk.Location = new System.Drawing.Point(10, 14);
            this.CentroAtencionChk.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionChk.Name = "CentroAtencionChk";
            this.CentroAtencionChk.Size = new System.Drawing.Size(99, 17);
            this.CentroAtencionChk.TabIndex = 5;
            this.CentroAtencionChk.Text = "CentroAtencion";
            this.CentroAtencionChk.UseVisualStyleBackColor = true;
            this.CentroAtencionChk.CheckedChanged += new System.EventHandler(this.EspecialidadChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(521, 302);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 8;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // FrmListadoEnfermeros
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EnfermeroGrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListadoEnfermeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Enfermeros";
            this.Activated += new System.EventHandler(this.FrmListadoEnfermeros_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoEnfermeros_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoEnfermeros_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermeroGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.DataGridView EnfermeroGrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CentroAtencionCbo;
        private System.Windows.Forms.CheckBox CentroAtencionChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenCol;
    }
}