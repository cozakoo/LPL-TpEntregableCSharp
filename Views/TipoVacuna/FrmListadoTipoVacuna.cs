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
    public partial class FrmListadoTipoVacuna: FormBase
    {
        private string criterio = null;

        public FrmListadoTipoVacuna()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void DosisTxtChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DosisTxt.Enabled = this.DosisChk.Checked;
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void DosisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DosisTxt.Enabled = this.DosisChk.Checked;
        }
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            bool salir = false;
            criterio = null;

            if (this.DosisChk.Checked)
            {
                if (DosisTxt.Text.Trim() != string.Empty)
                {

                    if (criterio == null)
                    {
                        criterio = String.Format("cant_dosis = {0}", DosisTxt.Text.Trim());
                    }
                    else
                        criterio += String.Format(" and cant_dosis = {0}", DosisTxt.Text.Trim());
                }
                else
                {
                    MessageBox.Show("El filtro de Cantidad de dosis esta vacio\nPor favor ingrese el Tipo de Vacuna o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.NombreChk.Checked)
            {
                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nombre like '%{0}%'", NombreTxt.Text.Trim());
                    }
                    else
                        criterio += String.Format(" and nombre like '%{0}%'", NombreTxt.Text.Trim());
                }
                else
                {
                    MessageBox.Show("El filtro de Nombre esta vacio\nPor favor ingrese el Tipo de Vacuna o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(criterio, (p1, p2) => (p1.Nombre).CompareTo(p2.Nombre));
            }
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE TIPOS DE VACUNAS\n");

                foreach (DataGridViewRow rw in this.TiposVacunasGrd.Rows)
                {
                    sw.WriteLine("Codigo: {0}", (rw.DataBoundItem as TipoVacuna).Id);
                    sw.WriteLine("Nombre: {0}", (rw.DataBoundItem as TipoVacuna).Nombre);
                    sw.WriteLine("Cantidad de Dosis: {0}", (rw.DataBoundItem as TipoVacuna).CantDosis);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de tipo de vacunas creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void TiposVacunasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TiposVacunasGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as TipoVacuna).CantDosis;
            }
        }

        private void FrmListadoTipoVacuna_Load(object sender, EventArgs e)
        {
            this.TiposVacunasGrd.AutoGenerateColumns = false;
            //this.TiposVacunasGrd.DataSource = ORMDB<TipoVacuna>.FindAll(null);

            this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(null, (p1, p2) => (p1.Nombre + p1.Nombre).CompareTo(p2.Nombre + p2.Nombre));


        }

        private void TipoVacunaGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TiposVacunasGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoVacunaAM frvac = new FrmTipoVacunaAM();
                TipoVacuna vac = (this.TiposVacunasGrd.SelectedRows[0].DataBoundItem as TipoVacuna);
                frvac.ShowModificarTipoVacuna(vac);
            }
        }

        private void TiposVacunasGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TiposVacunasGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoVacunaAM frmTipo = new FrmTipoVacunaAM();
                frmTipo.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                TipoVacuna tipo = (this.TiposVacunasGrd.SelectedRows[0].DataBoundItem as TipoVacuna);
                frmTipo.ShowModificarTipoVacuna(tipo);
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TiposVacunasGrd.SelectedRows[0].Index;
                this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(null, (e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
                TiposVacunasGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo vacuna actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TiposVacunasGrd_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.TiposVacunasGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.TiposVacunasGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as TipoVacuna).Nombre;
                item.Cells[1].Value = (item.DataBoundItem as TipoVacuna).CantDosis;
            }

        }

        private bool sortAscending = false;

        private void TiposVacunasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (TiposVacunasGrd.Columns[e.ColumnIndex].Name == "NombresCol")
            {
                if (sortAscending)
                {
                    this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (TiposVacunasGrd.Columns[e.ColumnIndex].Name == "Dosiscool")
                {
                    if (sortAscending)
                    {
                        this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.CantDosis).CompareTo(e2.CantDosis));
                    }
                    else
                    {
                        this.TiposVacunasGrd.DataSource = TipoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.CantDosis).CompareTo(e1.CantDosis));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoTipoVacuna_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoTipoVacuna_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
