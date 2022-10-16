namespace medicApp.Views
{
    partial class FrmTurnoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnoList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TurnosGrd = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(392, 210);
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
            this.groupBox1.Controls.Add(this.TurnosGrd);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(441, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // TurnosGrd
            // 
            this.TurnosGrd.AllowUserToAddRows = false;
            this.TurnosGrd.AllowUserToDeleteRows = false;
            this.TurnosGrd.AllowUserToResizeColumns = false;
            this.TurnosGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TurnosGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TurnosGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TurnosGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TurnosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.DniCol,
            this.fechaCol,
            this.holaCol,
            this.CentroCol});
            this.TurnosGrd.Location = new System.Drawing.Point(4, 17);
            this.TurnosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TurnosGrd.MultiSelect = false;
            this.TurnosGrd.Name = "TurnosGrd";
            this.TurnosGrd.ReadOnly = true;
            this.TurnosGrd.RowTemplate.Height = 24;
            this.TurnosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TurnosGrd.Size = new System.Drawing.Size(424, 163);
            this.TurnosGrd.TabIndex = 0;
            this.TurnosGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TurnosGrd_ColumnHeaderMouseClick);
            this.TurnosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.EspecialidadesGrd_DataBindingComplete);
            this.TurnosGrd.DoubleClick += new System.EventHandler(this.TurnosGrd_DoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "nro_doc_paciente";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // holaCol
            // 
            this.holaCol.HeaderText = "Hora";
            this.holaCol.Name = "holaCol";
            this.holaCol.ReadOnly = true;
            // 
            // CentroCol
            // 
            this.CentroCol.HeaderText = "Centro";
            this.CentroCol.Name = "CentroCol";
            this.CentroCol.ReadOnly = true;
            // 
            // FrmTurnoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 244);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmTurnoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Tunos...";
            this.Activated += new System.EventHandler(this.FrmTurnoList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmTurnoList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TurnosGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TurnosGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn holaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCol;
    }
}