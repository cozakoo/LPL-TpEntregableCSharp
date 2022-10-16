namespace medicApp.Views
{
    partial class FrmListadoVacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoVacuna));
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.VacunasGrd = new System.Windows.Forms.DataGridView();
            this.CodCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVacunaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVacunatxt = new System.Windows.Forms.ComboBox();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.LoteTxt = new System.Windows.Forms.TextBox();
            this.TipoVacunaChk = new System.Windows.Forms.CheckBox();
            this.CantidadChk = new System.Windows.Forms.CheckBox();
            this.LoteChk = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(295, 38);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 7;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(316, 262);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 8;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // VacunasGrd
            // 
            this.VacunasGrd.AllowUserToAddRows = false;
            this.VacunasGrd.AllowUserToDeleteRows = false;
            this.VacunasGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VacunasGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VacunasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VacunasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCol,
            this.LoteCol,
            this.fechaCol,
            this.TipoVacunaCol,
            this.cantidadCol});
            this.VacunasGrd.Location = new System.Drawing.Point(12, 112);
            this.VacunasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.VacunasGrd.MultiSelect = false;
            this.VacunasGrd.Name = "VacunasGrd";
            this.VacunasGrd.ReadOnly = true;
            this.VacunasGrd.RowTemplate.Height = 24;
            this.VacunasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VacunasGrd.ShowEditingIcon = false;
            this.VacunasGrd.Size = new System.Drawing.Size(389, 145);
            this.VacunasGrd.TabIndex = 0;
            this.VacunasGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.VacunasGrd_ColumnHeaderMouseClick);
            this.VacunasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.VacunasGrd_DataBindingComplete);
            this.VacunasGrd.DoubleClick += new System.EventHandler(this.VacunasGrd_DoubleClick);
            // 
            // CodCol
            // 
            this.CodCol.DataPropertyName = "Id";
            this.CodCol.HeaderText = "Codigo";
            this.CodCol.Name = "CodCol";
            this.CodCol.ReadOnly = true;
            // 
            // LoteCol
            // 
            this.LoteCol.DataPropertyName = "Lote";
            this.LoteCol.HeaderText = "Lote";
            this.LoteCol.Name = "LoteCol";
            this.LoteCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "FechaVenc";
            this.fechaCol.HeaderText = "Fecha vencimiento";
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // TipoVacunaCol
            // 
            this.TipoVacunaCol.HeaderText = "Tipo vacuna";
            this.TipoVacunaCol.Name = "TipoVacunaCol";
            this.TipoVacunaCol.ReadOnly = true;
            // 
            // cantidadCol
            // 
            this.cantidadCol.DataPropertyName = "cantidad";
            this.cantidadCol.HeaderText = "cantidad";
            this.cantidadCol.Name = "cantidadCol";
            this.cantidadCol.ReadOnly = true;
            // 
            // TipoVacunatxt
            // 
            this.TipoVacunatxt.DisplayMember = "Nombre";
            this.TipoVacunatxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoVacunatxt.Enabled = false;
            this.TipoVacunatxt.FormattingEnabled = true;
            this.TipoVacunatxt.Location = new System.Drawing.Point(97, 15);
            this.TipoVacunatxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoVacunatxt.Name = "TipoVacunatxt";
            this.TipoVacunatxt.Size = new System.Drawing.Size(138, 21);
            this.TipoVacunatxt.TabIndex = 2;
            this.TipoVacunatxt.Tag = "";
            this.TipoVacunatxt.ValueMember = "Id";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Enabled = false;
            this.CantidadTxt.Location = new System.Drawing.Point(83, 11);
            this.CantidadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(30, 20);
            this.CantidadTxt.TabIndex = 4;
            this.CantidadTxt.Tag = "";
            // 
            // LoteTxt
            // 
            this.LoteTxt.Enabled = false;
            this.LoteTxt.Location = new System.Drawing.Point(75, 11);
            this.LoteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LoteTxt.Name = "LoteTxt";
            this.LoteTxt.Size = new System.Drawing.Size(30, 20);
            this.LoteTxt.TabIndex = 6;
            this.LoteTxt.Tag = "";
            // 
            // TipoVacunaChk
            // 
            this.TipoVacunaChk.AutoSize = true;
            this.TipoVacunaChk.Location = new System.Drawing.Point(7, 16);
            this.TipoVacunaChk.Name = "TipoVacunaChk";
            this.TipoVacunaChk.Size = new System.Drawing.Size(86, 17);
            this.TipoVacunaChk.TabIndex = 1;
            this.TipoVacunaChk.Text = "Tipo vacuna";
            this.TipoVacunaChk.UseVisualStyleBackColor = true;
            this.TipoVacunaChk.CheckedChanged += new System.EventHandler(this.tVacunaChk_CheckedChanged);
            // 
            // CantidadChk
            // 
            this.CantidadChk.AutoSize = true;
            this.CantidadChk.Location = new System.Drawing.Point(10, 13);
            this.CantidadChk.Name = "CantidadChk";
            this.CantidadChk.Size = new System.Drawing.Size(68, 17);
            this.CantidadChk.TabIndex = 3;
            this.CantidadChk.Tag = "";
            this.CantidadChk.Text = "Cantidad";
            this.CantidadChk.UseVisualStyleBackColor = true;
            this.CantidadChk.CheckedChanged += new System.EventHandler(this.CantidadChk_CheckedChanged);
            // 
            // LoteChk
            // 
            this.LoteChk.AutoSize = true;
            this.LoteChk.Location = new System.Drawing.Point(10, 13);
            this.LoteChk.Name = "LoteChk";
            this.LoteChk.Size = new System.Drawing.Size(47, 17);
            this.LoteChk.TabIndex = 5;
            this.LoteChk.Text = "Lote";
            this.LoteChk.UseVisualStyleBackColor = true;
            this.LoteChk.CheckedChanged += new System.EventHandler(this.LoteChk_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoVacunaChk);
            this.groupBox1.Controls.Add(this.TipoVacunatxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 44);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CantidadChk);
            this.groupBox2.Controls.Add(this.CantidadTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 39);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoteChk);
            this.groupBox3.Controls.Add(this.LoteTxt);
            this.groupBox3.Location = new System.Drawing.Point(142, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 39);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // FrmListadoVacuna
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 297);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.VacunasGrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoVacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Vacunas";
            this.Activated += new System.EventHandler(this.FrmListadoVacuna_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoVacuna_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoVacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VacunasGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridView VacunasGrd;
        private System.Windows.Forms.ComboBox TipoVacunatxt;
        private System.Windows.Forms.TextBox CantidadTxt;
        private System.Windows.Forms.TextBox LoteTxt;
        private System.Windows.Forms.CheckBox TipoVacunaChk;
        private System.Windows.Forms.CheckBox CantidadChk;
        private System.Windows.Forms.CheckBox LoteChk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVacunaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCol;
    }
}