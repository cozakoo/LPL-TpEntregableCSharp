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
    public partial class FrmVacunaList : FormBase
    {
        private string _criterio = null;
        private List<Vacuna> _listado;

        public FrmVacunaList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Vacuna> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado; 
            _criterio = criterio;
            this.VacunasGrd.AutoGenerateColumns = false;
            this.VacunasGrd.DataSource = listado;
            //this.PacientesGrd.DataSource =  Paciente.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
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
            for( int i=0;i<this.VacunasGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.VacunasGrd.Rows[i];
                //item.Cells[1].Value = (item.DataBoundItem as Vacuna).FechaVenc
                item.Cells[3].Value = (item.DataBoundItem as Vacuna).TipoVacunaVacuna.Nombre;
            }
        }

        private void VacunasGrd_DoubleClick(object sender, EventArgs e)
        {
            if( this.VacunasGrd.SelectedRows.Count>0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmVacunaAM frm = new FrmVacunaAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarVacuna(this, (this.VacunasGrd.SelectedRows[0].DataBoundItem as Vacuna));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = VacunasGrd.SelectedRows[0].Index;
                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => e1.FechaVenc.CompareTo(e2.FechaVenc));
                VacunasGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Vacuna actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = false;

        private void VacunasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (VacunasGrd.Columns[e.ColumnIndex].Name == "LoteCol")
            {
                if (sortAscending)
                {
                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Lote).CompareTo(e2.Lote));
                }
                else
                {
                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Lote).CompareTo(e1.Lote));
                }
            }
            else
            {
                if (VacunasGrd.Columns[e.ColumnIndex].Name == "fechaCol")
                {
                    if (sortAscending)
                    {
                        this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e1.FechaVenc).CompareTo(e2.FechaVenc));
                    }
                    else
                    {
                        this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e2.FechaVenc).CompareTo(e1.FechaVenc));
                    }
                }
                else
                {
                    if (VacunasGrd.Columns[e.ColumnIndex].Name == "TipoVacunaCol")
                    {
                        if (sortAscending)
                        {
                            this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e1.TipoVacunaVacuna.Nombre).CompareTo(e2.TipoVacunaVacuna.Nombre));
                        }
                        else
                        {
                            this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e2.TipoVacunaVacuna.Nombre).CompareTo(e1.TipoVacunaVacuna.Nombre));
                        }
                    }
                    else
                    {
                        if (VacunasGrd.Columns[e.ColumnIndex].Name == "cantidadCol")
                        {
                            if (sortAscending)
                            {
                                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Cantidad).CompareTo(e2.Cantidad));
                            }
                            else
                            {
                                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Cantidad).CompareTo(e1.Cantidad));
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmVacunaList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FrmVacunaList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }
    }
}
