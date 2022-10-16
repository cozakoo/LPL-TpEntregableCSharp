namespace medicApp.Views
{
    partial class FrmCentroAtencionAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentroAtencionAM));
            this.NombreLbl = new System.Windows.Forms.Label();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(20, 22);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(57, 13);
            this.NombreLbl.TabIndex = 0;
            this.NombreLbl.Text = "Nombre (*)";
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(13, 56);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(65, 13);
            this.DireccionLbl.TabIndex = 1;
            this.DireccionLbl.Text = "Dirección (*)";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(14, 88);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(62, 13);
            this.TelefonoLbl.TabIndex = 2;
            this.TelefonoLbl.Text = "Teléfono (*)";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            this.LocalidadCbo.Location = new System.Drawing.Point(79, 115);
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Size = new System.Drawing.Size(178, 21);
            this.LocalidadCbo.TabIndex = 4;
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            this.LocalidadLbl.AutoSize = true;
            this.LocalidadLbl.Location = new System.Drawing.Point(13, 118);
            this.LocalidadLbl.Name = "LocalidadLbl";
            this.LocalidadLbl.Size = new System.Drawing.Size(66, 13);
            this.LocalidadLbl.TabIndex = 4;
            this.LocalidadLbl.Text = "Localidad (*)";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(79, 18);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(178, 20);
            this.NombreTxt.TabIndex = 1;
            this.NombreTxt.Tag = "Nombre";
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLineaTxt_KeyPress);
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(79, 52);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.Size = new System.Drawing.Size(178, 20);
            this.DireccionTxt.TabIndex = 2;
            this.DireccionTxt.Tag = "Domicilio";
            this.DireccionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringLinea_Numerot_KeyPress);
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(79, 84);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(178, 20);
            this.TelefonoTxt.TabIndex = 3;
            this.TelefonoTxt.Tag = "Telefono";
            this.TelefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(231, 172);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(168, 172);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.NombreLbl);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.DireccionLbl);
            this.groupBox1.Controls.Add(this.DireccionTxt);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 150);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // FrmCentroAtencionAM
            // 
            this.AcceptButton = this.GuardarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(305, 210);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCentroAtencionAM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Centro de Atención";
            this.Activated += new System.EventHandler(this.FrmCentroAtencionAM_Activated);
            this.Deactivate += new System.EventHandler(this.FrmCentroAtencionAM_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}