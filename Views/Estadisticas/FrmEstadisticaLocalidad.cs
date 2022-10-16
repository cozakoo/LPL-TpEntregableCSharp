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
    public partial class FrmEstadisticaLocalidad : FormBase
    {

        private string _criterio = null;
        private List<Localidad> _listado;

        public FrmEstadisticaLocalidad()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.EstadisticaLocalidadGrd.AutoGenerateColumns = false;
            this.EstadisticaLocalidadGrd.DataSource = listado;
            //this.EstadisticaLocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e1. CodPostal).CompareTo(e2.CodPostal));
            //InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            double inscriptos;
            double asistieron;
            int codigoLocalidad;

            for( int i=0;i<this.EstadisticaLocalidadGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.EstadisticaLocalidadGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as Localidad).Nombre;

                codigoLocalidad = (item.DataBoundItem as Localidad).Id;
                inscriptos = ObtenerPacientesInscriptos(codigoLocalidad);
                asistieron = ObtenerPacientesAsistidos(codigoLocalidad);

                item.Cells[2].Value = inscriptos;
                item.Cells[3].Value = asistieron;

                if (asistieron == 0)
                {
                    item.Cells[4].Value = String.Format("{0}%",0);
                }
                else
                {
                    item.Cells[4].Value = String.Format("{0}%", (asistieron / inscriptos) * 100);
                }
                
                
            }
        }

        public int ObtenerPacientesInscriptos(int codigoCentro)
        {
            List<TurnoVacuna> listadoAux;
            string criterioAux = String.Format("cod_centro_a in (select codigo from centro_atencion where cod_postal = {0})", codigoCentro);
            listadoAux = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Fecha).CompareTo(t2.Fecha));
            return listadoAux.Count;
        }

        public int ObtenerPacientesAsistidos(int codigoCentro)
        {
            List<TurnoVacuna> listadoAux;
            string criterioAux = String.Format("asistio = {0} and cod_centro_a in (select codigo from centro_atencion where cod_postal = {1})", true, codigoCentro);
            listadoAux = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Fecha).CompareTo(t2.Fecha));
            return listadoAux.Count;
        }

        private void FrmEstadisticaVacunados_Load(object sender, EventArgs e)
        {
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.ValueMember = "Id";

            this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;
            bool salir = false; 

            if (this.LocalidadChk.Checked)
            {
                if (this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
                    }
                    else
                    {
                        criterio += " and cod_postal = " + LocalidadCbo.SelectedValue;
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Localidad esta vacio\nPor favor ingrese la localid o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                this.EstadisticaLocalidadGrd.AutoGenerateColumns = false;
                this.EstadisticaLocalidadGrd.DataSource = ORMDB<Localidad>.FindAll(criterio);
            }
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("ESTADISTICA DE PORCENTAJE DE LOCALIDAD\n");

                foreach (DataGridViewRow rw in this.EstadisticaLocalidadGrd.Rows)
                {
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as Localidad).Nombre);
                    int codigoLocalidad = (rw.DataBoundItem as Localidad).Id;
                    int inscriptos = ObtenerPacientesInscriptos(codigoLocalidad);
                    int asistieron = ObtenerPacientesAsistidos(codigoLocalidad);
                    sw.WriteLine("Tota de pacientes inscriptos: {0}", inscriptos);
                    sw.WriteLine("Total de pacientes que asistieron: {0}", asistieron);
                    sw.WriteLine("Promedio de Vacunacion: {0}%", (asistieron / inscriptos) * 100);
                    sw.WriteLine("\n");
                }

                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Estadisticas de pacientes vacunados creado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = true;

        private void EstadisticaLocalidadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EstadisticaLocalidadGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
            {
                if (sortAscending)
                {
                    this.EstadisticaLocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.EstadisticaLocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmEstadisticaLocalidad_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmEstadisticaLocalidad_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
