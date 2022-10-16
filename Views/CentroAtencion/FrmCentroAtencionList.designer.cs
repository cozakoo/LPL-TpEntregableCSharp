namespace medicApp.Views
{
    partial class FrmCentroAtencionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentroAtencionList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CentroAtencionGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CentroAtencionGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(310, 195);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CentroAtencionGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(353, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // CentroAtencionGrd
            // 
            this.CentroAtencionGrd.AllowUserToAddRows = false;
            this.CentroAtencionGrd.AllowUserToDeleteRows = false;
            this.CentroAtencionGrd.AllowUserToResizeColumns = false;
            this.CentroAtencionGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CentroAtencionGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CentroAtencionGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CentroAtencionGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CentroAtencionGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CentroAtencionGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.NombreCol,
            this.DomicilioCol,
            this.LocalidadCol});
            this.CentroAtencionGrd.Location = new System.Drawing.Point(4, 17);
            this.CentroAtencionGrd.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionGrd.MultiSelect = false;
            this.CentroAtencionGrd.Name = "CentroAtencionGrd";
            this.CentroAtencionGrd.ReadOnly = true;
            this.CentroAtencionGrd.RowTemplate.Height = 24;
            this.CentroAtencionGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CentroAtencionGrd.Size = new System.Drawing.Size(340, 145);
            this.CentroAtencionGrd.TabIndex = 0;
            this.CentroAtencionGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CentroAtencionGrd_ColumnHeaderMouseClick);
            this.CentroAtencionGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.CentroAtencionGrd.DoubleClick += new System.EventHandler(this.CentroAtencionGrd_DoubleClick);
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
            // DomicilioCol
            // 
            this.DomicilioCol.DataPropertyName = "Domicilio";
            this.DomicilioCol.HeaderText = "Domicilio";
            this.DomicilioCol.Name = "DomicilioCol";
            this.DomicilioCol.ReadOnly = true;
            // 
            // LocalidadCol
            // 
            this.LocalidadCol.DataPropertyName = "Localidad";
            this.LocalidadCol.HeaderText = "Localidad";
            this.LocalidadCol.Name = "LocalidadCol";
            this.LocalidadCol.ReadOnly = true;
            // 
            // FrmCentroAtencionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(375, 227);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCentroAtencionList";
            this.Text = "Listado Centro de Atencion";
            this.Activated += new System.EventHandler(this.FrmCentroAtencionList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmCentroAtencionList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CentroAtencionGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CentroAtencionGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
    }
}