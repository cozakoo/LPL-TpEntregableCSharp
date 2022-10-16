using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using medicApp.db;

namespace medicApp.Views
{
    public partial class FrmListadoLocalidad : FormBase
    {
        private string criterio = null;

        public FrmListadoLocalidad()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void CodPostalChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalTxt.Enabled = this.CodPostalChk.Checked;
        }

        private void FrmListadoLocalidad_Load(object sender, EventArgs e)
        {                           
            this.LocalidadesGrd.AutoGenerateColumns = false;
            this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(null, (p1, p2) => (p1.Nombre + p1.Nombre).CompareTo(p2.Nombre + p2.Nombre));
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            criterio = null;
            bool salir = false;

            if (this.CodPostalChk.Checked)
            {
                if (CodPostalTxt.Text.Trim() != string.Empty)
                {
                    if (criterio != null)
                    {
                        criterio += " and cod_postal= " + CodPostalTxt;
                    }
                    else
                        criterio += "cod_postal= " + CodPostalTxt;
                }
                else
                {
                    MessageBox.Show("El filtro de Codigo postal esta vacio\nPor favor ingrese el codigo postal de la Localidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.NombreChk.Checked)
            {
                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (criterio != null)
                    {
                        criterio += " and nombre = " + NombreTxt.Text;
                    }
                    else
                        criterio += "nombre = " + NombreTxt.Text;
                }
                else
                {
                    MessageBox.Show("El filtro de Nombre esta vacio\nPor favor ingrese el nombre de la localidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
                if (!salir)
                {
                    this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Nombre + p1.Nombre).CompareTo(p2.Nombre + p2.Nombre));
                }

            }

        }
        private void LocalidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.LocalidadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.LocalidadesGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as Localidad).Nombre;
                item.Cells[1].Value = (item.DataBoundItem as Localidad).Id;
            }
        }

        private void LocalidadesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.LocalidadesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmLocalidadAM frmpac = new FrmLocalidadAM();
                frmpac.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                Localidad loc = (this.LocalidadesGrd.SelectedRows[0].DataBoundItem as Localidad);
                frmpac.ShowModificarLocalidad(loc);
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = LocalidadesGrd.SelectedRows[0].Index;
                this.LocalidadesGrd.DataSource = TipoVacuna.FindAllStatic(null, (e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
                LocalidadesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Localidad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE LOCALIDADES\n");

                foreach (DataGridViewRow rw in this.LocalidadesGrd.Rows)
                {
                    sw.WriteLine("Codigo: {0}", (rw.DataBoundItem as Localidad).Id);
                    sw.WriteLine("Nombre: {0}", (rw.DataBoundItem as Localidad).Nombre);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de tipo de vacunas creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool sortAscending = false;

        private void LocalidadesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (LocalidadesGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (LocalidadesGrd.Columns[e.ColumnIndex].Name == "CodPostalCol")
                {
                    if (sortAscending)
                    {
                        this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (e1, e2) => (e1.Id).CompareTo(e2.Id));
                    }
                    else
                    {
                        this.LocalidadesGrd.DataSource = Localidad.FindAllStatic(criterio, (e1, e2) => (e2.Id).CompareTo(e1.Id));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoLocalidad_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoLocalidad_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
