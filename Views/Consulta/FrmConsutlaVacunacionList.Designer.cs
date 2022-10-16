namespace medicApp.Views
{
    partial class FrmConsutlaVacunacionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsutlaVacunacionList));
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultaGrid = new System.Windows.Forms.DataGridView();
            this.DniPacienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteNombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacunaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnfermeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistioCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(468, 234);
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
            this.groupBox1.Controls.Add(this.ConsultaGrid);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(974, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // ConsultaGrid
            // 
            this.ConsultaGrid.AllowUserToAddRows = false;
            this.ConsultaGrid.AllowUserToDeleteRows = false;
            this.ConsultaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultaGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniPacienteCol,
            this.PacienteNombreCol,
            this.EdadCol,
            this.VacunaCol,
            this.DosisCol,
            this.FechaCol,
            this.horaCol,
            this.EnfermeroCol,
            this.localidadCol,
            this.CentroCol,
            this.asistioCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultaGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultaGrid.Location = new System.Drawing.Point(11, 23);
            this.ConsultaGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultaGrid.MultiSelect = false;
            this.ConsultaGrid.Name = "ConsultaGrid";
            this.ConsultaGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultaGrid.RowTemplate.Height = 24;
            this.ConsultaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultaGrid.ShowEditingIcon = false;
            this.ConsultaGrid.Size = new System.Drawing.Size(948, 177);
            this.ConsultaGrid.TabIndex = 8;
            this.ConsultaGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConsultaGrid_ColumnHeaderMouseClick);
            this.ConsultaGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ConsultaGrid_DataBindingComplete);
            // 
            // DniPacienteCol
            // 
            this.DniPacienteCol.DataPropertyName = "NroDocPaciente";
            this.DniPacienteCol.HeaderText = "Dni del Paciente";
            this.DniPacienteCol.Name = "DniPacienteCol";
            this.DniPacienteCol.ReadOnly = true;
            // 
            // PacienteNombreCol
            // 
            this.PacienteNombreCol.HeaderText = "Nombre Paciente";
            this.PacienteNombreCol.Name = "PacienteNombreCol";
            this.PacienteNombreCol.ReadOnly = true;
            // 
            // EdadCol
            // 
            this.EdadCol.HeaderText = "Edad del Paciente";
            this.EdadCol.Name = "EdadCol";
            this.EdadCol.ReadOnly = true;
            // 
            // VacunaCol
            // 
            this.VacunaCol.HeaderText = "Vacuna recibida";
            this.VacunaCol.Name = "VacunaCol";
            this.VacunaCol.ReadOnly = true;
            // 
            // DosisCol
            // 
            this.DosisCol.DataPropertyName = "NroDosis";
            this.DosisCol.HeaderText = "Dosis Recibida";
            this.DosisCol.Name = "DosisCol";
            this.DosisCol.ReadOnly = true;
            // 
            // FechaCol
            // 
            this.FechaCol.DataPropertyName = "fecha";
            this.FechaCol.HeaderText = "Fecha";
            this.FechaCol.Name = "FechaCol";
            this.FechaCol.ReadOnly = true;
            // 
            // horaCol
            // 
            this.horaCol.HeaderText = "Hora";
            this.horaCol.Name = "horaCol";
            this.horaCol.ReadOnly = true;
            // 
            // EnfermeroCol
            // 
            this.EnfermeroCol.HeaderText = "Enfermero";
            this.EnfermeroCol.Name = "EnfermeroCol";
            this.EnfermeroCol.ReadOnly = true;
            // 
            // localidadCol
            // 
            this.localidadCol.HeaderText = "Localidad";
            this.localidadCol.Name = "localidadCol";
            this.localidadCol.ReadOnly = true;
            // 
            // CentroCol
            // 
            this.CentroCol.HeaderText = "Centro";
            this.CentroCol.Name = "CentroCol";
            this.CentroCol.ReadOnly = true;
            // 
            // asistioCol
            // 
            this.asistioCol.DataPropertyName = "Asistio";
            this.asistioCol.HeaderText = "Asistio";
            this.asistioCol.Name = "asistioCol";
            this.asistioCol.ReadOnly = true;
            this.asistioCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.asistioCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmConsutlaVacunacionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 268);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmConsutlaVacunacionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vacunacion...";
            this.Activated += new System.EventHandler(this.FrmConsutlaVacunacionList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmConsutlaVacunacionList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView ConsultaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniPacienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteNombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacunaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnfermeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asistioCol;
    }
}