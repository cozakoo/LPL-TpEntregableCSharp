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
    public partial class FrmLocalidadBusq : FormBase
    {
        public FrmLocalidadBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                if (!this.BuscarBtn.Enabled && perm.HasViewPerm)
                {
                    this.BuscarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }
        private void FrmLocalidadBusq_Load(object sender, EventArgs e)
        {

        }

        private void FrmLocalidadBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void CodPostalChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalTxt.Enabled = this.CodPostalChk.Checked;
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;

            string criterio = null;
            bool salir = false;

            if (this.NombreChk.Checked)
            {
                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nombre like '%{0}%'", NombreTxt.Text);
                    }
                    else
                    {
                        criterio += String.Format("and nombre like '%{0}%'", NombreTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Nombre esta vacio\nPor favor ingrese el nombre o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.CodPostalChk.Checked)
            {
                if (CodPostalTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_postal = {0}", Convert.ToInt32(CodPostalTxt.Text.Trim()));
                    }
                    else
                    {
                        criterio += String.Format("and cod_postal = {0}", Convert.ToInt32(CodPostalTxt.Text.Trim()));
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
                    var lista = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id));
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //invocar Formulario de Listado.
                        FrmLocalidadList frm = new FrmLocalidadList();
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

        private void CodPostalTxt_TextChanged(object sender, EventArgs e)
        {
            if (CodPostalTxt.Text.Trim() != string.Empty && (CodPostalTxt.Text.All(Char.IsDigit)))
            {
                errorProvider2.SetError(CodPostalTxt, "");
            }
            else
            {
                if (!this.CodPostalTxt.Text.All(Char.IsDigit))
                {
                    errorProvider2.SetError(CodPostalTxt, "ingrese solo numeros");
                }
            }
            CodPostalTxt.Focus();
        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {
            if (NombreTxt.Text.Trim() != string.Empty && (NombreTxt.Text.All(Char.IsLetter)))
            {
                errorProvider2.SetError(NombreTxt, "");
            }
            else
            {
                if (!this.NombreTxt.Text.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    errorProvider2.SetError(NombreTxt, "no puede contener numeros ni simbolos en este campo");
                }
            }

            NombreTxt.Focus();
        }

        private void FrmLocalidadBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
