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

    public partial class FrmLocalidadList : FormBase
    {
        private string _criterio = null;
        private List<Localidad> _listado;

        public FrmLocalidadList()
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
            this.LocalidadGrd.AutoGenerateColumns = false;
            this.LocalidadGrd.DataSource = listado;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LocalidadGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.LocalidadGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmLocalidadAM frm = new FrmLocalidadAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarLocalidad(this, (this.LocalidadGrd.SelectedRows[0].DataBoundItem as Localidad));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = LocalidadGrd.SelectedRows[0].Index;
                this.LocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => e1.Id.CompareTo(e2.Id));
                LocalidadGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Localidad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocalidadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.LocalidadGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.LocalidadGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as Localidad).Nombre;
                item.Cells[1].Value = (item.DataBoundItem as Localidad).Id;
            }

        }

        private bool sortAscending = false;

        private void LocalidadGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (LocalidadGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.LocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.LocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (LocalidadGrd.Columns[e.ColumnIndex].Name == "codPostalCol")
                {
                    if (sortAscending)
                    {
                        this.LocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e1.Id).CompareTo(e2.Id));
                    }
                    else
                    {
                        this.LocalidadGrd.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => (e2.Id).CompareTo(e1.Id));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmLocalidadList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmLocalidadList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
