namespace medicApp.Views
{
    partial class FrmListadoLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoLocalidad));
            this.LocalidadesGrd = new System.Windows.Forms.DataGridView();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPostalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CodPostalChk = new System.Windows.Forms.CheckBox();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalidadesGrd
            // 
            this.LocalidadesGrd.AllowUserToAddRows = false;
            this.LocalidadesGrd.AllowUserToDeleteRows = false;
            this.LocalidadesGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalidadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCol,
            this.CodPostalCol});
            this.LocalidadesGrd.Location = new System.Drawing.Point(8, 112);
            this.LocalidadesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadesGrd.MultiSelect = false;
            this.LocalidadesGrd.Name = "LocalidadesGrd";
            this.LocalidadesGrd.ReadOnly = true;
            this.LocalidadesGrd.RowTemplate.Height = 24;
            this.LocalidadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalidadesGrd.ShowEditingIcon = false;
            this.LocalidadesGrd.Size = new System.Drawing.Size(259, 215);
            this.LocalidadesGrd.TabIndex = 0;
            this.LocalidadesGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LocalidadesGrd_ColumnHeaderMouseClick);
            this.LocalidadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LocalidadesGrd_DataBindingComplete);
            this.LocalidadesGrd.DoubleClick += new System.EventHandler(this.LocalidadesGrd_DoubleClick);
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "nombre";
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            // 
            // CodPostalCol
            // 
            this.CodPostalCol.DataPropertyName = "cod_postal";
            this.CodPostalCol.HeaderText = "Codigo Postal";
            this.CodPostalCol.Name = "CodPostalCol";
            this.CodPostalCol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodPostalTxt);
            this.groupBox1.Controls.Add(this.CodPostalChk);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(169, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Enabled = false;
            this.CodPostalTxt.Location = new System.Drawing.Point(99, 15);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(57, 20);
            this.CodPostalTxt.TabIndex = 1;
            // 
            // CodPostalChk
            // 
            this.CodPostalChk.AutoSize = true;
            this.CodPostalChk.Location = new System.Drawing.Point(4, 17);
            this.CodPostalChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalChk.Name = "CodPostalChk";
            this.CodPostalChk.Size = new System.Drawing.Size(91, 17);
            this.CodPostalChk.TabIndex = 0;
            this.CodPostalChk.Text = "Codigo Postal";
            this.CodPostalChk.UseVisualStyleBackColor = true;
            this.CodPostalChk.CheckedChanged += new System.EventHandler(this.CodPostalChk_CheckedChanged);
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(191, 20);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 2;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Enabled = false;
            this.ExportarBtn.Location = new System.Drawing.Point(183, 332);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(84, 26);
            this.ExportarBtn.TabIndex = 7;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreTxt);
            this.groupBox2.Controls.Add(this.NombreChk);
            this.groupBox2.Location = new System.Drawing.Point(11, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(256, 42);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(97, 15);
            this.NombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(146, 20);
            this.NombreTxt.TabIndex = 1;
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(4, 17);
            this.NombreChk.Margin = new System.Windows.Forms.Padding(2);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 0;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // FrmListadoLocalidad
            // 
            this.AcceptButton = this.FiltroBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LocalidadesGrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmListadoLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Localidades";
            this.Activated += new System.EventHandler(this.FrmListadoLocalidad_Activated);
            this.Deactivate += new System.EventHandler(this.FrmListadoLocalidad_Deactivate);
            this.Load += new System.EventHandler(this.FrmListadoLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadesGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LocalidadesGrd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.CheckBox CodPostalChk;
        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPostalCol;
    }
}