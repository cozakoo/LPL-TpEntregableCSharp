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
    public partial class FrmEstadisticaVacunados : FormBase
    {

        private string _criterio = null;
        private List<CentroAtencion> _listado;

        public FrmEstadisticaVacunados()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<CentroAtencion> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.EstadisticaVacunadosGrd.AutoGenerateColumns = false;
            this.EstadisticaVacunadosGrd.DataSource = listado;
            this.EstadisticaVacunadosGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => e1.CodPostal.CompareTo(e2.CodPostal));
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
            int codigoCentro;

            for( int i=0;i<this.EstadisticaVacunadosGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.EstadisticaVacunadosGrd.Rows[i];
                item.Cells[2].Value = (item.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre;

                codigoCentro = (item.DataBoundItem as CentroAtencion).Id;
                inscriptos = ObtenerPacientesInscriptos(codigoCentro);
                asistieron = ObtenerPacientesAsistidos(codigoCentro);

                item.Cells[3].Value = inscriptos;
                item.Cells[4].Value = asistieron;
                item.Cells[5].Value = String.Format("{0}%",ObtenerPorcentajeEdad(codigoCentro));
            }
        }

        public int ObtenerPacientesInscriptos(int codigoCentro)
        {
            List<TurnoVacuna> listadoAux;
            string criterioAux = String.Format("cod_centro_a = {0}", codigoCentro);
            listadoAux = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Fecha).CompareTo(t2.Fecha));
            return listadoAux.Count;
        }

        public int ObtenerPacientesAsistidos(int codigoCentro)
        {
            List<TurnoVacuna> listadoAux;
            string criterioAux = String.Format("cod_centro_a = {0} and asistio = {1}", codigoCentro, true);
            listadoAux = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Fecha).CompareTo(t2.Fecha));
            return listadoAux.Count;
        }

        public double ObtenerPorcentajeEdad(int codigoCentro)
        {
            List<TurnoVacuna> listadoAux;
            string criterioAux = String.Format("cod_centro_a = {0} and asistio = {1}", codigoCentro, true);
            listadoAux = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Codigo).CompareTo(t2.Codigo));

            int acumEdad = 0;
            int i = 0;

            foreach (var l in listadoAux)
            {
                 acumEdad += l.PacienteTurnoVacuna.Edad();
                 i++;
            }

            if (i == 0)
            {
                return 0;
            }
            else
            {
                return acumEdad / i;
            }
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
                this.EstadisticaVacunadosGrd.AutoGenerateColumns = false;
                this.EstadisticaVacunadosGrd.DataSource = ORMDB<CentroAtencion>.FindAll(criterio);
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
                sw.WriteLine("ESTADISTICA DE PORCENTAJE DE EDAD\n");

                foreach (DataGridViewRow rw in this.EstadisticaVacunadosGrd.Rows)
                {
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre);
                    sw.WriteLine("Centro: {0}", (rw.DataBoundItem as CentroAtencion).Nombre);
                    int codigoCentro = (rw.DataBoundItem as CentroAtencion).Id;    
                    sw.WriteLine("Tota de pacientes inscriptos: {0}", ObtenerPacientesInscriptos(codigoCentro));
                    sw.WriteLine("Total de pacientes que asistieron: {0}", ObtenerPacientesAsistidos(codigoCentro));
                    sw.WriteLine("Promedio por edad: {0}%", ObtenerPorcentajeEdad(codigoCentro));
                    sw.WriteLine("\n");
                }

                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Estadisticas de pacientes vacunados creado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = true;

        private void EstadisticaVacunadosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EstadisticaVacunadosGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.EstadisticaVacunadosGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.EstadisticaVacunadosGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (EstadisticaVacunadosGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
                {
                    if (sortAscending)
                    {
                        this.EstadisticaVacunadosGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.LocalidadCentroAtencion.Nombre).CompareTo(e2.LocalidadCentroAtencion.Nombre));
                    }
                    else
                    {
                        this.EstadisticaVacunadosGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.LocalidadCentroAtencion.Nombre).CompareTo(e1.LocalidadCentroAtencion.Nombre));
                    }
                }

            }
            sortAscending = !sortAscending;
        }

        private void FrmEstadisticaVacunados_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmEstadisticaVacunados_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
