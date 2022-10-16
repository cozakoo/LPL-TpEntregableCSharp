namespace medicApp.Views
{
    partial class FrmLocalidadList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalidadList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.LocalidadGrd = new System.Windows.Forms.DataGridView();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CerrarBtn);
            this.groupBox1.Controls.Add(this.LocalidadGrd);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(191, 187);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 8;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // LocalidadGrd
            // 
            this.LocalidadGrd.AllowUserToAddRows = false;
            this.LocalidadGrd.AllowUserToDeleteRows = false;
            this.LocalidadGrd.AllowUserToResizeColumns = false;
            this.LocalidadGrd.AllowUserToResizeRows = false;
            this.LocalidadGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalidadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCol,
            this.codPostalCol});
            this.LocalidadGrd.Location = new System.Drawing.Point(15, 19);
            this.LocalidadGrd.Name = "LocalidadGrd";
            this.LocalidadGrd.Size = new System.Drawing.Size(236, 166);
            this.LocalidadGrd.TabIndex = 0;
            this.LocalidadGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LocalidadGrd_ColumnHeaderMouseClick);
            this.LocalidadGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.LocalidadGrd_DataBindingComplete);
            this.LocalidadGrd.DoubleClick += new System.EventHandler(this.LocalidadGrd_DoubleClick);
            // 
            // NombreCol
            // 
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            // 
            // codPostalCol
            // 
            this.codPostalCol.HeaderText = "Código Postal";
            this.codPostalCol.Name = "codPostalCol";
            this.codPostalCol.ReadOnly = true;
            // 
            // FrmLocalidadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 237);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocalidadList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Localidades";
            this.Activated += new System.EventHandler(this.FrmLocalidadList_Activated);
            this.Deactivate += new System.EventHandler(this.FrmLocalidadList_Deactivate);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView LocalidadGrd;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalCol;
    }
}