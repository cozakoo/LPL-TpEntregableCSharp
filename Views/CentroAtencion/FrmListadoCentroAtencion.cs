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
    public partial class FrmListadoCentroAtencion : FormBase
    {
        private bool sortAscending = false;
        string criterio = null;

        public FrmListadoCentroAtencion()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoCentroAtencion_Load(object sender, EventArgs e)
        {
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.ValueMember = "Id";

            this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);

            this.CentroAtencionGrd.AutoGenerateColumns = false;
            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(null, (cen1,cen2) => (cen1.Nombre).CompareTo(cen2.Nombre));
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            bool salir = false;
            criterio = null;

            if (this.NombreChk.Checked)
            {
                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nombre like '%{0}%'", (NombreTxt.Text.Trim()));
                    }
                    else
                    {
                        criterio += String.Format(" and nombre like '%{0}%'", (NombreTxt.Text.Trim()));
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de NOMBRE esta vacio\nPor favor ingrese el NOMBRE o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.LocalidadChk.Checked)
            {
                if ((LocalidadCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_postal={0} ", LocalidadCbo.SelectedValue);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_postal = {0}", LocalidadCbo.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de LOCALIDAD esta vacio\nPor favor ingrese la LOCALIDAD o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                this.CentroAtencionGrd.AutoGenerateColumns = false;
                this.CentroAtencionGrd.DataSource = ORMDB<CentroAtencion>.FindAll(criterio);
            }
        }

        private void CentroAtencionGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.CentroAtencionGrd.Rows)
            {
                rw.Cells[3].Value = (rw.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre;
            }
        }

        public void ShowListar()
        {
            this.Show();
        }

        private void CentroAtencionGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.CentroAtencionGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmCentroAtencionAM frm = new FrmCentroAtencionAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                CentroAtencion cen = (this.CentroAtencionGrd.SelectedRows[0].DataBoundItem as CentroAtencion);
                frm.ShowModificarCentroAtencion(cen);
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;

            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = CentroAtencionGrd.SelectedRows[0].Index;
                this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(null, (e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
                CentroAtencionGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Centro de Atencion actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE CENTROS DE ATENCION\n");

                foreach (DataGridViewRow rw in this.CentroAtencionGrd.Rows)
                {
                    sw.WriteLine("Nombre: {0}", (rw.DataBoundItem as CentroAtencion).Nombre);
                    sw.WriteLine("Domicilio: {0}", (rw.DataBoundItem as CentroAtencion).Domicilio);
                    sw.WriteLine("Telefono: {0}", (rw.DataBoundItem as CentroAtencion).Telefono);
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de Centros de Atencion creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void CentroAtencionGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "DomicilioCol")
                {
                    if (sortAscending)
                        this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e1.Domicilio).CompareTo(e2.Domicilio));
                    else
                        this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e2.Domicilio).CompareTo(e1.Domicilio));
                }
                else
                {
                    if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
                    {
                        if (sortAscending)
                            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e1.LocalidadCentroAtencion.Nombre).CompareTo(e2.LocalidadCentroAtencion.Nombre));
                        else
                            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(criterio, (e1, e2) => (e2.LocalidadCentroAtencion.Nombre).CompareTo(e1.LocalidadCentroAtencion.Nombre));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoCentroAtencion_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoCentroAtencion_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
