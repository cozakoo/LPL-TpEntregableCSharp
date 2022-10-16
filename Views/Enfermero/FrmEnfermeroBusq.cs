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
    public partial class FrmEnfermeroBusq : FormBase
    {
        public FrmEnfermeroBusq()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            
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

            if (this.MatriculaChk.Checked)
            {
                if (MatriculaTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("matricula like '%{0}%'", MatriculaTxt.Text);
                    }
                    else
                    {
                        criterio += String.Format("and matricula like '%{0}%'", MatriculaTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Matricula esta vacio\nPor favor ingrese el nombre o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.CentroChk.Checked)
            {
                if ((CentroCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_centro_a={0} ", CentroCbo.SelectedValue);
                    }
                    else
                    {
                        criterio += String.Format(" and cod_centro_a = {0}", CentroCbo.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro del Centro de Atencion esta vacio\nPor favor ingrese el Centro de Atencion o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                try
                {
                    var lista = Enfermero.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // invocar Formulario de Listado.
                        FrmEnfermeroList frm = new FrmEnfermeroList();
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

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void CentroChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CentroCbo.Enabled = this.CentroChk.Checked;
        }

        private void MatriculaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.MatriculaTxt.Enabled = this.MatriculaChk.Checked;
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


        private void FrmEnfermeroBusq_Load(object sender, EventArgs e)
        {
            //muestra todas las localidades
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null,(loc1,loc2)=>loc1.Nombre.CompareTo(loc2.Nombre));
            LocalidadCbo.SelectedIndex = -1;
            
            //muestra todas los centros de atencion
            CentroCbo.DataSource = CentroAtencion.FindAllStatic(null, (cen1, cen2) => cen1.Nombre.CompareTo(cen2.Nombre));
            CentroCbo.SelectedIndex = -1;
        }

        private void FrmEnfermeroBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void ApellidoTxt_TextChanged(object sender, EventArgs e)
        {
            if (ApellidoTxt.Text.Trim() != string.Empty && (ApellidoTxt.Text.All(Char.IsLetter)))
            {
                errorProvider1.SetError(ApellidoTxt, "");
            }
            else
            {
                if (!this.ApellidoTxt.Text.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    errorProvider1.SetError(ApellidoTxt, "no puede contener numeros ni simbolos en este campo");
                }
            }
            ApellidoTxt.Focus();
        }

        private void DniTxt_TextChanged(object sender, EventArgs e)
        {
            if (DniTxt.Text.Trim() != string.Empty && (DniTxt.Text.All(Char.IsDigit)))
            {
                errorProvider1.SetError(DniTxt, "");
            }
            else
            {
                if (!this.DniTxt.Text.All(Char.IsDigit))
                {
                    errorProvider1.SetError(DniTxt, "ingrese solo numeros");
                }
            }
            DniTxt.Focus();
        }

        private void MatriculaTxt_TextChanged(object sender, EventArgs e)
        {
            if (MatriculaTxt.Text.Trim() != string.Empty && (MatriculaTxt.Text.All(Char.IsLetter) || MatriculaTxt.Text.All(Char.IsDigit)))
            {
                errorProvider1.SetError(NombresTxt, "");
            }
            else
            {
                if (!this.MatriculaTxt.Text.All(c => Char.IsLetter(c) || Char.IsDigit(c)))
                {
                    errorProvider1.SetError(NombresTxt, "no puede contener espacios ni simbolos en este campo");
                }
            }

            NombresTxt.Focus();
        }

        private void NombresTxt_TextChanged(object sender, EventArgs e)
        {
            if (NombresTxt.Text.Trim() != string.Empty && (NombresTxt.Text.All(Char.IsLetter)))
            {
                errorProvider1.SetError(NombresTxt, "");
            }
            else
            {
                if (!this.NombresTxt.Text.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    errorProvider1.SetError(NombresTxt, "no puede contener numeros ni simbolos en este campo");
                }
            }

            NombresTxt.Focus();
        }

        private void FrmEnfermeroBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
