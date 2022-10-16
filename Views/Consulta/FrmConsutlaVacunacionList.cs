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
    public partial class FrmConsutlaVacunacionList : FormBase
    {
        private string _criterio = null;
        private List<TurnoVacuna> _listado;

        public FrmConsutlaVacunacionList()
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
            this.ConsultaGrid.AutoGenerateColumns = false;
            this.ConsultaGrid.DataSource = listado;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ConsultaGrid.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Nombres;
                rw.Cells[2].Value = (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Edad();
                rw.Cells[3].Value = (rw.DataBoundItem as TurnoVacuna).VacunaTurnoVacuna.TipoVacunaVacuna.Nombre;
                rw.Cells[6].Value = (rw.DataBoundItem as TurnoVacuna).Hora.ToString("hh:mm:ss");
                rw.Cells[7].Value = String.Format("{0} {1}", (rw.DataBoundItem as TurnoVacuna).EnfermeroTurnoVacuna.Apellido, (rw.DataBoundItem as TurnoVacuna).EnfermeroTurnoVacuna.Nombres);
                rw.Cells[8].Value = (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre;
                rw.Cells[9].Value = (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.Nombre;
            }
        }

        private bool sortAscending = false;

        private void ConsultaGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ConsultaGrid.Columns[e.ColumnIndex].Name == "DniPacienteCol")
            {
                if (sortAscending)
                {
                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.NroDocPaciente).CompareTo(e2.NroDocPaciente));
                }
                else
                {
                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.NroDocPaciente).CompareTo(e1.NroDocPaciente));
                }
            }
            else
            {
                if (ConsultaGrid.Columns[e.ColumnIndex].Name == "PacienteNombreCol")
                {
                    if (sortAscending)
                    {
                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.PacienteTurnoVacuna.Nombres).CompareTo(e2.PacienteTurnoVacuna.Nombres));
                    }
                    else
                    {
                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.PacienteTurnoVacuna.Nombres).CompareTo(e1.PacienteTurnoVacuna.Nombres));
                    }
                }
                else 
                {
                    if (ConsultaGrid.Columns[e.ColumnIndex].Name == "EdadCol")
                    {
                        if (sortAscending)
                        {
                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.PacienteTurnoVacuna.Edad()).CompareTo(e2.PacienteTurnoVacuna.Edad()));
                        }
                        else
                        {
                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.PacienteTurnoVacuna.Edad()).CompareTo(e1.PacienteTurnoVacuna.Edad()));
                        }
                    }
                    else
                    {
                        if (ConsultaGrid.Columns[e.ColumnIndex].Name == "VacunaCol")
                        {
                            if (sortAscending)
                            {
                                this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre).CompareTo(e2.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre));
                            }
                            else
                            {
                                this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre).CompareTo(e1.VacunaTurnoVacuna.TipoVacunaVacuna.Nombre));
                            }
                        }
                        else 
                        {
                            if (ConsultaGrid.Columns[e.ColumnIndex].Name == "DosisCol")
                            {
                                if (sortAscending)
                                {
                                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.NroDosis).CompareTo(e2.NroDosis));
                                }
                                else
                                {
                                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.NroDosis).CompareTo(e1.NroDosis));
                                }
                            }
                            else
                            {
                                if (ConsultaGrid.Columns[e.ColumnIndex].Name == "FechaCol")
                                {
                                    if (sortAscending)
                                    {
                                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Fecha).CompareTo(e2.Fecha));
                                    }
                                    else
                                    {
                                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Fecha).CompareTo(e1.Fecha));
                                    }
                                }
                                else
                                {
                                    if (ConsultaGrid.Columns[e.ColumnIndex].Name == "horaCol")
                                    {
                                        if (sortAscending)
                                        {
                                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Hora).CompareTo(e2.Hora));
                                        }
                                        else
                                        {
                                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Hora).CompareTo(e1.Hora));
                                        }
                                    }
                                    else
                                    {
                                        if (ConsultaGrid.Columns[e.ColumnIndex].Name == "EnfermeroCol")
                                        {
                                            if (sortAscending)
                                            {
                                                this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.EnfermeroTurnoVacuna.Apellido + e1.EnfermeroTurnoVacuna.Nombres).CompareTo(e2.EnfermeroTurnoVacuna.Apellido + e2.EnfermeroTurnoVacuna.Nombres));
                                            }
                                            else
                                            {
                                                this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.EnfermeroTurnoVacuna.Apellido + e2.EnfermeroTurnoVacuna.Nombres).CompareTo(e1.EnfermeroTurnoVacuna.Apellido + e1.EnfermeroTurnoVacuna.Nombres));
                                            }
                                        }
                                        else
                                        {
                                            if (ConsultaGrid.Columns[e.ColumnIndex].Name == "localidadCol")
                                            {
                                                if (sortAscending)
                                                {
                                                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre).CompareTo(e2.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre));
                                                }
                                                else
                                                {
                                                    this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre).CompareTo(e1.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre));
                                                }
                                            }
                                            else
                                            {
                                                if (ConsultaGrid.Columns[e.ColumnIndex].Name == "CentroCol")
                                                {
                                                    if (sortAscending)
                                                    {
                                                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.CentroAtencionTurnoVacuna.Nombre).CompareTo(e2.CentroAtencionTurnoVacuna.Nombre));
                                                    }
                                                    else
                                                    {
                                                        this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.CentroAtencionTurnoVacuna.Nombre).CompareTo(e1.CentroAtencionTurnoVacuna.Nombre));
                                                    }
                                                }
                                                else 
                                                {
                                                    if (ConsultaGrid.Columns[e.ColumnIndex].Name == "asistioCol")
                                                    {
                                                        if (sortAscending)
                                                        {
                                                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e1.Asistio).CompareTo(e2.Asistio));
                                                        }
                                                        else
                                                        {
                                                            this.ConsultaGrid.DataSource = TurnoVacuna.FindAllStatic(_criterio, (e1, e2) => (e2.Asistio).CompareTo(e1.Asistio));
                                                        }
                                                    }
                                                }
                                            }
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

        private void FrmConsutlaVacunacionList_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmConsutlaVacunacionList_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}