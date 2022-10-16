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
    public partial class FrmVacunaBusq : FormBase
    {
        public FrmVacunaBusq()
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

        private void TipoVacunaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.TipoVacunatxt.Enabled = this.TipoVacunaChk.Checked;
        }

        private void CantidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CantidadTxt.Enabled = this.CantidadChk.Checked;
        }

        private void LoteChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LoteTxt.Enabled = this.LoteChk.Checked;
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
            MainView.Instance.Cursor = Cursors.Default;

            string criterio = null;
            bool salir = false;

            if (this.TipoVacunaChk.Checked)
            {
                if ((TipoVacunatxt.Text.Trim() != string.Empty) && this.TipoVacunatxt.SelectedIndex != -1)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cod_tipo_vacuna = {0} ", TipoVacunatxt.SelectedValue);
                    }
                    else
                    {
                        criterio += String.Format("and cod_tipo_vacuna = {0} ", TipoVacunatxt.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro de Tipo de Vacuna esta vacio\nPor favor ingrese el Tipo de Vacuna o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.CantidadChk.Checked)
            {
                if (CantidadTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("cantidad = {0}", Convert.ToInt32(CantidadTxt.Text.Trim()));
                    }
                    else
                    {
                        criterio += String.Format("and cantidad = {0}", Convert.ToInt32(CantidadTxt.Text.Trim()));
                    }
                }
                else
                {
                    MessageBox.Show("El filtro del Cantidad esta vacio\nPor favor ingrese la cantidad o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (this.LoteChk.Checked)
            {
                if (LoteTxt.Text.Trim() != string.Empty)
                {
                    if (criterio == null)
                    {
                        criterio = String.Format("lote like '%{0}%'", LoteTxt.Text);
                    }
                    else
                    {
                        criterio += String.Format("and lote like '%{0}%'", LoteTxt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El filtro del lote esta vacio\nPor favor ingrese lote o desmarque el filtro", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    salir = true;
                }
            }

            if (!salir)
            {
                try
                {
                    var lista = Vacuna.FindAllStatic(criterio, (v1, v2) => (v1.FechaVenc).CompareTo(v2.FechaVenc));
                    
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // invocar Formulario de Listado.
                        FrmVacunaList frm = new FrmVacunaList();
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

        private void FrmVacunaBusq_Load(object sender, EventArgs e)
        {
            //muestra todos los tipos de vacunas
            TipoVacunatxt.DataSource = TipoVacuna.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));
            TipoVacunatxt.SelectedIndex = -1;
        }

        private void FrmVacunaBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FrmVacunaBusq_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }
    }
}
