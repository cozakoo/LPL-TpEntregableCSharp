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

namespace medicApp.Views
{
    [Permiso(ClaseBaseForm = "CentroAtencion", FuncionPermiso = "AltaCentroAtencion,ModificaCentroAtencion,ConsultaCentroAtencion", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]       
    
    public partial class FrmCentroAtencionAM : FormBase
    {
            public override event FormEvent DoCompleteOperationForm;
            private CentroAtencion _centroatencion_modif = null;
            private string CentroAtencionLog = "";

            public FrmCentroAtencionAM()
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
                    loadCombos();
                    if (value == FrmOperacion.frmAlta)
                    {
                        this.Text = "Ingreso de nuevo centro de atención...";
                        this.LocalidadCbo.SelectedIndex = -1;
                    }
                    if (value == FrmOperacion.frmModificacion)
                    {
                        this.Text = "Actualizacion de datos de centro de atención...";
                    }
                    if (value == FrmOperacion.frmConsulta)
                    {
                        this.Text = "Consulta de datos de centro de atención...";
                        this.GuardarBtn.Visible = false;
                    }
                }
            }

        private void loadCombos()
        {   
            this.LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre));
        }
        
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            CentroAtencion centroatencion = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;
            
            if (OperacionForm == FrmOperacion.frmAlta)
            {
                centroatencion = new CentroAtencion();
                operacionLog = "ALTA";
                // cargar la info del centro de atención antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                centroatencion = _centroatencion_modif;
                detalleLog = "OBJ-Antes:" + CentroAtencionLog + " - OBJ-MOD";
                this.LocalidadCbo.Enabled = false;
            }

            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }
            
            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                
                centroatencion.Nombre = NombreTxt.Text;
                centroatencion.Domicilio = DireccionTxt.Text;
                centroatencion.Telefono = TelefonoTxt.Text;
                centroatencion.CodPostal = Convert.ToInt32(LocalidadCbo.SelectedValue);

                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(centroatencion);
                // intentar guardar en la Base de datos.
                try
                {
                    centroatencion.SaveObj();
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
                            DoCompleteOperationForm(centroatencion, new EventArgDom { ObjProcess = centroatencion, Status = TipoOperacionStatus.stOK });
                        else
                            DoCompleteOperationForm(centroatencion, new EventArgDom { ObjProcess = centroatencion, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
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

                if (NombreTxt.Text.Trim() != string.Empty)
                {
                    if (DireccionTxt.Text.Trim() != string.Empty)
                    {
                        if ((LocalidadCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("El campo de LOCALIDAD es obligatorio y esta vacio\n\n Por favor ingrese la LOCALIDAD del centro de atención", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de DIRECCION es obligatorio y esta vacio\n\nPor favor ingrese la DIRECCION del centro de atención", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo de NOMBRE es obligatorio y esta vacio\n\nPor favor ingrese el NOMBRE del centro de atención", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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


            private void CancelarBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }


            public void ShowModificarCentroAtencion(FormBase Invoker, CentroAtencion CentroAtencion_modif)
            {
                ShowInfoCentroAtencionInForm(CentroAtencion_modif, Invoker);
            }

            public void ShowModificarCentroAtencion(CentroAtencion CentroAtencion_modif)
            {
                ShowInfoCentroAtencionInForm(CentroAtencion_modif, null);
            }

            private void ShowInfoCentroAtencionInForm(CentroAtencion CentroAtencion_modif, FormBase Invoker)
            {
                this.OperacionForm = FrmOperacion.frmModificacion;
                _centroatencion_modif = CentroAtencion_modif;
                CentroAtencionLog = Newtonsoft.Json.JsonConvert.SerializeObject(_centroatencion_modif);

                // cargar cada control con informacion del enfermero....
                FormBase.ShowDataFromModel(this, CentroAtencion_modif);
                this.InvokerForm = Invoker;
                this.ShowDialog();
            }

            public void ShowIngresoCentroAtencion(FormBase Invoker)
            {
                this.InvokerForm = Invoker;
                this.OperacionForm = FrmOperacion.frmAlta;
                this.ShowDialog();
            }

            public void ShowIngresoCentroAtencion()
            {
                this.InvokerForm = null;
                this.OperacionForm = FrmOperacion.frmAlta;
                this.ShowDialog();
            }

            private void FrmCentroAtencionAM_Activated(object sender, EventArgs e)
            {
                MainView.Instance.Cursor = Cursors.Default;  
            }

            private void FrmCentroAtencionAM_Deactivate(object sender, EventArgs e)
            {
                MainView.Instance.Cursor = Cursors.Default;  
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
                            sw.Write("|Modificacion de un Centro de Atencion");
                        }
                        else
                        {
                            sw.Write("|Alta de un Centro de Atencion");
                        }
                        sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                        sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                    }
                    sw.Close();
                }
            }
    }
}
