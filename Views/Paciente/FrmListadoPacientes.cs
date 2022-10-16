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
    public partial class FrmListadoPacientes : FormBase
    {
        private string criterio = null;

        public FrmListadoPacientes()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoPacientes_Load(object sender, EventArgs e)
        {            
            LoadComboBox( Localidad.FindAllStatic(null , (l1,l2)=> l1.Nombre.CompareTo(l2.Nombre)) , this.LocalidadCbo, addSeleccion: true);
                                    
            this.PacientesGrd.AutoGenerateColumns = false;
            this.PacientesGrd.DataSource = Paciente.FindAllStatic(null, (p1,p2)=> (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido+p2.Nombres));
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            bool salir = false;
            criterio = null;

            if (this.LocalidadChk.Checked) 
            {
                if (this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio += String.Format("cod_postal = {0}", LocalidadCbo.SelectedValue);
                    }
                    else
                        criterio += String.Format("and cod_postal = {0}", LocalidadCbo.SelectedValue);
                }
                else
                {
                    MessageBox.Show("El filtro de Localidad esta vacio\n Por favor ingrese la localidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.ApellidoChk.Checked == true)
            {
                if (ApellidoTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("apellido like '%{0}%'", ApellidoTxt.Text);
                    }
                    else
                    {
                        criterio += String.Format("and apellido like '%{0}%'", ApellidoTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Apellido esta vacio\n Por favor ingrese el apellido o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (DeRiesgoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("de_riesgo = '{0}'", DeRiesgoChk.Checked);
                }
                else
                {
                    criterio += String.Format("and de_riesgo = '{0}'", DeRiesgoChk.Checked);
                }
            }

            if (VacunadoChk.Checked)
            {
                if (criterio == null)
                {
                    criterio = String.Format("vacunado = '{0}'", VacunadoChk.Checked);
                }
                else
                {
                    criterio += String.Format("and vacunado = '{0}'", VacunadoChk.Checked);
                }
            }

            if (!salir)
            {
                this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
            }
        }

        private void PacientesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.PacientesGrd.Rows)
            {                
                rw.Cells[3].Value = (rw.DataBoundItem as Paciente).LocalidadPaciente.Nombre;
            }
        }

        private void PacientesGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.PacientesGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmPacienteAM frmpac = new FrmPacienteAM();
                frmpac.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                Paciente pac = (this.PacientesGrd.SelectedRows[0].DataBoundItem as Paciente);
                frmpac.ShowModificarPaciente(pac);
            }
             
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = PacientesGrd.SelectedRows[0].Index;
                this.PacientesGrd.DataSource = Paciente.FindAllStatic(null, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                PacientesGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Paciente actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);

                sw.WriteLine("LISTADO DE PACIENTES\n");

                foreach (DataGridViewRow rw in this.PacientesGrd.Rows)
                {
                    sw.WriteLine("{0}", (rw.DataBoundItem as Paciente).NroDocumento);
                    sw.WriteLine((rw.DataBoundItem as Paciente).Nombres + " " + (rw.DataBoundItem as Paciente).Apellido);
                    sw.WriteLine("{0}", (rw.DataBoundItem as Paciente).FechaNac.ToShortDateString());
                    sw.WriteLine("Direccion: {0}", (rw.DataBoundItem as Paciente).Domicilio);
                    sw.WriteLine("Telefono: {0}", (rw.DataBoundItem as Paciente).Telefono);
                    sw.WriteLine("{0}", (rw.DataBoundItem as Paciente).LocalidadPaciente.Nombre);
                    sw.WriteLine("es de riesgo = {0}", (rw.DataBoundItem as Paciente).DeRiesgo);
                    sw.WriteLine("esta vacunado = {0}", (rw.DataBoundItem as Paciente).Vacunado);
                    sw.WriteLine("OBS: {0}", (rw.DataBoundItem as Paciente).Observaciones);
                    sw.WriteLine("\n");
                }

                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de pacientes creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private bool sortAscending = false;

        private void PacientesGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (PacientesGrd.Columns[e.ColumnIndex].Name == "DniCol")
            {
                if (sortAscending)
                {
                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.NroDocumento).CompareTo(e2.NroDocumento));
                }
                else
                {
                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.NroDocumento).CompareTo(e1.NroDocumento));
                }
            }
            else
            {
                if (PacientesGrd.Columns[e.ColumnIndex].Name == "ApellidoCol")
                {
                    if (sortAscending)
                    {
                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.Apellido).CompareTo(e2.Apellido));
                    }
                    else
                    {
                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.Apellido).CompareTo(e1.Apellido));
                    }
                }
                else
                {
                    if (PacientesGrd.Columns[e.ColumnIndex].Name == "NombresCol")
                    {
                        if (sortAscending)
                        {
                            this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.Nombres).CompareTo(e2.Nombres));
                        }
                        else
                        {
                            this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.Nombres).CompareTo(e1.Nombres));
                        }
                    }
                    else
                    {
                        if (PacientesGrd.Columns[e.ColumnIndex].Name == "LocCol")
                        {
                            if (sortAscending)
                            {
                                this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.LocalidadPaciente.Nombre).CompareTo(e2.LocalidadPaciente.Nombre));
                            }
                            else
                            {
                                this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.LocalidadPaciente.Nombre).CompareTo(e1.LocalidadPaciente.Nombre));
                            }
                        }
                        else
                        {
                            if (PacientesGrd.Columns[e.ColumnIndex].Name == "DeRiesgoCol")
                            {
                                if (sortAscending)
                                {
                                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.DeRiesgo).CompareTo(e2.DeRiesgo));
                                }
                                else
                                {
                                    this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.DeRiesgo).CompareTo(e1.DeRiesgo));
                                }
                            }
                            else
                            {
                                if (PacientesGrd.Columns[e.ColumnIndex].Name == "VacunadoCol")
                                {
                                    if (sortAscending)
                                    {
                                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e1.Vacunado).CompareTo(e2.Vacunado));
                                    }
                                    else
                                    {
                                        this.PacientesGrd.DataSource = Paciente.FindAllStatic(criterio, (e1, e2) => (e2.Vacunado).CompareTo(e1.Vacunado));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoPacientes_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoPacientes_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
