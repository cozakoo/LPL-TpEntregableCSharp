namespace medicApp.Views
{
    partial class FrmConsultaVacunacion
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
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.NroDoctxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.AsistioChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(114, 84);
            this.ConsultarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(66, 27);
            this.ConsultarBtn.TabIndex = 3;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // NroDoctxt
            // 
            this.NroDoctxt.Location = new System.Drawing.Point(17, 37);
            this.NroDoctxt.Margin = new System.Windows.Forms.Padding(2);
            this.NroDoctxt.Name = "NroDoctxt";
            this.NroDoctxt.Size = new System.Drawing.Size(131, 20);
            this.NroDoctxt.TabIndex = 1;
            this.NroDoctxt.Tag = "NroDocumento";
            this.NroDoctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(5, 16);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(166, 13);
            this.DniLbl.TabIndex = 18;
            this.DniLbl.Text = "Ingrese el Numero de Documento";
            // 
            // AsistioChk
            // 
            this.AsistioChk.AutoSize = true;
            this.AsistioChk.Location = new System.Drawing.Point(2, 11);
            this.AsistioChk.Margin = new System.Windows.Forms.Padding(2);
            this.AsistioChk.Name = "AsistioChk";
            this.AsistioChk.Size = new System.Drawing.Size(56, 17);
            this.AsistioChk.TabIndex = 2;
            this.AsistioChk.Text = "Asistio";
            this.AsistioChk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NroDoctxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 71);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AsistioChk);
            this.groupBox2.Location = new System.Drawing.Point(9, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(61, 32);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // FrmConsultaVacunacion
            // 
            this.AcceptButton = this.ConsultarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 123);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsultarBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaVacunacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Vacunacion";
            this.Activated += new System.EventHandler(this.FrmConsultaVacunacion_Activated);
            this.Deactivate += new System.EventHandler(this.FrmConsultaVacunacion_Deactivate);
            this.Enter += new System.EventHandler(this.BuscarBtn_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.TextBox NroDoctxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.CheckBox AsistioChk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}