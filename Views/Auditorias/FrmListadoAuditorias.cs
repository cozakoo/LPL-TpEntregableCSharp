using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using medicApp.db;
using System.IO;

namespace medicApp.Views
{

    public partial class FrmListadoAuditorias : FormBase
    {

        private string _criterio = null;
        private List<Usuario> _listado;
        
        public FrmListadoAuditorias()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Usuario> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.AuditoriasGrd.AutoGenerateColumns = false;
            this.AuditoriasGrd.DataSource = listado;
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alfo()
        {
            List<string> logtxt = new List<string>();
            using (StreamReader leer = new StreamReader(@"../../../log-de-actividades.txt"))
            {
                while(!leer.EndOfStream) //lee todo
                {
                    string x = leer.ReadLine();
                }
            }
        }

        private void mostrarGrilla(string usuarioCriterio)
        {
            string linea;
            StreamReader sr = new StreamReader(@"../../../log-de-actividades.txt");
            int cont = 0;
            linea = sr.ReadLine();
            string nombreUsuaio;

            while (linea != null)
            {
                AuditoriasGrd.Rows.Add("hola");
                DataGridViewRow item = this.AuditoriasGrd.Rows[cont];

                nombreUsuaio = ObtenerUsuario(linea);

                if (usuarioCriterio == nombreUsuaio)
                {
                    item.Cells[1].Value = String.Format("{0}", ObtenerUsuario(linea));
                    item.Cells[2].Value = String.Format("{0}", ObtenerFecha(linea));
                    item.Cells[3].Value = String.Format("{0}", ObtenerHora(linea));
                    item.Cells[4].Value = String.Format("{0}", ObtenerActividad(linea));

                    cont++;
                }
                
                linea = sr.ReadLine();
            }
            sr.Close();
        }

        private void completarGrilla()
        {
            string linea;
            StreamReader sr = new StreamReader(@"../../../log-de-actividades.txt");
            int cont = 0;
            linea = sr.ReadLine();

            while (linea != null)
            {
                AuditoriasGrd.Rows.Add("hola");
                DataGridViewRow item = this.AuditoriasGrd.Rows[cont];
                item.Cells[1].Value = String.Format("{0}",ObtenerUsuario(linea));
                item.Cells[2].Value = String.Format("{0}", ObtenerFecha(linea));
                item.Cells[3].Value = String.Format("{0}", ObtenerHora(linea));
                item.Cells[4].Value = String.Format("{0}", ObtenerActividad(linea));
                
                cont++;
                linea = sr.ReadLine();
            }
            sr.Close();
        }
        
        private string ObtenerUsuario(string linea)
        {
            char delimitador = '|';
            string[] valores = linea.Split(delimitador);
            return valores[0];
        }

        private string ObtenerFecha(string linea)
        {
            char delimitador = '|';
            string[] valores = linea.Split(delimitador);

            return valores[2];
        }

        private string ObtenerHora(string linea)
        {
            char delimitador = '|';
            string[] valores = linea.Split(delimitador);
            return valores[3];
        }

        private string ObtenerActividad(string linea)
        {
            char delimitador = '|';
            string[] valores = linea.Split(delimitador);
            return valores[1];
        }

        private void FrmEstadisticaVacunados_Load(object sender, EventArgs e)
        {
            this.AuditoriaCbo.DataSource = Usuario.FindAllStatic(null, (u1, u2) => (u1.UsuarioName).CompareTo(u2.UsuarioName));
            this.AuditoriaCbo.SelectedIndex = -1;
            this.AuditoriaCbo.ToString();
            completarGrilla();
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;
            bool salir = false; 

            if (this.UsuarioChk.Checked)
            {
                if (this.AuditoriaCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = string.Format("{0}", (AuditoriaCbo.SelectedItem as Usuario).UsuarioName);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Usuarioesta vacio\nPor favor ingrese el usuario o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                this.AuditoriasGrd.AutoGenerateColumns = false;
                AuditoriasGrd.Rows.Clear();

                if (criterio == null)
                {
                    completarGrilla();
                }
                else
                {
                    mostrarGrilla(criterio);
                }
            }
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.AuditoriaCbo.Enabled = UsuarioChk.Checked;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);

                foreach (DataGridViewRow rw in this.AuditoriasGrd.Rows)
                {
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as Localidad).Nombre);
                    int codigoLocalidad = (rw.DataBoundItem as Localidad).Id;
                    sw.WriteLine("\n");
                }

                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Estadisticas de pacientes vacunados creado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmListadoAuditorias_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoAuditorias_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
