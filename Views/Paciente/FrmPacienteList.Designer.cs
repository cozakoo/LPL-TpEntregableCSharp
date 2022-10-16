namespace medicApp.Views
{
    partial class FrmPacienteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacienteList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PacientesGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(452, 203);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PacientesGrd);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(509, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // PacientesGrd
            // 
            this.PacientesGrd.AllowUserToAddRows = false;
            this.PacientesGrd.AllowUserToDeleteRows = false;
            this.PacientesGrd.AllowUserToResizeColumns = false;
            this.PacientesGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PacientesGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PacientesGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PacientesGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PacientesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacientesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ApellidoCol,
            this.NombresCol,
            this.DniCol,
            this.DomicilioCol,
            this.LocCol});
            this.PacientesGrd.Location = new System.Drawing.Point(4, 17);
            this.PacientesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PacientesGrd.MultiSelect = false;
            this.PacientesGrd.Name = "PacientesGrd";
            this.PacientesGrd.ReadOnly = true;
            this.PacientesGrd.RowTemplate.Height = 24;
            this.PacientesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PacientesGrd.Size = new System.Drawing.Size(497, 165);
            this.PacientesGrd.TabIndex = 0;
            this.PacientesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PacientesGrd_ColumnHeaderMouseClick);
            this.PacientesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.PacientesGrd.DoubleClick += new System.EventHandler(this.PacientesGrd_DoubleClick);
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
            // LocCol
            // 
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // FrmPacienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 234);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPacienteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Pacientes...";
            this.Activated += new System.EventHandler(this.FrmPacienteList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmPacienteList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PacientesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
    }
}