namespace medicApp.Views
{
    partial class FrmLocalidadAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalidadAM));
            this.NombreLbl = new System.Windows.Forms.Label();
            this.CodPostalLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(12, 24);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(57, 13);
            this.NombreLbl.TabIndex = 0;
            this.NombreLbl.Tag = "Nombre";
            this.NombreLbl.Text = "Nombre (*)";
            // 
            // CodPostalLbl
            // 
            this.CodPostalLbl.AutoSize = true;
            this.CodPostalLbl.Location = new System.Drawing.Point(12, 60);
            this.CodPostalLbl.Name = "CodPostalLbl";
            this.CodPostalLbl.Size = new System.Drawing.Size(85, 13);
            this.CodPostalLbl.TabIndex = 1;
            this.CodPostalLbl.Tag = "CodPostal";
            this.CodPostalLbl.Text = "Codigo Postal (*)";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(115, 21);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 2;
            this.NombreTxt.Tag = "NombreTxt";
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Location = new System.Drawing.Point(115, 57);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(100, 20);
            this.CodPostalTxt.TabIndex = 3;
            this.CodPostalTxt.Tag = "CodPostalTxt";
            this.CodPostalTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(156, 93);
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
            this.GuardarBtn.Location = new System.Drawing.Point(86, 93);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 13;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmLocalidadAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(229, 131);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CodPostalTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.CodPostalLbl);
            this.Controls.Add(this.NombreLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocalidadAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Localidad";
            this.Activated += new System.EventHandler(this.FrmLocalidadAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmLocalidadAM_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label CodPostalLbl;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
    }
}