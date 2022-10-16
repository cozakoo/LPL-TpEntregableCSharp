namespace medicApp.Views
{
    partial class FrmTipoVacunaAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoVacunaAM));
            this.NombreLbl = new System.Windows.Forms.Label();
            this.CantDosisLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CantDosisTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CantDosisTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(12, 22);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(57, 13);
            this.NombreLbl.TabIndex = 1;
            this.NombreLbl.Text = "Nombre (*)";
            // 
            // CantDosisLbl
            // 
            this.CantDosisLbl.AutoSize = true;
            this.CantDosisLbl.Location = new System.Drawing.Point(12, 51);
            this.CantDosisLbl.Name = "CantDosisLbl";
            this.CantDosisLbl.Size = new System.Drawing.Size(106, 13);
            this.CantDosisLbl.TabIndex = 3;
            this.CantDosisLbl.Text = "Cantidad de Dosis (*)";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(68, 19);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(102, 20);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(132, 87);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 14;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(59, 87);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CantDosisTxt
            // 
            this.CantDosisTxt.Location = new System.Drawing.Point(132, 45);
            this.CantDosisTxt.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CantDosisTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantDosisTxt.Name = "CantDosisTxt";
            this.CantDosisTxt.Size = new System.Drawing.Size(38, 20);
            this.CantDosisTxt.TabIndex = 2;
            this.CantDosisTxt.Tag = "CantDosis";
            this.CantDosisTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmTipoVacunaAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(208, 137);
            this.Controls.Add(this.CantDosisTxt);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.CantDosisLbl);
            this.Controls.Add(this.NombreLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTipoVacunaAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de un nuevo tipo de vacuna";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmTipoVacunaAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmTipoVacunaAM_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.CantDosisTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label CantDosisLbl;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.NumericUpDown CantDosisTxt;
    }
}