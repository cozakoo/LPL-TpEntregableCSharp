namespace medicApp.Views
{
    partial class FrmListadoTipoVacuna : FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoTipoVacuna));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DosisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DosisTxt = new System.Windows.Forms.TextBox();
            this.DosisChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.TiposVacunasGrd = new System.Windows.Forms.DataGridView();
            this.NombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosiscool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposVacunasGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // DosisCol
            // 
            this.DosisCol.DataPropertyName = "cant_dosis";
            resources.ApplyResources(this.DosisCol, "DosisCol");
            this.DosisCol.Name = "DosisCol";
            this.DosisCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "nombre";
            resources.ApplyResources(this.NombreCol, "NombreCol");
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DosisTxt);
            this.groupBox1.Controls.Add(this.DosisChk);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // DosisTxt
            // 
            resources.ApplyResources(this.DosisTxt, "DosisTxt");
            this.DosisTxt.Name = "DosisTxt";
            // 
            // DosisChk
            // 
            resources.ApplyResources(this.DosisChk, "DosisChk");
            this.DosisChk.Name = "DosisChk";
            this.DosisChk.UseVisualStyleBackColor = true;
            this.DosisChk.CheckedChanged += new System.EventHandler(this.DosisChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            resources.ApplyResources(this.FiltroBtn, "FiltroBtn");
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // ExportarBtn
            // 
            resources.ApplyResources(this.ExportarBtn, "ExportarBtn");
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreTxt);
            this.groupBox2.Controls.Add(this.NombreChk);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // NombreTxt
            // 
            resources.ApplyResources(this.NombreTxt, "NombreTxt");
            this.NombreTxt.Name = "NombreTxt";
            // 
            // NombreChk
            // 
            resources.ApplyResources(this.NombreChk, "NombreChk");
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // TiposVacunasGrd
            // 
            this.TiposVacunasGrd.AllowUserToAddRows = false;
            this.TiposVacunasGrd.AllowUserToDeleteRows = false;
            this.TiposVacunasGrd.AllowUserToResizeColumns = false;
            this.TiposVacunasGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TiposVacunasGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TiposVacunasGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposVacunasGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombresCol,
            this.Dosiscool});
            resources.ApplyResources(this.TiposVacunasGrd, "TiposVacunasGrd");
            this.TiposVacunasGrd.MultiSelect = false;
            this.TiposVacunasGrd.Name = "TiposVacunasGrd";
            this.TiposVacunasGrd.ReadOnly = true;
            this.TiposVacunasGrd.RowTemplate.Height = 24;
            this.TiposVacunasGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TiposVacunasGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TiposVacunasGrd_ColumnHeaderMouseClick);
            this.TiposVacunasGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TiposVacunasGrd_DataBindingComplete_1);
            this.TiposVacunasGrd.DoubleClick += new System.EventHandler(this.TiposVacunasGrd_DoubleClick);
            // 
            // NombresCol
            // 
            this.NombresCol.DataPropertyName = "Nombre";
            resources.ApplyResources(this.NombresCol, "NombresCol");
            this.NombresCol.Name = "NombresCol";
            this.NombresCol.ReadOnly = true;
            // 
            // Dosiscool
            // 
            this.Dosiscool.DataPropertyName = "cant_dosis";
            resources.ApplyResources(this.Dosiscool, "Dosiscool");
            this.Dosiscool.Name = "Dosiscool";
            this.Dosiscool.ReadOnly = true;
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // FrmListadoTipoVacuna
            // 
            this.AcceptButton = this.FiltroBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TiposVacunasGrd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTipoVacuna";
            this.Activated += new System.EventHandler(this.FrmListadoTipoVacuna_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoTipoVacuna_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoTipoVacuna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposVacunasGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DosisTxt;
        private System.Windows.Forms.CheckBox DosisChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.DataGridView TiposVacunasGrd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosiscool;
    }
}