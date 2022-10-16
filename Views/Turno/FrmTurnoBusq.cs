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

    public partial class FrmTurnoeBusq : FormBase
    {
        public FrmTurnoeBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

            if (perm != null)
            {
                this.BuscarBtn.Enabled = perm.HasAddPerm || perm.HasAddPerm;

                if (!this.BuscarBtn.Enabled && perm.HasViewPerm)
                {
                    this.BuscarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;

            string criterio = null;
            bool salir = false;
            
            //filtros
            if (this.FechaChk.Checked == true)
            {
                int anioTurno = FechaTurnoDtp.Value.Year;
                int mesTurno = FechaTurnoDtp.Value.Month;
                int diaTurno = FechaTurnoDtp.Value.Day;
                DateTime fechaTurno = new DateTime(anioTurno, mesTurno, diaTurno);
                
                if (criterio == null)
                {
                    criterio = String.Format("fecha = '{0}'", fechaTurno);
                }
                else
                {
                    criterio += String.Format(" and fecha = '{0}'", fechaTurno);
                }
            }

            if (this.DniPacienteChk.Checked)
            {
                if (NroDocPacienteTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nro_doc_paciente = {0}", this.NroDocPacienteTxt.Text);
                    }
                    else 
                    {
                        criterio += String.Format(" and nro_doc_paciente = {0}", this.NroDocPacienteTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Nombre esta vacio\nPor favor ingrese el nombre o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (this.CentroChk.Checked)
            {
                if ((CentroAtencionCbo.Text.Trim() != string.Empty) && this.CentroAtencionCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {   
                        criterio = String.Format("cod_centro_a = {0} ", CentroAtencionCbo.SelectedValue);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_centro_a = {0} ", CentroAtencionCbo.SelectedValue);
                    }
                }
                else 
                {
                    MessageBox.Show("El filtro de Centro de atencion esta vacio\nPor favor ingrese el centro o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                try
                {
                    var lista = TurnoVacuna.FindAllStatic(criterio, (t1, t2) => (t1.Fecha).CompareTo(t2.Fecha));
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // invocar Formulario de Listado.
                        FrmTurnoList frm = new FrmTurnoList();

                        frm.ShowListado(lista, this, criterio);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            MainView.Instance.Cursor = Cursors.Default;
            this.Show();
        }

        private void FechaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.FechaTurnoDtp.Enabled = this.FechaChk.Checked;
        }

        private void FrmTurnoeBusq_Load(object sender, EventArgs e)
        {
            CentroAtencionCbo.DataSource = CentroAtencion.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            CentroAtencionCbo.SelectedIndex = -1;
            this.BuscarBtn.Enabled = true;
        }

        private void DniPacienteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NroDocPacienteTxt.Enabled = this.DniPacienteChk.Checked;
        }

        private void CentroChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroAtencionCbo.Enabled = this.CentroChk.Checked;
        }

        private void FrmTurnoeBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmTurnoeBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
