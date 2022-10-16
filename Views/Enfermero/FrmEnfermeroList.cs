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
    public partial class FrmEnfermeroList : FormBase
    {
        private string _criterio = null;
        private List<Enfermero> _listado;
        
        public FrmEnfermeroList()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }
        
        public void ShowListado(List<Enfermero> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.EnfermerosGrd.AutoGenerateColumns = false;
            this.EnfermerosGrd.DataSource = listado;
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
            for( int i=0;i<this.EnfermerosGrd.Rows.Count;++i)
            {
                DataGridViewRow item  = this.EnfermerosGrd.Rows[i];
                item.Cells[5].Value = (item.DataBoundItem as Enfermero).LocalidadEnfermero.Nombre;
                item.Cells[7].Value = (item.DataBoundItem as Enfermero).CentroAtencionEnfermero.Nombre;
            }
        }

        private void EnfermerosGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.EnfermerosGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmEnfermeroAM frm = new FrmEnfermeroAM();

                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarEnfermero(this, (this.EnfermerosGrd.SelectedRows[0].DataBoundItem as Enfermero));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = EnfermerosGrd.SelectedRows[0].Index;
                this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                EnfermerosGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Enfermero actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = true;

        private void EnfermerosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "ApellidoCol")
            {
                if (sortAscending)
                {
                    this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.Apellido).CompareTo(e2.Apellido));
                }
                else
                {
                    this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.Apellido).CompareTo(e1.Apellido));
                }
            } 
            else
            {
                if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "NombresCol")
                {
                    if (sortAscending)
                    {
                        this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.Nombres).CompareTo(e2.Nombres));
                    }
                    else
                    {
                        this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.Nombres).CompareTo(e1.Nombres));
                    }
                }
                else 
                {
                    if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "DniCol")
                    {
                        if (sortAscending)
                        {
                            this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.NroDocumento).CompareTo(e2.NroDocumento));
                        }
                        else
                        {
                            this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.NroDocumento).CompareTo(e1.NroDocumento));
                        }
                    }
                    else
                    {
                        if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "DomicilioCol")
                        {
                            if (sortAscending)
                            {
                                this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.Domicilio).CompareTo(e2.Domicilio));
                            }
                            else
                            {
                                this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.Domicilio).CompareTo(e1.Domicilio));
                            }
                        }
                        else
                        {
                            if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "LocalidadCol")
                            {
                                if (sortAscending)
                                {
                                    this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.LocalidadEnfermero.Nombre).CompareTo(e2.LocalidadEnfermero.Nombre));
                                }
                                else
                                {
                                    this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.LocalidadEnfermero.Nombre).CompareTo(e1.LocalidadEnfermero.Nombre));
                                }
                            }
                            else
                            {
                                if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "MatriculaCol")
                                {
                                    if (sortAscending)
                                    {
                                        this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.Matricula).CompareTo(e2.Matricula));
                                    }
                                    else
                                    {
                                        this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.Matricula).CompareTo(e1.Matricula));
                                    }
                                }
                                else
                                {
                                    if (EnfermerosGrd.Columns[e.ColumnIndex].Name == "CentroCol")
                                    {
                                        if (sortAscending)
                                        {
                                            this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e1.CentroAtencionEnfermero.Nombre).CompareTo(e2.CentroAtencionEnfermero.Nombre));
                                        }
                                        else
                                        {
                                            this.EnfermerosGrd.DataSource = Enfermero.FindAllStatic(_criterio, (e1, e2) => (e2.CentroAtencionEnfermero.Nombre).CompareTo(e1.CentroAtencionEnfermero.Nombre));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }
    }
}
