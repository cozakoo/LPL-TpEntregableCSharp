using System;
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
    public partial class FrmCentroAtencionList : FormBase
    {
        private bool sortAscending = false;
        private string _criterio = null;
        private List<CentroAtencion> _listado;

        public FrmCentroAtencionList()
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
            this.CentroAtencionGrd.AutoGenerateColumns = false;
            this.CentroAtencionGrd.DataSource = listado;
            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.CentroAtencionGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.CentroAtencionGrd.Rows[i];
                item.Cells[2].Value = (item.DataBoundItem as CentroAtencion).Domicilio;
                item.Cells[3].Value = (item.DataBoundItem as CentroAtencion).LocalidadCentroAtencion.Nombre;
            }
        }

        private void CentroAtencionGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.CentroAtencionGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmCentroAtencionAM frm = new FrmCentroAtencionAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarCentroAtencion(this, (this.CentroAtencionGrd.SelectedRows[0].DataBoundItem as CentroAtencion));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = CentroAtencionGrd.SelectedRows[0].Index;
                this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => e1.Id.CompareTo(e2.Id));
                CentroAtencionGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Centro de atención actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CentroAtencionGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "DomicilioCol")
                {
                    if (sortAscending)
                        this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.Domicilio).CompareTo(e2.Domicilio));
                    else
                        this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.Domicilio).CompareTo(e1.Domicilio));
                }
                else
                {
                    if (CentroAtencionGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
                    {
                        if (sortAscending)
                            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e1.LocalidadCentroAtencion.Nombre).CompareTo(e2.LocalidadCentroAtencion.Nombre));
                        else
                            this.CentroAtencionGrd.DataSource = CentroAtencion.FindAllStatic(_criterio, (e1, e2) => (e2.LocalidadCentroAtencion.Nombre).CompareTo(e1.LocalidadCentroAtencion.Nombre));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmCentroAtencionList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmCentroAtencionList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}