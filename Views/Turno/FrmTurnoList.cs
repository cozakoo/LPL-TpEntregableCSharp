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
    public partial class FrmTurnoList : FormBase
    {
        private string _criterio = null;
        private List<TurnoVacuna> _listado;

        public FrmTurnoList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<TurnoVacuna> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.TurnosGrd.AutoGenerateColumns = false;
            this.TurnosGrd.DataSource = listado;
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
            for( int i=0;i<this.TurnosGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.TurnosGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.NroDocumento;
                item.Cells[3].Value = (item.DataBoundItem as TurnoVacuna).Hora.ToString("hh:mm:ss");
                item.Cells[4].Value = (item.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.Nombre;
            }
        }


        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TurnosGrd.SelectedRows[0].Index;
                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => e1.Fecha.CompareTo(e2.Fecha));
                TurnosGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Turno actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TurnosGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TurnosGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTurnoAM frm = new FrmTurnoAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarTurno(this, (this.TurnosGrd.SelectedRows[0].DataBoundItem as TurnoVacuna));
            }
        }

        private bool sortAscending = false;

        private void TurnosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (TurnosGrd.Columns[e.ColumnIndex].Name == "DniCol")
            {
                if (sortAscending)
                {
                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.NroDocPaciente).CompareTo(e2.NroDocPaciente));
                }
                else
                {
                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.NroDocPaciente).CompareTo(e1.NroDocPaciente));
                }
            }
            else
            {
                if (TurnosGrd.Columns[e.ColumnIndex].Name == "fechaCol")
                {
                    if (sortAscending)
                    {
                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Fecha).CompareTo(e2.Fecha));
                    }
                    else
                    {
                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Fecha).CompareTo(e1.Fecha));
                    }
                }
                else
                {
                    if (TurnosGrd.Columns[e.ColumnIndex].Name == "horaCol")
                    {
                        if (sortAscending)
                        {
                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Hora).CompareTo(e2.Hora));
                        }
                        else
                        {
                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Hora).CompareTo(e1.Hora));
                        }
                    }
                    else
                    {
                        if (TurnosGrd.Columns[e.ColumnIndex].Name == "CentroCol")
                        {
                            if (sortAscending)
                            {
                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.CentroAtencionTurnoVacuna.Nombre).CompareTo(e2.CentroAtencionTurnoVacuna.Nombre));
                            }
                            else
                            {
                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.CentroAtencionTurnoVacuna.Nombre).CompareTo(e1.CentroAtencionTurnoVacuna.Nombre));
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmTurnoList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmTurnoList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
