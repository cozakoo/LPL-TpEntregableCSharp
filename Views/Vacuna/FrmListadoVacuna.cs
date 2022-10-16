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
using System.Collections;

namespace medicApp.Views
{
    public partial class FrmListadoVacuna : FormBase
    {
        private string criterio = null;

        public FrmListadoVacuna()
        {
            InitializeComponent();
        }
        
        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            this.ExportarBtn.Enabled = Usuario.HasPermiso("Exportar");
        }

        private void FrmListadoVacuna_Load(object sender, EventArgs e)
        {
            
            TipoVacunatxt.DataSource = TipoVacuna.FindAllStatic(null, (t1, t2) => (t1.Nombre).CompareTo(t2.Nombre));
            TipoVacunatxt.SelectedIndex = -1;
            this.VacunasGrd.AutoGenerateColumns = false;
            this.VacunasGrd.DataSource = Vacuna.FindAllStatic(null, (v1, v2) => (v1.Id).CompareTo(v2.Id));               
        }
        
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            criterio = null;
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
                        criterio += String.Format("and lote = '%{0}%'", LoteTxt.Text);
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
                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (t1, t2) => (t1.FechaVenc).CompareTo(t2.FechaVenc));
            }
        }

        private void VacunasGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.VacunasGrd.Rows)
            {
                rw.Cells[3].Value = (rw.DataBoundItem as Vacuna).TipoVacunaVacuna.Nombre;
            }
        }

        private void VacunasGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.VacunasGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmVacunaAM frvac = new FrmVacunaAM();
                Vacuna vac = (this.VacunasGrd.SelectedRows[0].DataBoundItem as Vacuna);
                frvac.ShowModificarVacuna(vac);
            }
        }

        private void tVacunaChk_CheckedChanged(object sender, EventArgs e)
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

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                StreamWriter sw = new StreamWriter(string.Format("{0}",saveFileDialog1.FileName), true);
                sw.WriteLine("LISTADO DE VACUNAS\n");
        
                foreach (DataGridViewRow rw in this.VacunasGrd.Rows)
                {
                    sw.WriteLine("Codigo: {0}", (rw.DataBoundItem as Vacuna).Id);
                    sw.WriteLine("Lote: {0}", (rw.DataBoundItem as Vacuna).Lote);
                    sw.WriteLine("Cantidad: {0}", (rw.DataBoundItem as Vacuna).Cantidad);
                    sw.WriteLine("Fech Vencimiento: {0}", (rw.DataBoundItem as Vacuna).FechaVenc.ToShortDateString());
                    sw.WriteLine("Tipo: {0}", (rw.DataBoundItem as Vacuna).TipoVacunaVacuna.Nombre);
                    sw.WriteLine("\n");
                }
                sw.Close();
                MessageBox.Show("REPORTE CREADO CON EXITO!!!", "Listado de vacuna creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private bool sortAscending = false;

        private void VacunasGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (VacunasGrd.Columns[e.ColumnIndex].Name == "CodCol")
            {
                if (sortAscending)
                {
                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e1.Id).CompareTo(e2.Id));
                }
                else
                {
                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e2.Id).CompareTo(e1.Id));
                }
            }
            else
            {
                if (VacunasGrd.Columns[e.ColumnIndex].Name == "LoteCol")
                {
                    if (sortAscending)
                    {
                        this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e1.Lote).CompareTo(e2.Lote));
                    }
                    else
                    {
                        this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e2.Lote).CompareTo(e1.Lote));
                    }
                }
                else
                {
                    if (VacunasGrd.Columns[e.ColumnIndex].Name == "fechaCol")
                    {
                        if (sortAscending)
                        {
                            this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e1.FechaVenc).CompareTo(e2.FechaVenc));
                        }
                        else
                        {
                            this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e2.FechaVenc).CompareTo(e1.FechaVenc));
                        }
                    }
                    else
                    {
                        if (VacunasGrd.Columns[e.ColumnIndex].Name == "TipoVacunaCol")
                        {
                            if (sortAscending)
                            {
                                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e1.TipoVacunaVacuna.Nombre).CompareTo(e2.TipoVacunaVacuna.Nombre));
                            }
                            else
                            {
                                this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e2.TipoVacunaVacuna.Nombre).CompareTo(e1.TipoVacunaVacuna.Nombre));
                            }
                        }
                        else
                        {
                            if (VacunasGrd.Columns[e.ColumnIndex].Name == "cantidadCol")
                            {
                                if (sortAscending)
                                {
                                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e1.Cantidad).CompareTo(e2.Cantidad));
                                }
                                else
                                {
                                    this.VacunasGrd.DataSource = Vacuna.FindAllStatic(criterio, (e1, e2) => (e2.Cantidad).CompareTo(e1.Cantidad));
                                }
                            }
                        }
                    }
                }
            }
            sortAscending = !sortAscending;
        }

        private void FrmListadoVacuna_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmListadoVacuna_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
