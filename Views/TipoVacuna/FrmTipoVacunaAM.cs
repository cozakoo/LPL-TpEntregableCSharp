using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using medicApp.db;
using Newtonsoft;

namespace medicApp.Views 
{

    [Permiso(ClaseBaseForm = "TipoVacuna", FuncionPermiso = "AltaTipoVacuna,ModificaTipoVacuna,ConsultaTipoVacuna", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    public partial class FrmTipoVacunaAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private TipoVacuna _tipoVacuna_modif = null;
        private string TipoVacunaLog = "";

        public FrmTipoVacunaAM()
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
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de nuevo tipo de vacuna...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de tipo de vacuna...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de tipo de vacuna...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            TipoVacuna tipoVacuna = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                tipoVacuna = new TipoVacuna();
                operacionLog = "ALTA";

            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                tipoVacuna = _tipoVacuna_modif;
                detalleLog = "OBJ-Antes:" + TipoVacunaLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }
            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                tipoVacuna.Nombre = NombreTxt.Text;
                tipoVacuna.CantDosis = Convert.ToInt32(CantDosisTxt.Text);

                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(tipoVacuna);

                try
                {
                    tipoVacuna.SaveObj();
                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
                    this.LogActividades();
                }
                catch (Exception ex)
                {
                    errMsj = "Error: " + ex.Message;
                }
                // si esta configurado, al form invoker enviarle evento de operacion completa
                if (DoCompleteOperationForm != null)
                {
                    if (errMsj == "")
                        DoCompleteOperationForm(tipoVacuna, new EventArgDom { ObjProcess = tipoVacuna, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(tipoVacuna, new EventArgDom { ObjProcess = tipoVacuna, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
                }

                if (this.InvokerForm != null)
                {
                    InvokerForm.Reload();
                }
                MainView.Instance.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        sw.Write("|Modificacion de un Tipo de Vacuna");
                    }
                    else
                    {
                        sw.Write("|Alta de un Tipo de Vacuna");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }

        private void FrmTipoVacunaAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FrmTipoVacunaAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
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

        private void StringLinea_Numerot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool VerificarCamposObligatorios()
        {
            if (NombreTxt.Text.Trim() != string.Empty)
            {
                if (CantDosisTxt.Text.Trim() != string.Empty)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El campo de cantidad de dosis es obligatorio y esta vacio\n\nPor favor ingrese el nombre del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo de Nombre es obligatorio y esta vacio\n\nPor favor ingrese el nombre del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CantDosisTxt.Value == 0)
            {
                MessageBox.Show("La cantidad de dosis no puede ser cero", "Error: Campo obligatorio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public void ShowModificarTipoVacuna(FormBase Invoker, TipoVacuna tipoVacuna_modif)
        {
            ShowInfoTipoVacunaInForm(tipoVacuna_modif, Invoker);
        }

        public void ShowModificarTipoVacuna(TipoVacuna tipoVacuna_modif)
        {
            ShowInfoTipoVacunaInForm(tipoVacuna_modif, null);
        }

        private void ShowInfoTipoVacunaInForm(TipoVacuna tipoVacuna_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _tipoVacuna_modif = tipoVacuna_modif;
            TipoVacunaLog = Newtonsoft.Json.JsonConvert.SerializeObject(_tipoVacuna_modif);
            FormBase.ShowDataFromModel(this, tipoVacuna_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();
        }

        public void ShowIngresoTipoVacuna(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoTipoVacuna()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
    }
}
