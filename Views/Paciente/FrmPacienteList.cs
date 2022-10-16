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
    public partial class FrmPacienteList : FormBase
    {
        private string _criterio = null;
        private List<Paciente> _listado;

        public FrmPacienteList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowListado(List<Paciente> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.PacientesGrd.AutoGenerateColumns = false;
            this.PacientesGrd.DataSource = listado;
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
            for (int i = 0; i < this.PacientesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.PacientesGrd.Rows[i];
                item.Cells[5].Value = (item.DataBoundItem as Paciente).LocalidadPaciente.Nombre;
            }
        }

        private void PacientesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.PacientesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmPacienteAM frm = new FrmPacienteAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarPaciente(this, (this.PacientesGrd.SelectedRows[0].DataBoundItem as Paciente));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = PacientesGrd.SelectedRows[0].Index;
                this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                PacientesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Paciente actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = false;

        private void PacientesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (PacientesGrd.Columns[e.ColumnIndex].Name == "ApellidoCol")
            {
                if (sortAscending)
                {
                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e1.Apellido).CompareTo(e2.Apellido));
                }
                else
                {
                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e2.Apellido).CompareTo(e1.Apellido));
                }
            }
            else
            {
                if (PacientesGrd.Columns[e.ColumnIndex].Name == "NombresCol")
                {
                    if (sortAscending)
                    {
                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e1.Nombres).CompareTo(e2.Nombres));
                    }
                    else
                    {
                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e2.Nombres).CompareTo(e1.Nombres));
                    }
                }
                else
                {
                    if (PacientesGrd.Columns[e.ColumnIndex].Name == "DniCol")
                    {
                        if (sortAscending)
                        {
                            this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e1.NroDocumento).CompareTo(e2.NroDocumento));
                        }
                        else
                        {
                            this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e2.NroDocumento).CompareTo(e1.NroDocumento));
                        }
                    }
                    else
                    {
                        if (PacientesGrd.Columns[e.ColumnIndex].Name == "DomicilioCol")
                        {
                            if (sortAscending)
                            {
                                this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e1.Domicilio).CompareTo(e2.Domicilio));
                            }
                            else
                            {
                                this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e2.Domicilio).CompareTo(e1.Domicilio));
                            }
                        }
                        else
                        {
                            if (PacientesGrd.Columns[e.ColumnIndex].Name == "LocCol")
                            {
                                if (sortAscending)
                                {
                                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e1.LocalidadPaciente.Nombre).CompareTo(e2.LocalidadPaciente.Nombre));
                                }
                                else
                                {
                                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(_criterio, (e1, e2) => (e2.LocalidadPaciente.Nombre).CompareTo(e1.LocalidadPaciente.Nombre));
                                }
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmPacienteList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmPacienteList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}

   