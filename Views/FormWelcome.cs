using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace medicApp.Views
{
    public partial class FormWelcome : Form
    {
        int cont = 0;

        public FormWelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;

            progressBar1.Value += 1;
            cont += 1;
            Porcentajetxt.Text = String.Format("{0}%", cont);
            //progressBar1.text  = progressBar1.Value.ToString();

            if (progressBar1.Value == 100)
            {
                timer1.Stop();  
                timer2.Start();
            }
        }       

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                //this.Dispose();
                MainView.Instance.ShowUsuario();
            }
        }

        public void mostrarPantalla()
        {
            this.Show();
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
