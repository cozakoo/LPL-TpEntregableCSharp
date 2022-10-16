namespace medicApp.Views
{
    partial class FrmListadoAuditorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoAuditorias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuditoriasGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActividadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AuditoriaCbo = new System.Windows.Forms.ComboBox();
            this.UsuarioChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriasGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuditoriasGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(719, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // AuditoriasGrd
            // 
            this.AuditoriasGrd.AllowUserToAddRows = false;
            this.AuditoriasGrd.AllowUserToDeleteRows = false;
            this.AuditoriasGrd.AllowUserToResizeColumns = false;
            this.AuditoriasGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AuditoriasGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AuditoriasGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuditoriasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuditoriasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.LocalidadCol,
            this.fechaCol,
            this.HoraCol,
            this.ActividadCol});
            this.AuditoriasGrd.Location = new System.Drawing.Point(8, 17);
            this.AuditoriasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.AuditoriasGrd.MultiSelect = false;
            this.AuditoriasGrd.Name = "AuditoriasGrd";
            this.AuditoriasGrd.ReadOnly = true;
            this.AuditoriasGrd.RowTemplate.Height = 24;
            this.AuditoriasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuditoriasGrd.Size = new System.Drawing.Size(696, 260);
            this.AuditoriasGrd.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // LocalidadCol
            // 
            this.LocalidadCol.DataPropertyName = "Localidad";
            this.LocalidadCol.HeaderText = "Usuario";
            this.LocalidadCol.Name = "LocalidadCol";
            this.LocalidadCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            this.fechaCol.Width = 98;
            // 
            // HoraCol
            // 
            this.HoraCol.HeaderText = "Hora ";
            this.HoraCol.Name = "HoraCol";
            this.HoraCol.ReadOnly = true;
            // 
            // ActividadCol
            // 
            this.ActividadCol.HeaderText = "Actividad";
            this.ActividadCol.Name = "ActividadCol";
            this.ActividadCol.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AuditoriaCbo);
            this.groupBox3.Controls.Add(this.UsuarioChk);
            this.groupBox3.Location = new System.Drawing.Point(15, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(227, 41);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // AuditoriaCbo
            // 
            this.AuditoriaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuditoriaCbo.Enabled = false;
            this.AuditoriaCbo.FormattingEnabled = true;
            this.AuditoriaCbo.Location = new System.Drawing.Point(86, 13);
            this.AuditoriaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.AuditoriaCbo.Name = "AuditoriaCbo";
            this.AuditoriaCbo.Size = new System.Drawing.Size(115, 21);
            this.AuditoriaCbo.TabIndex = 2;
            // 
            // UsuarioChk
            // 
            this.UsuarioChk.AutoSize = true;
            this.UsuarioChk.Location = new System.Drawing.Point(10, 15);
            this.UsuarioChk.Margin = new System.Windows.Forms.Padding(2);
            this.UsuarioChk.Name = "UsuarioChk";
            this.UsuarioChk.Size = new System.Drawing.Size(62, 17);
            this.UsuarioChk.TabIndex = 1;
            this.UsuarioChk.Text = "Usuario";
            this.UsuarioChk.UseVisualStyleBackColor = true;
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(639, 20);
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
            // FrmListadoAuditorias
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 360);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoAuditorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditorias";
            this.Activated += new System.EventHandler(this.FrmListadoAuditorias_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoAuditorias_Deactivate);
            this.Load += new System.EventHandler(this.FrmEstadisticaVacunados_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriasGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AuditoriasGrd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox AuditoriaCbo;
        private System.Windows.Forms.CheckBox UsuarioChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActividadCol;
    }
}