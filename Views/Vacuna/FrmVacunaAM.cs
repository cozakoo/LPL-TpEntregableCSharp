using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using medicApp.db;
using Newtonsoft;
using System.IO;

namespace medicApp.Views
{
     [Permiso(ClaseBaseForm = "Vacuna", FuncionPermiso = "AltaVacuna,ModificaVacuna,ConsultaVacuna", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    public partial class FrmVacunaAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Vacuna _vacuna_modif = null;
        private string VacunaLog = "";

        public FrmVacunaAM()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }

        private void LoadCombos()
        {
            this.TipoVacunaCbo.DataSource = TipoVacuna.FindAllStatic(null, (tp1, tp2) => tp1.Nombre.CompareTo(tp2.Nombre));
        }

        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                LoadCombos();
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nueva vacuna...";
                    this.TipoVacunaCbo.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de vacuna...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de vacuna...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Vacuna vacuna = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                vacuna = new Vacuna();
                operacionLog = "ALTA";
                // cargar la info de la vacuna antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                vacuna = _vacuna_modif;
                detalleLog = "OBJ-Antes:" + VacunaLog + " - OBJ-MOD";
            }

            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                vacuna.Lote = LoteTxt.Text;
                vacuna.FechaVenc = FechaVencDtp.Value;
                vacuna.CodTipoVacuna = Convert.ToInt32 ((TipoVacunaCbo.SelectedItem as TipoVacuna).Id);
                vacuna.Cantidad = Convert.ToInt32(CantidadTxt.Text);
                
                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(vacuna);
                // intentar guardar en la Base de datos.
                try
                {
                    vacuna.SaveObj();
                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
                    LogActividades();
                }
                catch (Exception ex)
                {
                    errMsj = "Error: " + ex.Message;
                }
                // si esta configurado, al form invoker enviarle evento de operacion completa
                if (DoCompleteOperationForm != null)
                {
                    if (errMsj == "")
                        DoCompleteOperationForm(vacuna, new EventArgDom { ObjProcess = vacuna, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(vacuna, new EventArgDom { ObjProcess = vacuna, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
                }

                if (this.InvokerForm != null)
                {
                    InvokerForm.Reload();
                }
                MainView.Instance.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private bool VerificarCamposObligatorios()
        {
            if (FechaVencDtp.Value != null)
            {
                if (DateTime.Now.Year < FechaVencDtp.Value.Year)
                {
                    if ((TipoVacunaCbo.Text.Trim() != string.Empty) && this.TipoVacunaCbo.SelectedIndex != -1)
                    {
                        if (CantidadTxt.Text.Trim() != string.Empty)
                        {
                            if (LoteTxt.Text.Trim() != string.Empty)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("El campo de lote es obligatorio y esta vacio\n\n Por favor ingrese el lote de la vacuna", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo de cantidad es obligatorio y esta vacio\n\n Por favor ingrese la cantidad de la vacuna", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de Tipo Vacuna es obligatorio y esta vacio\n\n Por favor ingrese el Tipo de Vacuna", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser el mismo año que el actual o menor\n\n Por favor ingrese feha valida", "Fecha invalida...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("La fecha de vencimiento es nula\n\n Por favor ingrese feha valida", "Fecha invalida...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ShowModificarVacuna(FormBase Invoker, Vacuna Vacuna_modif)
        {
            ShowInfoVacunaInForm(Vacuna_modif, Invoker);
        }

        public void ShowModificarVacuna(Vacuna Vacuna_modif)
        {
            ShowInfoVacunaInForm(Vacuna_modif, null);
        }

        private void ShowInfoVacunaInForm(Vacuna Vacuna_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _vacuna_modif = Vacuna_modif;
            VacunaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_vacuna_modif);
            // cargar cada control con informacion de la vacuna....
            FormBase.ShowDataFromModel(this, Vacuna_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();

        }

        public void ShowIngresoVacuna(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoVacuna()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FechaVencDtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = FechaVencDtp.Value;

            //si es menor
            if (DateTime.Now.Year < fecha.Year)
            {
                errorProvider1.SetError(FechaVencDtp, "");
            }
            else
            {
                errorProvider1.SetError(FechaVencDtp,"La fecha tiene que ser mayor que el año actual");
            }
            FechaVencDtp.Focus();
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LogActividades()
        {
            string ruta = @"../../../log-de-actividades.txt";

            {
                StreamWriter sw = new StreamWriter(ruta, true);
                {
                    sw.Write(Usuario.UsuarioSys.UsuarioName);

                    if (OperacionForm == FrmOperacion.frmModificacion)
                    {
                        sw.Write("|Modificacion de una Vacuna");
                    }
                    else
                    {
                        sw.Write("|Alta de una Vacuna");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }

        private void FrmVacunaAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmVacunaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
