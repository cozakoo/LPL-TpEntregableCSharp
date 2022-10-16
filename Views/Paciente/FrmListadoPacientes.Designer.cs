namespace medicApp.Views
{
    partial class FrmListadoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPacientes));
            this.PacientesGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeRiesgoCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VacunadoCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.VacunadoChk = new System.Windows.Forms.CheckBox();
            this.DeRiesgoChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PacientesGrd
            // 
            this.PacientesGrd.AllowUserToAddRows = false;
            this.PacientesGrd.AllowUserToDeleteRows = false;
            this.PacientesGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PacientesGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PacientesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacientesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.ApellidoCol,
            this.NombresCol,
            this.LocCol,
            this.DeRiesgoCol,
            this.VacunadoCol});
            this.PacientesGrd.Location = new System.Drawing.Point(13, 109);
            this.PacientesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.PacientesGrd.MultiSelect = false;
            this.PacientesGrd.Name = "PacientesGrd";
            this.PacientesGrd.ReadOnly = true;
            this.PacientesGrd.RowTemplate.Height = 24;
            this.PacientesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PacientesGrd.ShowEditingIcon = false;
            this.PacientesGrd.Size = new System.Drawing.Size(558, 182);
            this.PacientesGrd.TabIndex = 0;
            this.PacientesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PacientesGrd_ColumnHeaderMouseClick);
            this.PacientesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.PacientesGrd_DataBindingComplete);
            this.PacientesGrd.DoubleClick += new System.EventHandler(this.PacientesGrd_DoubleClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
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
            // LocCol
            // 
            this.LocCol.HeaderText = "Localidad";
            this.LocCol.Name = "LocCol";
            this.LocCol.ReadOnly = true;
            // 
            // DeRiesgoCol
            // 
            this.DeRiesgoCol.DataPropertyName = "DeRiesgo";
            this.DeRiesgoCol.HeaderText = "De Riesgo";
            this.DeRiesgoCol.Name = "DeRiesgoCol";
            this.DeRiesgoCol.ReadOnly = true;
            this.DeRiesgoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeRiesgoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VacunadoCol
            // 
            this.VacunadoCol.DataPropertyName = "Vacunado";
            this.VacunadoCol.HeaderText = "Vacunado";
            this.VacunadoCol.Name = "VacunadoCol";
            this.VacunadoCol.ReadOnly = true;
            this.VacunadoCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VacunadoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoChk);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(227, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(69, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(146, 20);
            this.ApellidoTxt.TabIndex = 2;
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(4, 17);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 1;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(495, 14);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 7;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalidadCbo);
            this.groupBox3.Controls.Add(this.LocalidadChk);
            this.groupBox3.Location = new System.Drawing.Point(244, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(225, 44);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Id";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(90, 15);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(115, 21);
            this.LocalidadCbo.TabIndex = 5;
            this.LocalidadCbo.ValueMember = "Nombre";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(10, 15);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 4;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // VacunadoChk
            // 
            this.VacunadoChk.AutoSize = true;
            this.VacunadoChk.Location = new System.Drawing.Point(14, 15);
            this.VacunadoChk.Name = "VacunadoChk";
            this.VacunadoChk.Size = new System.Drawing.Size(75, 17);
            this.VacunadoChk.TabIndex = 6;
            this.VacunadoChk.Text = "Vacunado";
            this.VacunadoChk.UseVisualStyleBackColor = true;
            // 
            // DeRiesgoChk
            // 
            this.DeRiesgoChk.AutoSize = true;
            this.DeRiesgoChk.Location = new System.Drawing.Point(6, 15);
            this.DeRiesgoChk.Name = "DeRiesgoChk";
            this.DeRiesgoChk.Size = new System.Drawing.Size(71, 17);
            this.DeRiesgoChk.TabIndex = 3;
            this.DeRiesgoChk.Text = "De riesgo";
            this.DeRiesgoChk.UseVisualStyleBackColor = true;
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(487, 296);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 8;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeRiesgoChk);
            this.groupBox2.Location = new System.Drawing.Point(13, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VacunadoChk);
            this.groupBox4.Location = new System.Drawing.Point(244, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 42);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // FrmListadoPacientes
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PacientesGrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Pacientes";
            this.Activated += new System.EventHandler(this.FrmListadoPacientes_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoPacientes_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacientesGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PacientesGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.CheckBox VacunadoChk;
        private System.Windows.Forms.CheckBox DeRiesgoChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeRiesgoCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VacunadoCol;
    }
}