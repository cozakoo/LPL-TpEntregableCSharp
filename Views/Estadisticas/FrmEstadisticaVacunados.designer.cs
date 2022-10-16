namespace medicApp.Views
{
    partial class FrmEstadisticaVacunados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticaVacunados));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstadisticaVacunadosGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsciptosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsistioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaVacunadosGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(399, 246);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 5;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstadisticaVacunadosGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(442, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // EstadisticaVacunadosGrd
            // 
            this.EstadisticaVacunadosGrd.AllowUserToAddRows = false;
            this.EstadisticaVacunadosGrd.AllowUserToDeleteRows = false;
            this.EstadisticaVacunadosGrd.AllowUserToResizeColumns = false;
            this.EstadisticaVacunadosGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EstadisticaVacunadosGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EstadisticaVacunadosGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstadisticaVacunadosGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EstadisticaVacunadosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstadisticaVacunadosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.NombreCol,
            this.LocalidadCol,
            this.InsciptosCol,
            this.AsistioCol,
            this.PorcentajeCol});
            this.EstadisticaVacunadosGrd.Location = new System.Drawing.Point(4, 17);
            this.EstadisticaVacunadosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.EstadisticaVacunadosGrd.MultiSelect = false;
            this.EstadisticaVacunadosGrd.Name = "EstadisticaVacunadosGrd";
            this.EstadisticaVacunadosGrd.ReadOnly = true;
            this.EstadisticaVacunadosGrd.RowTemplate.Height = 24;
            this.EstadisticaVacunadosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstadisticaVacunadosGrd.Size = new System.Drawing.Size(434, 145);
            this.EstadisticaVacunadosGrd.TabIndex = 0;
            this.EstadisticaVacunadosGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EstadisticaVacunadosGrd_ColumnHeaderMouseClick);
            this.EstadisticaVacunadosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
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
            // InsciptosCol
            // 
            this.InsciptosCol.HeaderText = "Inscriptos";
            this.InsciptosCol.Name = "InsciptosCol";
            this.InsciptosCol.ReadOnly = true;
            // 
            // AsistioCol
            // 
            this.AsistioCol.HeaderText = "Asistio";
            this.AsistioCol.Name = "AsistioCol";
            this.AsistioCol.ReadOnly = true;
            // 
            // PorcentajeCol
            // 
            this.PorcentajeCol.HeaderText = "Porcentaje de Edad";
            this.PorcentajeCol.Name = "PorcentajeCol";
            this.PorcentajeCol.ReadOnly = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(310, 247);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 4;
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
            this.FiltroBtn.Location = new System.Drawing.Point(377, 17);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 3;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // FrmEstadisticaVacunados
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(460, 281);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticaVacunados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas Tipos de Vacunas";
            this.Activated += new System.EventHandler(this.FrmEstadisticaVacunados_Activated);
            this.Deactivate += new System.EventHandler(this.FrmEstadisticaVacunados_Deactivate);
            this.Load += new System.EventHandler(this.FrmEstadisticaVacunados_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstadisticaVacunadosGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EstadisticaVacunadosGrd;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsciptosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsistioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeCol;
    }
}