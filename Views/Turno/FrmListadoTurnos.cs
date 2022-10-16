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
    public partial class FrmListadoTurnos : FormBase
    {
        private string criterio = null;

        public FrmListadoTurnos()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;
            bool salir = false;

            if (NroDocPacienteChk.Checked)
            {
                if (NroDocPacienteTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nro_doc_paciente = {0}", Convert.ToInt32(NroDocPacienteTxt.Text));
                    }
                    else
                    {
                        criterio += String.Format(" and nro_doc_paciente = {0}", Convert.ToInt32(NroDocPacienteTxt.Text));
                    }
                }
                else
                {
                    MessageBox.Show("El filtro del numero de Documento esta vacio\nPor favor ingrese el DNI o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (this.LocalidadChk.Checked) 
            {
                if (this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_centro_a in (select codigo from centro_atencion where cod_postal = {0})", (LocalidadCbo.SelectedItem as Localidad).Id);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_centro_a in (select codigo from centro_atencion where cod_postal = {0})", (LocalidadCbo.SelectedItem as Localidad).Id);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Localidad esta vacio\n Por favor ingrese la localidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.EnfermeroChk.Checked)
            {
                if (this.DocEnfermeroTxt.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nro_doc_enfermero = {0}", (DocEnfermeroTxt.SelectedItem as Enfermero).NroDocumento);
                    }
                    else
                    {
                        criterio += String.Format(" and nro_doc_enfermero = {0}", (DocEnfermeroTxt.SelectedItem as Enfermero).NroDocumento);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Enfermero esta vacio\n Por favor ingrese el enfermero o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.CentroChk.Checked)
            {
                if (this.CentroAtencionCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_centro_a = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_centro_a = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Centro esta vacio\n Por favor ingrese el centro o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.VacunaChk.Checked)
            {
                if (this.CentroAtencionCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_vacuna = {0}", (VacunaCbo.SelectedItem as Vacuna).Id);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_vacuna = {0}", (VacunaCbo.SelectedItem as Vacuna).Id);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Vacuna esta vacio\n Por favor ingrese la Vacuna o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (FechaDesdeChk.Checked)
            {
                int anioTurnoDesde = FechaTurnoDesdeDtp.Value.Year;
                int mesTurnoDesde = FechaTurnoDesdeDtp.Value.Month;
                int diaTurnoDesde = FechaTurnoDesdeDtp.Value.Day;
                DateTime fechaTurnoDesde = new DateTime(anioTurnoDesde, mesTurnoDesde, diaTurnoDesde);
                
                if (criterio == null)
                {
                    criterio = String.Format("fecha >= '{0}'", fechaTurnoDesde);
                }
                else
                {
                    criterio += String.Format(" and fecha >= '{0}'", fechaTurnoDesde);
                }
            }

            if (FechaHastaChk.Checked)
            {
                int anioTurnoHasta = FechaTurnoDesdeDtp.Value.Year;
                int mesTurnoHasta = FechaTurnoDesdeDtp.Value.Month;
                int diaTurnoHasta = FechaTurnoDesdeDtp.Value.Day;
                DateTime fechaTurnoHasta = new DateTime(anioTurnoHasta, mesTurnoHasta, diaTurnoHasta);

                if (criterio == null)
                {
                    criterio = String.Format("fecha <= '{0}'", fechaTurnoHasta);
                }
                else
                {
                    criterio += String.Format(" and fecha <= '{0}'", fechaTurnoHasta);
                }
            }

            if (HoraDesdeChk.Checked)
            {
                int horaDesde = Convert.ToInt32(HoraDesdetxt.Value);
                int minutoDesde = Convert.ToInt32(MinutoDesdetxt.Value);
                DateTime horarioDesde = new DateTime(2001, 1, 1, horaDesde, minutoDesde, 0);

                if (criterio == null)
                {
                    criterio = String.Format("hora >= '{0}'", horarioDesde);
                }
                else
                {
                    criterio += String.Format(" and hora >= '{0}'", horarioDesde);
                }
            }

            if (HoraHastaChk.Checked)
            {
                int horaHasta = Convert.ToInt32(HoraHastatxt.Value);
                int minutoHasta = Convert.ToInt32(MinutoHastatxt.Value);
                DateTime horarioHasta = new DateTime(2001, 1, 1, horaHasta, minutoHasta, 0);

                if (criterio == null)
                {
                    criterio = String.Format("hora <= '{0}'", horarioHasta);
                }
                else
                {
                    criterio += String.Format(" and hora <= '{0}'", horarioHasta);
                }
            }
            
            if (NroDosisChk.Checked)
            {
                if (this.Dosistxt.Value != 0)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nro_dosis = {0}", Dosistxt.Value);
                    }
                    else
                    {
                        criterio = String.Format(" and nro_dosis = {0}", Dosistxt.Value);
                    }
                }
                else
                {
                    MessageBox.Show("El Nro Dosis no puede ser 0", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (asistioChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("asistio = {0}", true);
                }
                else
                {
                    criterio += String.Format(" and asistio = {0}", true);
                }
            }

            if (!salir)
            {
                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (p1, p2) => (p1.Fecha).CompareTo(p2.Fecha));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = TurnosGrd.SelectedRows[0].Index;
                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(null, (p1, p2) => (p1.Fecha).CompareTo(p2.Fecha));
                TurnosGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Turno actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE TURNO\n");

                foreach (DataGridViewRow rw in this.TurnosGrd.Rows)
                {
                    sw.WriteLine("Paciente: {0}", (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Nombres);
                    sw.WriteLine("DNI: {0}", (rw.DataBoundItem as TurnoVacuna).NroDocPaciente);
                    sw.WriteLine("Edad: {0}", (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Edad());
                    sw.WriteLine("Vacuna: {0}", (rw.DataBoundItem as TurnoVacuna).VacunaTurnoVacuna.TipoVacunaVacuna.Nombre);
                    sw.WriteLine("Fecha: {0}", (rw.DataBoundItem as TurnoVacuna).Fecha.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Hora: {0}", (rw.DataBoundItem as TurnoVacuna).Hora.ToString("hh:mm"));
                    sw.WriteLine("Enfermero: {0} {0}", (rw.DataBoundItem as TurnoVacuna).EnfermeroTurnoVacuna.Nombres, (rw.DataBoundItem as TurnoVacuna).EnfermeroTurnoVacuna.Apellido);
                    sw.WriteLine("Localidad: {0}", (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre);
                    sw.WriteLine("Centro: {0}", (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.Nombre);
                    sw.WriteLine("Asistio: {0}", (rw.DataBoundItem as TurnoVacuna).Asistio);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de turno creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void FrmListadoTurnos_Load(object sender, EventArgs e)
        {
            LoadComboBox(Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre)), this.LocalidadCbo, addSeleccion: true);

            this.TurnosGrd.AutoGenerateColumns = false;
            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(null, (p1, p2) => (p1.NroDocPaciente).CompareTo(p2.NroDocPaciente));

            DocEnfermeroTxt.DataSource = Enfermero.FindAllStatic(null, (enf1, enf2) => (enf1.Apellido + enf1.Nombres).CompareTo(enf2.Apellido + enf2.Nombres));
            DocEnfermeroTxt.SelectedItem = -1;
            DocEnfermeroTxt.ToString();

            CentroAtencionCbo.DataSource = CentroAtencion.FindAllStatic(null, (cen1, cen2) => (cen1.Nombre).CompareTo(cen2.Nombre));
            CentroAtencionCbo.SelectedIndex = -1;
            CentroAtencionCbo.ToString();

            VacunaCbo.DataSource = Vacuna.FindAllStatic(null, (vac1, vac2) => (vac1.Id).CompareTo(vac2.Id));
            VacunaCbo.SelectedItem = -1;
            VacunaCbo.ToString();
        }

        private void TurnosGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.TurnosGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmTurnoAM frmtur = new FrmTurnoAM();
                frmtur.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                TurnoVacuna tur = (this.TurnosGrd.SelectedRows[0].DataBoundItem as TurnoVacuna);
                frmtur.ShowModificarTurno(tur);

            }
        }

        private void TurnosGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.TurnosGrd.Rows)
            {
                rw.Cells[1].Value = (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Nombres;
                rw.Cells[2].Value = (rw.DataBoundItem as TurnoVacuna).PacienteTurnoVacuna.Edad();
                rw.Cells[3].Value = (rw.DataBoundItem as TurnoVacuna).VacunaTurnoVacuna.TipoVacunaVacuna.Nombre;
                rw.Cells[6].Value = (rw.DataBoundItem as TurnoVacuna).Hora.ToString("hh:mm:ss");
                rw.Cells[8].Value = (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre;
                rw.Cells[9].Value = (rw.DataBoundItem as TurnoVacuna).CentroAtencionTurnoVacuna.Nombre;
            }

        }

        private void NroDocPacienteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NroDocPacienteTxt.Enabled = this.NroDocPacienteChk.Checked;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void NroDosisChk_CheckedChanged(object sender, EventArgs e)
        {
            this.Dosistxt.Enabled = this.NroDosisChk.Checked;
        }

        private void EnfermeroChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DocEnfermeroTxt.Enabled = this.EnfermeroChk.Checked;
        }

        private void CentroChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroAtencionCbo.Enabled = this.CentroChk.Checked;
        }

        private void VacunaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.VacunaCbo.Enabled = this.VacunaChk.Checked;
        }

        private void FechaDesdeChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaTurnoDesdeDtp.Enabled = this.FechaDesdeChk.Checked;
        }

        private void FechaHastaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaTurnoHastaDtp.Enabled = this.FechaHastaChk.Checked;
        }

        private void HoraDesdeChk_CheckedChanged(object sender, EventArgs e)
        {
            this.HoraDesdetxt.Enabled = this.HoraDesdeChk.Checked;
            this.MinutoDesdetxt.Enabled = this.HoraDesdeChk.Checked;
        }

        private void HoraHastaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.HoraHastatxt.Enabled = this.HoraHastaChk.Checked;
            this.MinutoHastatxt.Enabled = this.HoraHastaChk.Checked;
        }

        private bool sortAscending = false;

        private void TurnosGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (TurnosGrd.Columns[e.ColumnIndex].Name == "DniCol")
            {
                if (sortAscending)
                {
                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.NroDocPaciente).CompareTo(e2.NroDocPaciente));
                }
                else
                {
                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.NroDocPaciente).CompareTo(e1.NroDocPaciente));
                }
            }
            else
            {
                if (TurnosGrd.Columns[e.ColumnIndex].Name == "PacienteNombreCol")
                {
                    if (sortAscending)
                    {
                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.PacienteTurnoVacuna.Nombres).CompareTo(e2.PacienteTurnoVacuna.Nombres));
                    }
                    else
                    {
                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.PacienteTurnoVacuna.Nombres).CompareTo(e1.PacienteTurnoVacuna.Nombres));
                    }
                }
                else
                {
                    if (TurnosGrd.Columns[e.ColumnIndex].Name == "EdadCol")
                    {
                        if (sortAscending)
                        {
                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.PacienteTurnoVacuna.Edad()).CompareTo(e2.PacienteTurnoVacuna.Edad()));
                        }
                        else
                        {
                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.PacienteTurnoVacuna.Edad()).CompareTo(e1.PacienteTurnoVacuna.Edad()));
                        }
                    }
                    else 
                    {
                        if (TurnosGrd.Columns[e.ColumnIndex].Name == "VacunaCol")
                        {
                            if (sortAscending)
                            {
                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.VacunaTurnoVacuna.Lote).CompareTo(e2.VacunaTurnoVacuna.Lote));
                            }
                            else
                            {
                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.VacunaTurnoVacuna.Lote).CompareTo(e1.VacunaTurnoVacuna.Lote));
                            }
                        }
                        else
                        {
                            if (TurnosGrd.Columns[e.ColumnIndex].Name == "DosisCol")
                            {
                                if (sortAscending)
                                {
                                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.VacunaTurnoVacuna.Cantidad).CompareTo(e2.VacunaTurnoVacuna.Cantidad));
                                }
                                else
                                {
                                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.VacunaTurnoVacuna.Lote).CompareTo(e1.VacunaTurnoVacuna.Lote));
                                }
                            }
                            else
                            {
                                if (TurnosGrd.Columns[e.ColumnIndex].Name == "fechaCol")
                                {
                                    if (sortAscending)
                                    {
                                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.Fecha).CompareTo(e2.Fecha));
                                    }
                                    else
                                    {
                                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.Fecha).CompareTo(e1.Fecha));
                                    }
                                }
                                else 
                                {
                                    if (TurnosGrd.Columns[e.ColumnIndex].Name == "horaCol")
                                    {
                                        if (sortAscending)
                                        {
                                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.Hora).CompareTo(e2.Hora));
                                        }
                                        else
                                        {
                                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.Hora).CompareTo(e1.Hora));
                                        }
                                    }
                                    else
                                    {
                                        if (TurnosGrd.Columns[e.ColumnIndex].Name == "EnfermeroCol")
                                        {
                                            if (sortAscending)
                                            {
                                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.EnfermeroTurnoVacuna.Apellido + e1.EnfermeroTurnoVacuna.Nombres).CompareTo(e2.EnfermeroTurnoVacuna.Apellido + e2.EnfermeroTurnoVacuna.Nombres));
                                            }
                                            else
                                            {
                                                this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.EnfermeroTurnoVacuna.Apellido + e2.EnfermeroTurnoVacuna.Nombres).CompareTo(e1.EnfermeroTurnoVacuna.Apellido + e1.EnfermeroTurnoVacuna.Nombres));
                                            }
                                        }
                                        else
                                        {
                                            if (TurnosGrd.Columns[e.ColumnIndex].Name == "localidadCol")
                                            {
                                                if (sortAscending)
                                                {
                                                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre).CompareTo(e2.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre));
                                                }
                                                else
                                                {
                                                    this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre).CompareTo(e1.CentroAtencionTurnoVacuna.LocalidadCentroAtencion.Nombre));
                                                }
                                            }
                                            else
                                            {
                                                if (TurnosGrd.Columns[e.ColumnIndex].Name == "CentroCol")
                                                {
                                                    if (sortAscending)
                                                    {
                                                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.CentroAtencionTurnoVacuna.Nombre).CompareTo(e2.CentroAtencionTurnoVacuna.Nombre));
                                                    }
                                                    else
                                                    {
                                                        this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.CentroAtencionTurnoVacuna.Nombre).CompareTo(e1.CentroAtencionTurnoVacuna.Nombre));
                                                    }
                                                }
                                                else
                                                {
                                                    if (TurnosGrd.Columns[e.ColumnIndex].Name == "asistioCol")
                                                    {
                                                        if (sortAscending)
                                                        {
                                                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e1.Asistio).CompareTo(e2.Asistio));
                                                        }
                                                        else
                                                        {
                                                            this.TurnosGrd.DataSource = TurnoVacuna.FindAllStatic(criterio, (e1, e2) => (e2.Asistio).CompareTo(e1.Asistio));
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

        private void FrmListadoTurnos_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoTurnos_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
