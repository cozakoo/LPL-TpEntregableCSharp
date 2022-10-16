namespace medicApp.Views
{
    partial class FrmListadoTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoTurnos));
            this.TurnosGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteNombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacunaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnfermeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistioCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadChk = new System.Windows.Forms.CheckBox();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.NroDocPacienteTxt = new System.Windows.Forms.TextBox();
            this.NroDocPacienteChk = new System.Windows.Forms.CheckBox();
            this.EnfermeroChk = new System.Windows.Forms.CheckBox();
            this.DocEnfermeroTxt = new System.Windows.Forms.ComboBox();
            this.CentroChk = new System.Windows.Forms.CheckBox();
            this.CentroAtencionCbo = new System.Windows.Forms.ComboBox();
            this.FechaDesdeChk = new System.Windows.Forms.CheckBox();
            this.FechaHastaChk = new System.Windows.Forms.CheckBox();
            this.FechaTurnoDesdeDtp = new System.Windows.Forms.DateTimePicker();
            this.FechaTurnoHastaDtp = new System.Windows.Forms.DateTimePicker();
            this.HoraHastaChk = new System.Windows.Forms.CheckBox();
            this.HoraDesdeChk = new System.Windows.Forms.CheckBox();
            this.horaslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinutoDesdetxt = new System.Windows.Forms.NumericUpDown();
            this.HoraDesdetxt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinutoHastatxt = new System.Windows.Forms.NumericUpDown();
            this.HoraHastatxt = new System.Windows.Forms.NumericUpDown();
            this.NroDosisChk = new System.Windows.Forms.CheckBox();
            this.Dosistxt = new System.Windows.Forms.NumericUpDown();
            this.VacunaChk = new System.Windows.Forms.CheckBox();
            this.VacunaCbo = new System.Windows.Forms.ComboBox();
            this.asistioChk = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TurnosGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutoDesdetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraDesdetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutoHastatxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraHastatxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dosistxt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurnosGrd
            // 
            this.TurnosGrd.AllowUserToAddRows = false;
            this.TurnosGrd.AllowUserToDeleteRows = false;
            this.TurnosGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TurnosGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TurnosGrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TurnosGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnosGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.PacienteNombreCol,
            this.EdadCol,
            this.VacunaCol,
            this.DosisCol,
            this.fechaCol,
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
            this.TurnosGrd.DefaultCellStyle = dataGridViewCellStyle2;
            this.TurnosGrd.Location = new System.Drawing.Point(8, 140);
            this.TurnosGrd.Margin = new System.Windows.Forms.Padding(2);
            this.TurnosGrd.MultiSelect = false;
            this.TurnosGrd.Name = "TurnosGrd";
            this.TurnosGrd.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TurnosGrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TurnosGrd.RowTemplate.Height = 24;
            this.TurnosGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TurnosGrd.ShowEditingIcon = false;
            this.TurnosGrd.Size = new System.Drawing.Size(802, 177);
            this.TurnosGrd.TabIndex = 0;
            this.TurnosGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TurnosGrd_ColumnHeaderMouseClick);
            this.TurnosGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TurnosGrd_DataBindingComplete);
            this.TurnosGrd.DoubleClick += new System.EventHandler(this.TurnosGrd_DoubleClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocPaciente";
            this.DniCol.HeaderText = "Dni del Paciente";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
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
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // horaCol
            // 
            this.horaCol.HeaderText = "Hora";
            this.horaCol.Name = "horaCol";
            this.horaCol.ReadOnly = true;
            // 
            // EnfermeroCol
            // 
            this.EnfermeroCol.DataPropertyName = "NroDocEnfermero";
            this.EnfermeroCol.HeaderText = "Dni Enfermero";
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
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(666, 88);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 24;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LocalidadCbo);
            this.groupBox3.Controls.Add(this.LocalidadChk);
            this.groupBox3.Location = new System.Drawing.Point(5, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(193, 40);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Id";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.Enabled = false;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(101, 12);
            this.LocalidadCbo.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(83, 21);
            this.LocalidadCbo.TabIndex = 4;
            this.LocalidadCbo.ValueMember = "Nombre";
            // 
            // LocalidadChk
            // 
            this.LocalidadChk.AutoSize = true;
            this.LocalidadChk.Location = new System.Drawing.Point(6, 14);
            this.LocalidadChk.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadChk.Name = "LocalidadChk";
            this.LocalidadChk.Size = new System.Drawing.Size(72, 17);
            this.LocalidadChk.TabIndex = 3;
            this.LocalidadChk.Text = "Localidad";
            this.LocalidadChk.UseVisualStyleBackColor = true;
            this.LocalidadChk.CheckedChanged += new System.EventHandler(this.LocalidadChk_CheckedChanged);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(726, 339);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 25;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // NroDocPacienteTxt
            // 
            this.NroDocPacienteTxt.Enabled = false;
            this.NroDocPacienteTxt.Location = new System.Drawing.Point(101, 12);
            this.NroDocPacienteTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NroDocPacienteTxt.Name = "NroDocPacienteTxt";
            this.NroDocPacienteTxt.Size = new System.Drawing.Size(83, 20);
            this.NroDocPacienteTxt.TabIndex = 2;
            this.NroDocPacienteTxt.Tag = "NroDocPaciente";
            // 
            // NroDocPacienteChk
            // 
            this.NroDocPacienteChk.AutoSize = true;
            this.NroDocPacienteChk.Location = new System.Drawing.Point(6, 14);
            this.NroDocPacienteChk.Margin = new System.Windows.Forms.Padding(2);
            this.NroDocPacienteChk.Name = "NroDocPacienteChk";
            this.NroDocPacienteChk.Size = new System.Drawing.Size(91, 17);
            this.NroDocPacienteChk.TabIndex = 1;
            this.NroDocPacienteChk.Text = "Doc Paciente";
            this.NroDocPacienteChk.UseVisualStyleBackColor = true;
            this.NroDocPacienteChk.CheckedChanged += new System.EventHandler(this.NroDocPacienteChk_CheckedChanged);
            // 
            // EnfermeroChk
            // 
            this.EnfermeroChk.AutoSize = true;
            this.EnfermeroChk.Location = new System.Drawing.Point(5, 12);
            this.EnfermeroChk.Margin = new System.Windows.Forms.Padding(2);
            this.EnfermeroChk.Name = "EnfermeroChk";
            this.EnfermeroChk.Size = new System.Drawing.Size(74, 17);
            this.EnfermeroChk.TabIndex = 7;
            this.EnfermeroChk.Text = "Enfermero";
            this.EnfermeroChk.UseVisualStyleBackColor = true;
            this.EnfermeroChk.CheckedChanged += new System.EventHandler(this.EnfermeroChk_CheckedChanged);
            // 
            // DocEnfermeroTxt
            // 
            this.DocEnfermeroTxt.DisplayMember = "Nombre";
            this.DocEnfermeroTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocEnfermeroTxt.Enabled = false;
            this.DocEnfermeroTxt.FormattingEnabled = true;
            this.DocEnfermeroTxt.Location = new System.Drawing.Point(80, 11);
            this.DocEnfermeroTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DocEnfermeroTxt.Name = "DocEnfermeroTxt";
            this.DocEnfermeroTxt.Size = new System.Drawing.Size(93, 21);
            this.DocEnfermeroTxt.TabIndex = 8;
            this.DocEnfermeroTxt.Tag = "NroDocEnfermero";
            this.DocEnfermeroTxt.ValueMember = "nombres";
            // 
            // CentroChk
            // 
            this.CentroChk.AutoSize = true;
            this.CentroChk.Location = new System.Drawing.Point(5, 14);
            this.CentroChk.Margin = new System.Windows.Forms.Padding(2);
            this.CentroChk.Name = "CentroChk";
            this.CentroChk.Size = new System.Drawing.Size(57, 17);
            this.CentroChk.TabIndex = 9;
            this.CentroChk.Text = "Centro";
            this.CentroChk.UseVisualStyleBackColor = true;
            this.CentroChk.CheckedChanged += new System.EventHandler(this.CentroChk_CheckedChanged);
            // 
            // CentroAtencionCbo
            // 
            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CentroAtencionCbo.Enabled = false;
            this.CentroAtencionCbo.FormattingEnabled = true;
            this.CentroAtencionCbo.Location = new System.Drawing.Point(80, 9);
            this.CentroAtencionCbo.Margin = new System.Windows.Forms.Padding(2);
            this.CentroAtencionCbo.Name = "CentroAtencionCbo";
            this.CentroAtencionCbo.Size = new System.Drawing.Size(93, 21);
            this.CentroAtencionCbo.TabIndex = 10;
            this.CentroAtencionCbo.Tag = "CodCentroAtencion";
            this.CentroAtencionCbo.ValueMember = "Id";
            // 
            // FechaDesdeChk
            // 
            this.FechaDesdeChk.AutoSize = true;
            this.FechaDesdeChk.Location = new System.Drawing.Point(6, 14);
            this.FechaDesdeChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaDesdeChk.Name = "FechaDesdeChk";
            this.FechaDesdeChk.Size = new System.Drawing.Size(88, 17);
            this.FechaDesdeChk.TabIndex = 13;
            this.FechaDesdeChk.Text = "Fecha desde";
            this.FechaDesdeChk.UseVisualStyleBackColor = true;
            this.FechaDesdeChk.CheckedChanged += new System.EventHandler(this.FechaDesdeChk_CheckedChanged);
            // 
            // FechaHastaChk
            // 
            this.FechaHastaChk.AutoSize = true;
            this.FechaHastaChk.Location = new System.Drawing.Point(6, 11);
            this.FechaHastaChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaHastaChk.Name = "FechaHastaChk";
            this.FechaHastaChk.Size = new System.Drawing.Size(85, 17);
            this.FechaHastaChk.TabIndex = 15;
            this.FechaHastaChk.Text = "Fecha hasta";
            this.FechaHastaChk.UseVisualStyleBackColor = true;
            this.FechaHastaChk.CheckedChanged += new System.EventHandler(this.FechaHastaChk_CheckedChanged);
            // 
            // FechaTurnoDesdeDtp
            // 
            this.FechaTurnoDesdeDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaTurnoDesdeDtp.Enabled = false;
            this.FechaTurnoDesdeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTurnoDesdeDtp.Location = new System.Drawing.Point(96, 12);
            this.FechaTurnoDesdeDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTurnoDesdeDtp.MaxDate = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDesdeDtp.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoDesdeDtp.Name = "FechaTurnoDesdeDtp";
            this.FechaTurnoDesdeDtp.Size = new System.Drawing.Size(88, 20);
            this.FechaTurnoDesdeDtp.TabIndex = 14;
            this.FechaTurnoDesdeDtp.Tag = "Fecha";
            // 
            // FechaTurnoHastaDtp
            // 
            this.FechaTurnoHastaDtp.CustomFormat = "dd/MM/yyyy";
            this.FechaTurnoHastaDtp.Enabled = false;
            this.FechaTurnoHastaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTurnoHastaDtp.Location = new System.Drawing.Point(96, 10);
            this.FechaTurnoHastaDtp.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTurnoHastaDtp.MaxDate = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoHastaDtp.MinDate = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            this.FechaTurnoHastaDtp.Name = "FechaTurnoHastaDtp";
            this.FechaTurnoHastaDtp.Size = new System.Drawing.Size(88, 20);
            this.FechaTurnoHastaDtp.TabIndex = 16;
            this.FechaTurnoHastaDtp.Tag = "Fecha";
            // 
            // HoraHastaChk
            // 
            this.HoraHastaChk.AutoSize = true;
            this.HoraHastaChk.Location = new System.Drawing.Point(8, 12);
            this.HoraHastaChk.Margin = new System.Windows.Forms.Padding(2);
            this.HoraHastaChk.Name = "HoraHastaChk";
            this.HoraHastaChk.Size = new System.Drawing.Size(78, 17);
            this.HoraHastaChk.TabIndex = 21;
            this.HoraHastaChk.Text = "Hora hasta";
            this.HoraHastaChk.UseVisualStyleBackColor = true;
            this.HoraHastaChk.CheckedChanged += new System.EventHandler(this.HoraHastaChk_CheckedChanged);
            // 
            // HoraDesdeChk
            // 
            this.HoraDesdeChk.AutoSize = true;
            this.HoraDesdeChk.Location = new System.Drawing.Point(8, 12);
            this.HoraDesdeChk.Margin = new System.Windows.Forms.Padding(2);
            this.HoraDesdeChk.Name = "HoraDesdeChk";
            this.HoraDesdeChk.Size = new System.Drawing.Size(81, 17);
            this.HoraDesdeChk.TabIndex = 18;
            this.HoraDesdeChk.Text = "Hora desde";
            this.HoraDesdeChk.UseVisualStyleBackColor = true;
            this.HoraDesdeChk.CheckedChanged += new System.EventHandler(this.HoraDesdeChk_CheckedChanged);
            // 
            // horaslbl
            // 
            this.horaslbl.AutoSize = true;
            this.horaslbl.Location = new System.Drawing.Point(758, 18);
            this.horaslbl.Name = "horaslbl";
            this.horaslbl.Size = new System.Drawing.Size(24, 13);
            this.horaslbl.TabIndex = 46;
            this.horaslbl.Text = "hrs.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = ":";
            // 
            // MinutoDesdetxt
            // 
            this.MinutoDesdetxt.Enabled = false;
            this.MinutoDesdetxt.Location = new System.Drawing.Point(134, 11);
            this.MinutoDesdetxt.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MinutoDesdetxt.Name = "MinutoDesdetxt";
            this.MinutoDesdetxt.Size = new System.Drawing.Size(38, 20);
            this.MinutoDesdetxt.TabIndex = 20;
            // 
            // HoraDesdetxt
            // 
            this.HoraDesdetxt.Enabled = false;
            this.HoraDesdetxt.Location = new System.Drawing.Point(91, 11);
            this.HoraDesdetxt.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.HoraDesdetxt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.HoraDesdetxt.Name = "HoraDesdetxt";
            this.HoraDesdetxt.Size = new System.Drawing.Size(33, 20);
            this.HoraDesdetxt.TabIndex = 19;
            this.HoraDesdetxt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "hrs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = ":";
            // 
            // MinutoHastatxt
            // 
            this.MinutoHastatxt.Enabled = false;
            this.MinutoHastatxt.Location = new System.Drawing.Point(134, 11);
            this.MinutoHastatxt.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MinutoHastatxt.Name = "MinutoHastatxt";
            this.MinutoHastatxt.Size = new System.Drawing.Size(38, 20);
            this.MinutoHastatxt.TabIndex = 23;
            // 
            // HoraHastatxt
            // 
            this.HoraHastatxt.Enabled = false;
            this.HoraHastatxt.Location = new System.Drawing.Point(91, 11);
            this.HoraHastatxt.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.HoraHastatxt.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.HoraHastatxt.Name = "HoraHastatxt";
            this.HoraHastatxt.Size = new System.Drawing.Size(33, 20);
            this.HoraHastatxt.TabIndex = 22;
            this.HoraHastatxt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // NroDosisChk
            // 
            this.NroDosisChk.AutoSize = true;
            this.NroDosisChk.Location = new System.Drawing.Point(6, 14);
            this.NroDosisChk.Margin = new System.Windows.Forms.Padding(2);
            this.NroDosisChk.Name = "NroDosisChk";
            this.NroDosisChk.Size = new System.Drawing.Size(72, 17);
            this.NroDosisChk.TabIndex = 11;
            this.NroDosisChk.Text = "Nro Dosis";
            this.NroDosisChk.UseVisualStyleBackColor = true;
            this.NroDosisChk.CheckedChanged += new System.EventHandler(this.NroDosisChk_CheckedChanged);
            // 
            // Dosistxt
            // 
            this.Dosistxt.Enabled = false;
            this.Dosistxt.Location = new System.Drawing.Point(80, 14);
            this.Dosistxt.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Dosistxt.Name = "Dosistxt";
            this.Dosistxt.Size = new System.Drawing.Size(93, 20);
            this.Dosistxt.TabIndex = 12;
            this.Dosistxt.Tag = "NroDosis";
            // 
            // VacunaChk
            // 
            this.VacunaChk.AutoSize = true;
            this.VacunaChk.Location = new System.Drawing.Point(5, 15);
            this.VacunaChk.Margin = new System.Windows.Forms.Padding(2);
            this.VacunaChk.Name = "VacunaChk";
            this.VacunaChk.Size = new System.Drawing.Size(63, 17);
            this.VacunaChk.TabIndex = 5;
            this.VacunaChk.Text = "Vacuna";
            this.VacunaChk.UseVisualStyleBackColor = true;
            this.VacunaChk.CheckedChanged += new System.EventHandler(this.VacunaChk_CheckedChanged);
            // 
            // VacunaCbo
            // 
            this.VacunaCbo.DisplayMember = "Nombre";
            this.VacunaCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VacunaCbo.Enabled = false;
            this.VacunaCbo.FormattingEnabled = true;
            this.VacunaCbo.Location = new System.Drawing.Point(101, 12);
            this.VacunaCbo.Margin = new System.Windows.Forms.Padding(2);
            this.VacunaCbo.Name = "VacunaCbo";
            this.VacunaCbo.Size = new System.Drawing.Size(83, 21);
            this.VacunaCbo.TabIndex = 6;
            this.VacunaCbo.Tag = "CodVacuna";
            this.VacunaCbo.ValueMember = "Id";
            // 
            // asistioChk
            // 
            this.asistioChk.AutoSize = true;
            this.asistioChk.Location = new System.Drawing.Point(6, 12);
            this.asistioChk.Margin = new System.Windows.Forms.Padding(2);
            this.asistioChk.Name = "asistioChk";
            this.asistioChk.Size = new System.Drawing.Size(56, 17);
            this.asistioChk.TabIndex = 17;
            this.asistioChk.Text = "Asistio";
            this.asistioChk.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NroDocPacienteChk);
            this.groupBox1.Controls.Add(this.NroDocPacienteTxt);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 38);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dosistxt);
            this.groupBox2.Controls.Add(this.NroDosisChk);
            this.groupBox2.Location = new System.Drawing.Point(204, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 41);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VacunaCbo);
            this.groupBox4.Controls.Add(this.VacunaChk);
            this.groupBox4.Location = new System.Drawing.Point(5, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 41);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CentroAtencionCbo);
            this.groupBox5.Controls.Add(this.CentroChk);
            this.groupBox5.Location = new System.Drawing.Point(204, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 40);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DocEnfermeroTxt);
            this.groupBox6.Controls.Add(this.EnfermeroChk);
            this.groupBox6.Location = new System.Drawing.Point(204, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 37);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FechaTurnoDesdeDtp);
            this.groupBox7.Controls.Add(this.FechaDesdeChk);
            this.groupBox7.Location = new System.Drawing.Point(391, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(190, 38);
            this.groupBox7.TabIndex = 61;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.FechaTurnoHastaDtp);
            this.groupBox8.Controls.Add(this.FechaHastaChk);
            this.groupBox8.Location = new System.Drawing.Point(391, 40);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(190, 40);
            this.groupBox8.TabIndex = 62;
            this.groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.asistioChk);
            this.groupBox9.Location = new System.Drawing.Point(391, 79);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(190, 41);
            this.groupBox9.TabIndex = 63;
            this.groupBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.MinutoDesdetxt);
            this.groupBox10.Controls.Add(this.HoraDesdetxt);
            this.groupBox10.Controls.Add(this.HoraDesdeChk);
            this.groupBox10.Location = new System.Drawing.Point(587, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(198, 37);
            this.groupBox10.TabIndex = 64;
            this.groupBox10.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.MinutoHastatxt);
            this.groupBox11.Controls.Add(this.HoraHastatxt);
            this.groupBox11.Controls.Add(this.HoraHastaChk);
            this.groupBox11.Location = new System.Drawing.Point(587, 40);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(198, 40);
            this.groupBox11.TabIndex = 65;
            this.groupBox11.TabStop = false;
            // 
            // FrmListadoTurnos
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 377);
            this.Controls.Add(this.horaslbl);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.TurnosGrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Turnos";
            this.Activated += new System.EventHandler(this.FrmListadoTurnos_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoTurnos_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TurnosGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutoDesdetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraDesdetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutoHastatxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraHastatxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dosistxt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TurnosGrd;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.CheckBox LocalidadChk;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.TextBox NroDocPacienteTxt;
        private System.Windows.Forms.CheckBox NroDocPacienteChk;
        private System.Windows.Forms.CheckBox EnfermeroChk;
        private System.Windows.Forms.ComboBox DocEnfermeroTxt;
        private System.Windows.Forms.CheckBox CentroChk;
        private System.Windows.Forms.ComboBox CentroAtencionCbo;
        private System.Windows.Forms.CheckBox FechaDesdeChk;
        private System.Windows.Forms.CheckBox FechaHastaChk;
        private System.Windows.Forms.DateTimePicker FechaTurnoDesdeDtp;
        private System.Windows.Forms.DateTimePicker FechaTurnoHastaDtp;
        private System.Windows.Forms.CheckBox HoraHastaChk;
        private System.Windows.Forms.CheckBox HoraDesdeChk;
        private System.Windows.Forms.Label horaslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinutoDesdetxt;
        private System.Windows.Forms.NumericUpDown HoraDesdetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinutoHastatxt;
        private System.Windows.Forms.NumericUpDown HoraHastatxt;
        private System.Windows.Forms.CheckBox NroDosisChk;
        private System.Windows.Forms.NumericUpDown Dosistxt;
        private System.Windows.Forms.CheckBox VacunaChk;
        private System.Windows.Forms.ComboBox VacunaCbo;
        private System.Windows.Forms.CheckBox asistioChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteNombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacunaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnfermeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn asistioCol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
    }
}