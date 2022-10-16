namespace medicApp.Views
{
    partial class FrmTipoVacunaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoVacunaList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoVacunaGrd = new System.Windows.Forms.DataGridView();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoVacunaGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(248, 218);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 11;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoVacunaGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(291, 203);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // TipoVacunaGrd
            // 
            this.TipoVacunaGrd.AllowUserToAddRows = false;
            this.TipoVacunaGrd.AllowUserToDeleteRows = false;
            this.TipoVacunaGrd.AllowUserToResizeColumns = false;
            this.TipoVacunaGrd.AllowUserToResizeRows = false;
            this.TipoVacunaGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TipoVacunaGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TipoVacunaGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoVacunaGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCol,
            this.DosisCol});
            this.TipoVacunaGrd.Location = new System.Drawing.Point(5, 18);
            this.TipoVacunaGrd.MultiSelect = false;
            this.TipoVacunaGrd.Name = "TipoVacunaGrd";
            this.TipoVacunaGrd.ReadOnly = true;
            this.TipoVacunaGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TipoVacunaGrd.Size = new System.Drawing.Size(275, 180);
            this.TipoVacunaGrd.TabIndex = 0;
            this.TipoVacunaGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TipoVacunaGrd_ColumnHeaderMouseClick);
            this.TipoVacunaGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TipoVacunaGrd_DataBindingComplete);
            this.TipoVacunaGrd.DoubleClick += new System.EventHandler(this.TipoVacunaGrd_DoubleClick);
            // 
            // NombreCol
            // 
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            // 
            // DosisCol
            // 
            this.DosisCol.HeaderText = "Cantidad de Dosis";
            this.DosisCol.Name = "DosisCol";
            this.DosisCol.ReadOnly = true;
            // 
            // FrmTipoVacunaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 253);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTipoVacunaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Tipo de Vacuna";
            this.Activated += new System.EventHandler(this.FrmTipoVacunaList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmTipoVacunaList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TipoVacunaGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridView TipoVacunaGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosisCol;
    }
}