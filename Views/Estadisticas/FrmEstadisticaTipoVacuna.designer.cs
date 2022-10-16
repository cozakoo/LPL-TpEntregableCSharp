namespace medicApp.Views
{
    partial class FrmEstadisticaTipoVacuna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticaTipoVacuna));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstadisticaTipoVacunaGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModernaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PfizerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SputnikCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.CentroAtencionChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaTipoVacunaGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(526, 246);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstadisticaTipoVacunaGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(569, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // EstadisticaTipoVacunaGrd
            // 
            this.EstadisticaTipoVacunaGrd.AllowUserToAddRows = false;
            this.EstadisticaTipoVacunaGrd.AllowUserToDeleteRows = false;
            this.EstadisticaTipoVacunaGrd.AllowUserToResizeColumns = false;
            this.EstadisticaTipoVacunaGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EstadisticaTipoVacunaGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EstadisticaTipoVacunaGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstadisticaTipoVacunaGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EstadisticaTipoVacunaGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadisticaTipoVacunaGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.NombreCol,
            this.LocalidadCol,
            this.ModernaCol,
            this.PfizerCol,
            this.SputnikCol});
            this.EstadisticaTipoVacunaGrd.Location = new System.Drawing.Point(4, 17);
            this.EstadisticaTipoVacunaGrd.Margin = new System.Windows.Forms.Padding(2);
            this.EstadisticaTipoVacunaGrd.MultiSelect = false;
            this.EstadisticaTipoVacunaGrd.Name = "EstadisticaTipoVacunaGrd";
            this.EstadisticaTipoVacunaGrd.ReadOnly = true;
            this.EstadisticaTipoVacunaGrd.RowTemplate.Height = 24;
            this.EstadisticaTipoVacunaGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstadisticaTipoVacunaGrd.Size = new System.Drawing.Size(561, 151);
            this.EstadisticaTipoVacunaGrd.TabIndex = 0;
            this.EstadisticaTipoVacunaGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EstadisticaTipoVacunaGrd_ColumnHeaderMouseClick);
            this.EstadisticaTipoVacunaGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombre";
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            // 
            // LocalidadCol
            // 
            this.LocalidadCol.DataPropertyName = "Localidad";
            this.LocalidadCol.HeaderText = "Localidad";
            this.LocalidadCol.Name = "LocalidadCol";
            this.LocalidadCol.ReadOnly = true;
            // 
            // ModernaCol
            // 
            this.ModernaCol.HeaderText = "Moderna";
            this.ModernaCol.Name = "ModernaCol";
            this.ModernaCol.ReadOnly = true;
            // 
            // PfizerCol
            // 
            this.PfizerCol.HeaderText = "Pfizer-BiOtech";
            this.PfizerCol.Name = "PfizerCol";
            this.PfizerCol.ReadOnly = true;
            // 
            // SputnikCol
            // 
            this.SputnikCol.HeaderText = "Sputnik V";
            this.SputnikCol.Name = "SputnikCol";
            this.SputnikCol.ReadOnly = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(437, 247);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 6;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalidadCbo);
            this.groupBox3.Controls.Add(this.LocalidadChk);
            this.groupBox3.Location = new System.Drawing.Point(15, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(227, 41);
            this.groupBox3.TabIndex = 13;
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
            this.LocalidadCbo.TabIndex = 2;
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(10, 15);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 1;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(504, 21);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 5;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CentroAtencionCbo);
            this.groupBox2.Controls.Add(this.CentroAtencionChk);
            this.groupBox2.Location = new System.Drawing.Point(246, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 42);
            this.groupBox2.TabIndex = 15;
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
            this.CentroAtencionCbo.TabIndex = 4;
            // 
            // CentroAtencionChk
            // 
            this.CentroAtencionChk.AutoSize = true;
            this.CentroAtencionChk.Location = new System.Drawing.Point(10, 14);
            this.CentroAtencionChk.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionChk.Name = "CentroAtencionChk";
            this.CentroAtencionChk.Size = new System.Drawing.Size(99, 17);
            this.CentroAtencionChk.TabIndex = 3;
            this.CentroAtencionChk.Text = "CentroAtencion";
            this.CentroAtencionChk.UseVisualStyleBackColor = true;
            this.CentroAtencionChk.CheckedChanged += new System.EventHandler(this.CentroAtencionChk_CheckedChanged);
            // 
            // FrmEstadisticaTipoVacuna
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(595, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticaTipoVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Vacunados";
            this.Activated += new System.EventHandler(this.FrmEstadisticaTipoVacuna_Activated);
            this.Deactivate += new System.EventHandler(this.FrmEstadisticaTipoVacuna_Deactivate);
            this.Load += new System.EventHandler(this.FrmEstadisticaVacunados_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaTipoVacunaGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EstadisticaTipoVacunaGrd;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CentroAtencionCbo;
        private System.Windows.Forms.CheckBox CentroAtencionChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModernaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PfizerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SputnikCol;
    }
}