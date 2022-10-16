namespace medicApp.Views
{
    partial class FrmEnfermeroList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnfermeroList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnfermerosGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatriculaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnfermerosGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(568, 280);
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
            this.groupBox1.Controls.Add(this.EnfermerosGrd);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(617, 266);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // EnfermerosGrd
            // 
            this.EnfermerosGrd.AllowUserToAddRows = false;
            this.EnfermerosGrd.AllowUserToDeleteRows = false;
            this.EnfermerosGrd.AllowUserToResizeColumns = false;
            this.EnfermerosGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnfermerosGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EnfermerosGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EnfermerosGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EnfermerosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnfermerosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ApellidoCol,
            this.NombresCol,
            this.DniCol,
            this.DomicilioCol,
            this.LocalidadCol,
            this.MatriculaCol,
            this.CentroCol});
            this.EnfermerosGrd.Location = new System.Drawing.Point(4, 17);
            this.EnfermerosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.EnfermerosGrd.MultiSelect = false;
            this.EnfermerosGrd.Name = "EnfermerosGrd";
            this.EnfermerosGrd.ReadOnly = true;
            this.EnfermerosGrd.RowTemplate.Height = 24;
            this.EnfermerosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnfermerosGrd.Size = new System.Drawing.Size(603, 237);
            this.EnfermerosGrd.TabIndex = 0;
            this.EnfermerosGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EnfermerosGrd_ColumnHeaderMouseClick);
            this.EnfermerosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.EnfermerosGrd.DoubleClick += new System.EventHandler(this.EnfermerosGrd_DoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
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
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
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
            // MatriculaCol
            // 
            this.MatriculaCol.DataPropertyName = "Matricula";
            this.MatriculaCol.HeaderText = "Matricula";
            this.MatriculaCol.Name = "MatriculaCol";
            this.MatriculaCol.ReadOnly = true;
            // 
            // CentroCol
            // 
            this.CentroCol.DataPropertyName = "CentroAtencion";
            this.CentroCol.HeaderText = "Centro";
            this.CentroCol.Name = "CentroCol";
            this.CentroCol.ReadOnly = true;
            // 
            // FrmEnfermeroList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 314);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmEnfermeroList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Enfermeros...";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnfermerosGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EnfermerosGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCol;
    }
}