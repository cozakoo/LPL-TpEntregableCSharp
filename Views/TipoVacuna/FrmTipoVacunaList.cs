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
    public partial class FrmTipoVacunaList : FormBase
    {
        private string _criterio = null;
        private List<TipoVacuna> _listado;

        public FrmTipoVacunaList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowListado(List<TipoVacuna> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TipoVacunaGrd.AutoGenerateColumns = false;
            this.TipoVacunaGrd.DataSource = listado;
            //this.PacientesGrd.DataSource =  Paciente.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoVacunaGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TipoVacunaGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTipoVacunaAM frm = new FrmTipoVacunaAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTipoVacuna(this, (this.TipoVacunaGrd.SelectedRows[0].DataBoundItem as TipoVacuna));
            }
        }
 
        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TipoVacunaGrd.SelectedRows[0].Index;
                this.TipoVacunaGrd.DataSource = TipoVacuna.FindAllStatic(_criterio, (e1, e2) => e1.Nombre.CompareTo(e2.Nombre));
                TipoVacunaGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Tipo de Vacuna actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = false;

        private void TipoVacunaGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (TipoVacunaGrd.Columns[e.ColumnIndex].Name == "NombreCol")
            {
                if (sortAscending)
                {
                    this.TipoVacunaGrd.DataSource = TipoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Nombre).CompareTo(e2.Nombre));
                }
                else
                {
                    this.TipoVacunaGrd.DataSource = TipoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Nombre).CompareTo(e1.Nombre));
                }
            }
            else
            {
                if (TipoVacunaGrd.Columns[e.ColumnIndex].Name == "DosisCol")
                {
                    if (sortAscending)
                    {
                        this.TipoVacunaGrd.DataSource = TipoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.CantDosis).CompareTo(e2.CantDosis));
                    }
                    else
                    {
                        this.TipoVacunaGrd.DataSource = TipoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.CantDosis).CompareTo(e1.CantDosis));
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void TipoVacunaGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.TipoVacunaGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.TipoVacunaGrd.Rows[i];
                item.Cells[0].Value = (item.DataBoundItem as TipoVacuna).Nombre;
                item.Cells[1].Value = (item.DataBoundItem as TipoVacuna).CantDosis;
            }

        }

        private void FrmTipoVacunaList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmTipoVacunaList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
