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
    public partial class FrmEstadisticaTipoVacuna : FormBase
    {
        private string _criterio = null;
        private List<CentroAtencion> _listado;

        public FrmEstadisticaTipoVacuna()
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
            this.EstadisticaTipoVacunaGrd.AutoGenerateColumns = false;
            this.EstadisticaTipoVacunaGrd.DataSource = listado;
            this.EstadisticaTipoVacunaGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => e1.CodPostal.CompareTo(e2.CodPostal));
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
            int contModerna;
            int biOtech;
            int sputnik;

            for (int i = 0; i < this.EstadisticaTipoVacunaGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.EstadisticaTipoVacunaGrd.Rows[i];
                item.Cells[2].Value = (item.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre;

                int codigoCentro = (item.DataBoundItem as CentroAtencion).Id;

                contModerna = 0;
                biOtech = 0;
                sputnik = 0;

                PacienteVacunadoTipoInscriptos(ref contModerna, ref biOtech, ref sputnik, codigoCentro);

                item.Cells[3].Value = contModerna;
                item.Cells[4].Value = biOtech;
                item.Cells[5].Value = sputnik;
            }
        }

        private void PacienteVacunadoTipoInscriptos(ref int contModerna, ref int biOtech, ref int sputnik, int codigoCentro)
        {

            List<TurnoVacuna> listadoTurno;
            string criterioAux;

            criterioAux = String.Format("cod_centro_a = {0} and asistio = {1}", codigoCentro, true);
            listadoTurno = TurnoVacuna.FindAllStatic(criterioAux, (t1, t2) => (t1.Codigo).CompareTo(t2.Codigo));

            foreach (var t in listadoTurno)
            {
                if (t.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre == "Moderna")
                {
                    contModerna++;
                }
                else
                {
                    if (t.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre == "pfizer-BiONTech")
                    {
                        biOtech++;
                    }
                    else
                    {
                        if (t.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre == "Sputnik V")
                        {
                            sputnik = listadoTurno.Count;
                        }
                    }
                }
            }
           
        }

        private void FrmEstadisticaVacunados_Load(object sender, EventArgs e)
        {
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.ValueMember = "Id";
            this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);

            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.ValueMember = "Codigo";
            this.CentroAtencionCbo.DataSource = ORMDB<CentroAtencion>.FindAll(null);
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

            if (this.CentroAtencionChk.Checked)
            {
                if (this.CentroAtencionCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("codigo = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                    else
                    {
                        criterio += String.Format(" and codigo = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Centro de Atencion esta vacio\nPor favor ingrese el Centro de Atencion o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                this.EstadisticaTipoVacunaGrd.AutoGenerateColumns = false;
                this.EstadisticaTipoVacunaGrd.DataSource = ORMDB<CentroAtencion>.FindAll(criterio);
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
                int contModerna = 0;
                int biOtech = 0;
                int sputnik = 0;

                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("ESTADISTICA DE TIPO DE VACUNA\n");

                foreach (DataGridViewRow rw in this.EstadisticaTipoVacunaGrd.Rows)
                {
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre);
                    sw.WriteLine("Centro: {0}", (rw.DataBoundItem as CentroAtencion).Nombre);

                    int codigoCentro = (rw.DataBoundItem as CentroAtencion).Id;

                    contModerna = 0;
                    biOtech = 0;
                    sputnik = 0;

                    PacienteVacunadoTipoInscriptos(ref contModerna, ref biOtech, ref sputnik, codigoCentro);
                    sw.WriteLine("TIPOS DE VACUNAS");
                    sw.WriteLine("Moderna: {0}", contModerna);
                    sw.WriteLine("Pfizer-BiOtech: {0}", biOtech);
                    sw.WriteLine("Sputnik V: {0}", sputnik);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Estadisticas de Tipo de Vacuna creado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CentroAtencionChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroAtencionCbo.Enabled = CentroAtencionChk.Checked;
        }

        private bool sortAscending = true;

        private void EstadisticaTipoVacunaGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EstadisticaTipoVacunaGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.EstadisticaTipoVacunaGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.EstadisticaTipoVacunaGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else 
            {
                if (EstadisticaTipoVacunaGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
                {
                    if (sortAscending)
                    {
                        this.EstadisticaTipoVacunaGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.LocalidadCentroAtencion.Nombre).CompareTo(e2.LocalidadCentroAtencion.Nombre));
                    }
                    else
                    {
                        this.EstadisticaTipoVacunaGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.LocalidadCentroAtencion.Nombre).CompareTo(e1.LocalidadCentroAtencion.Nombre));
                    }
                }

            }
            sortAscending = !sortAscending;
        }

        private void FrmEstadisticaTipoVacuna_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmEstadisticaTipoVacuna_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
