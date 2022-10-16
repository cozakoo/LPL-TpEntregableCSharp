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

    public partial class FrmPacienteBusq : FormBase
    {
        public FrmPacienteBusq()
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
            
            if (this.NombresChk.Checked)
            {
                if (NombresTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nombres like '%{0}%'", NombresTxt.Text );
                    }
                    else 
                    {
                        criterio += String.Format("and nombres like '%{0}%'", NombresTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Nombre esta vacio\nPor favor ingrese el nombre o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (this.LocalidadChk.Checked)
            {
                if ((LocalidadCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {   
                        criterio = String.Format("cod_postal={0} ", LocalidadCbo.SelectedValue);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_postal = {0}", LocalidadCbo.SelectedValue);
                    }
                }
                else 
                {
                    MessageBox.Show("El filtro de Localidad esta vacio\nPor favor ingrese la localid o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }
            
            if (this.DniChk.Checked)
            {
                if (DniTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nro_documento = {0}", Convert.ToInt32(DniTxt.Text.Trim()));
                    }
                    else
                    {
                        criterio += String.Format("and nro_documento = {0}", Convert.ToInt32(DniTxt.Text.Trim()));
                    }
                }
                else
                {
                    MessageBox.Show("El filtro del numero de Documento esta vacio\nPor favor ingrese el DNI o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                try
                {
                    var lista = Paciente.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // invocar Formulario de Listado.
                        FrmPacienteList frm = new FrmPacienteList();
                        frm.ShowListado(lista, this, criterio);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void DniChk_CheckedChanged(object sender, EventArgs e)
        {
            this.DniTxt.Enabled = this.DniChk.Checked;
        }

        private void NombresChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombresTxt.Enabled = this.NombresChk.Checked;
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

        private void FrmPacienteBusq_Load(object sender, EventArgs e)
        {
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            LocalidadCbo.SelectedIndex = -1;
            this.BuscarBtn.Enabled = true;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void FrmPacienteBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmPacienteBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
