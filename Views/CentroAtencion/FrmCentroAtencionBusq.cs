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
    public partial class FrmCentroAtencionBusq : FormBase
    {
        public FrmCentroAtencionBusq()
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

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LocalidadCbo.Enabled = this.LocalidadChk.Checked;
        }

        private void StringLineaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmCentroAtencionBusq_Load(object sender, EventArgs e)
        {
            //muestra todos las localidades
            LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            LocalidadCbo.SelectedIndex = -1;
            this.BuscarBtn.Enabled = true;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;

            string criterio = null;
            bool salir = false;

            if (this.NombreChk.Checked)
            {
                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("nombre like '%{0}%'", (NombreTxt.Text.Trim()));
                    }
                    else
                    {
                        criterio += String.Format(" and nombre like '%{0}%'", (NombreTxt.Text.Trim()));
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
                    MessageBox.Show("El filtro de Localidad esta vacio\nPor favor ingrese la localidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                try
                {
                    var lista = CentroAtencion.FindAllStatic(criterio, (v1, v2) => (v1.Id).CompareTo(v2.Id));

                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Invocar Formulario de Listado.
                        FrmCentroAtencionList frm = new FrmCentroAtencionList();
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

        private void FrmCentroAtencionBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FrmCentroAtencionBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}

 
