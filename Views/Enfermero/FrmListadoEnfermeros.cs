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
    public partial class FrmListadoEnfermeros : FormBase
    {
        private string criterio = null;

        public FrmListadoEnfermeros()
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

        private void FrmListadoEnfermeros_Load(object sender, EventArgs e)
        {
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.ValueMember = "Id";

            this.CentroAtencionCbo.DisplayMember = "Nombre";
            this.CentroAtencionCbo.ValueMember = "Codigo";

            this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
            this.CentroAtencionCbo.DataSource = ORMDB<CentroAtencion>.FindAll(null);

            this.EnfermeroGrd.AutoGenerateColumns = false;
            this.EnfermeroGrd.DataSource = ORMDB<Enfermero>.FindAll(null);

        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = LocalidadChk.Checked;
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;
            bool salir = false;
            
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

            if (this.LocalidadChk.Checked)
            {
                if (this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = "cod_postal= " + LocalidadCbo.SelectedValue;
                    }
                    else
                    {
                        criterio += " and cod_postal = " + LocalidadCbo.SelectedValue;
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Localidad esta vacio\nPor favor ingrese la localid o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (this.CentroAtencionChk.Checked)
            {
                if (this.CentroAtencionCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_centro_a = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                    else
                    {
                        criterio += String.Format("and cod_centro_a = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Centro de Atencion esta vacio\nPor favor ingrese el Centro de Atencion o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (!salir)
            {
                this.EnfermeroGrd.AutoGenerateColumns = false;
                this.EnfermeroGrd.DataSource = ORMDB<Enfermero>.FindAll(criterio);
            }
        }

        private void EnfermeroGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.EnfermeroGrd.Rows)
            {
                rw.Cells[4].Value = (rw.DataBoundItem as Enfermero).LocalidadEnfermero.Nombre;
                rw.Cells[5].Value = (rw.DataBoundItem as Enfermero).CentroAtencionEnfermero.Nombre;
            }
        }

        public void ShowListar()
        {
            this.Show();
        }

        private void EspecialidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroAtencionCbo.Enabled = this.CentroAtencionChk.Checked;
        }

        private void EnfermeroGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.EnfermeroGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmEnfermeroAM frenf  = new FrmEnfermeroAM();
                frenf.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                Enfermero enf = (this.EnfermeroGrd.SelectedRows[0].DataBoundItem as Enfermero);
                frenf.ShowModificarEnfermero(enf);
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = EnfermeroGrd.SelectedRows[0].Index;
                this.EnfermeroGrd.DataSource = Paciente.FindAllStatic(null, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                EnfermeroGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Paciente actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(string.Format("{0}", saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE ENFERMEROS\n");

                foreach (DataGridViewRow rw in this.EnfermeroGrd.Rows)
                {
                    sw.WriteLine("{0}", (rw.DataBoundItem as Enfermero).NroDocumento);
                    sw.WriteLine((rw.DataBoundItem as Enfermero).Nombres + " " + (rw.DataBoundItem as Enfermero).Apellido);
                    sw.WriteLine("Matricula: {0}", (rw.DataBoundItem as Enfermero).Matricula);
                    sw.WriteLine("Domiciio:  {0}", (rw.DataBoundItem as Enfermero).Domicilio);
                    sw.WriteLine("Telefono:  {0}", (rw.DataBoundItem as Enfermero).Telefono);
                    sw.WriteLine("{0}", (rw.DataBoundItem as Enfermero).LocalidadEnfermero.Nombre);
                    sw.WriteLine("\n");
                }

                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de enfermeros creado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sortAscending = true;

        private void EnfermeroGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "MatriculaCol")
            {
                if (sortAscending)
                {
                    this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.Matricula).CompareTo(e2.Matricula));
                }
                else
                {
                    this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.Matricula).CompareTo(e1.Matricula));
                }
            }
            else
            {
                if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "DniCol")
                {
                    if (sortAscending)
                    {
                        this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.NroDocumento).CompareTo(e2.NroDocumento));
                    }
                    else
                    {
                        this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.NroDocumento).CompareTo(e1.NroDocumento));
                    }
                }
                else
                {
                    if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "ApellidoCol")
                    {
                        if (sortAscending)
                        {
                            this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.Apellido).CompareTo(e2.Apellido));
                        }
                        else
                        {
                            this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.Apellido).CompareTo(e1.Apellido));
                        }
                    }
                    else
                    {
                        if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "NombresCol")
                        {
                            if (sortAscending)
                            {
                                this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.Nombres).CompareTo(e2.Nombres));
                            }
                            else
                            {
                                this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.Nombres).CompareTo(e1.Nombres));
                            }
                        }
                        else
                        {
                            if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "LocCol")
                            {
                                if (sortAscending)
                                {
                                    this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.LocalidadEnfermero.Nombre).CompareTo(e2.LocalidadEnfermero.Nombre));
                                }
                                else
                                {
                                    this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.LocalidadEnfermero.Nombre).CompareTo(e1.LocalidadEnfermero.Nombre));
                                }
                            }
                            else
                            {
                                if (EnfermeroGrd.Columns[e.ColumnIndex].Name == "CenCol")
                                {
                                    if (sortAscending)
                                    {
                                        this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e1.CentroAtencionEnfermero.Nombre).CompareTo(e2.CentroAtencionEnfermero.Nombre));
                                    }
                                    else
                                    {
                                        this.EnfermeroGrd.DataSource = Enfermero.FindAllStatic(criterio, (e1, e2) => (e2.CentroAtencionEnfermero.Nombre).CompareTo(e1.CentroAtencionEnfermero.Nombre));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoEnfermeros_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoEnfermeros_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
