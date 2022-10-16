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
     [Permiso(ClaseBaseForm = "Localidad", FuncionPermiso = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad", RolUsuario = "administrador,operadorLocalidad,consulta,operador")]
    public partial class FrmLocalidadAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Localidad _localidad_modif = null;
        private string LocalidadLog = "";
        public FrmLocalidadAM()
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

        private void FrmpLocalidadAM_Load(object sender, EventArgs e)
        {

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
                    this.Text = "Ingreso de nueva localidad...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de localidad...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de localidad...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Localidad localidad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;
            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre", "faltan datos..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }


            if (OperacionForm == FrmOperacion.frmAlta)
            {
                localidad = new Localidad();
                operacionLog = "ALTA";
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                localidad = _localidad_modif;
                detalleLog = "OBJ-Antes:" + LocalidadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }
            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                localidad.Nombre = NombreTxt.Text;
                localidad.Id = Convert.ToInt32(CodPostalTxt.Text);
                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(localidad);
                // intentar guardar en la Base de datos.
                try
                {
                    localidad.SaveObj();
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
                        DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
                }

                if (this.InvokerForm != null)
                {
                    InvokerForm.Reload();
                }
                MainView.Instance.Cursor = Cursors.Default;
                this.Close();

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

        private void StringLinea_Numerot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ShowModificarLocalidad(FormBase Invoker, Localidad Loc_modif)
        {
            ShowInfoLocalidadInForm(Loc_modif, Invoker);
        }
        public void ShowModificarLocalidad(Localidad Pac_modif)
        {
            ShowInfoLocalidadInForm(Pac_modif, null);
        }
        private void ShowInfoLocalidadInForm(Localidad Loc_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _localidad_modif = Loc_modif;
            LocalidadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_localidad_modif);
            FormBase.ShowDataFromModel(this, Loc_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();
        }

        public void ShowIngresoLocalidad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoLocalidad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmLocalidadAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificarCamposObligatorios()
        {
            if (NombreTxt.Text.Trim() != string.Empty)
            {
                if (CodPostalTxt.Text.Trim() != string.Empty)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El campo Codigo postal es obligatorio y esta vacio\n\n Por favor ingrese el código postal", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo de Nombre es obligatorio y está vacío\n\nPor favor ingrese el nombre de la localidad", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                        sw.Write("|Modificacion de una Localidad");
                    }
                    else
                    {
                        sw.Write("|Alta de una Localidad");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }

        private void FrmLocalidadAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
