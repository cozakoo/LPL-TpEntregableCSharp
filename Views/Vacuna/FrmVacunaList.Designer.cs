namespace medicApp.Views
{
    partial class FrmVacunaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacunaList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VacunasGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVacunaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacunasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(457, 221);
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
            this.groupBox1.Controls.Add(this.VacunasGrd);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(506, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // VacunasGrd
            // 
            this.VacunasGrd.AllowUserToAddRows = false;
            this.VacunasGrd.AllowUserToDeleteRows = false;
            this.VacunasGrd.AllowUserToResizeColumns = false;
            this.VacunasGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VacunasGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VacunasGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VacunasGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VacunasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VacunasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.LoteCol,
            this.fechaCol,
            this.TipoVacunaCol,
            this.cantidadCol});
            this.VacunasGrd.Location = new System.Drawing.Point(4, 17);
            this.VacunasGrd.Margin = new System.Windows.Forms.Padding(2);
            this.VacunasGrd.MultiSelect = false;
            this.VacunasGrd.Name = "VacunasGrd";
            this.VacunasGrd.ReadOnly = true;
            this.VacunasGrd.RowTemplate.Height = 24;
            this.VacunasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VacunasGrd.Size = new System.Drawing.Size(495, 176);
            this.VacunasGrd.TabIndex = 0;
            this.VacunasGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.VacunasGrd_ColumnHeaderMouseClick);
            this.VacunasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.VacunasGrd.DoubleClick += new System.EventHandler(this.VacunasGrd_DoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
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
            this.TipoVacunaCol.HeaderText = "Tipo de vacuna";
            this.TipoVacunaCol.Name = "TipoVacunaCol";
            this.TipoVacunaCol.ReadOnly = true;
            // 
            // cantidadCol
            // 
            this.cantidadCol.DataPropertyName = "Cantidad";
            this.cantidadCol.HeaderText = "Cantidad";
            this.cantidadCol.Name = "cantidadCol";
            this.cantidadCol.ReadOnly = true;
            // 
            // FrmVacunaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmVacunaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Vacunas...";
            this.Activated += new System.EventHandler(this.FrmVacunaList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmVacunaList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VacunasGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView VacunasGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVacunaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCol;
    }
}