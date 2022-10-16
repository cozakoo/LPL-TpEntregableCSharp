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

    [Permiso(ClaseBaseForm = "Enfermero", FuncionPermiso = "AltaEnfermero,ModificaEnfermero,ConsultaEnfermero", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    public partial class FrmEnfermeroAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Enfermero _enfermero_modif = null;
        private string EnfermeroLog = "";

        public FrmEnfermeroAM()
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
            this.CentroAtencionCbo.DataSource = CentroAtencion.FindAllStatic(null, (ca1, ca2) => ca1.Nombre.CompareTo(ca2.Nombre));
            this.LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre));
            this.LocalidadCbo.SelectedIndex = -1;
            this.CentroAtencionCbo.SelectedIndex = -1;
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
                    this.Text = "Ingreso de nuevo enfermero...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de enfermero...";
                    this.DniTxt.Enabled = false;
                    this.MatriculaTxt.Enabled = false;
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de enfermero...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowModificarEnfermero(FormBase Invoker, Enfermero Enfermero_modif)
        {
            ShowInfoEnfermeroInForm(Enfermero_modif, Invoker);
        }

        public void ShowModificarEnfermero(Enfermero Enfermero_modif)
        {
            ShowInfoEnfermeroInForm(Enfermero_modif, null);
        }

        private void ShowInfoEnfermeroInForm(Enfermero Enfermero_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _enfermero_modif = Enfermero_modif;
            EnfermeroLog = Newtonsoft.Json.JsonConvert.SerializeObject(_enfermero_modif);

            // cargar cada control con informacion del enfermero....
            FormBase.ShowDataFromModel(this, Enfermero_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();
        }

        public void ShowIngresoEnfermero(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoEnfermero()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Enfermero enfermero = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                enfermero = new Enfermero();
                operacionLog = "ALTA";
                // cargar la info de la paciente antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                enfermero = _enfermero_modif;

                detalleLog = "OBJ-Antes:" + EnfermeroLog + " - OBJ-MOD";
            }
            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                enfermero.Apellido = ApellidoTxt.Text;
                enfermero.Nombres = NombresTxt.Text;
                enfermero.Matricula = MatriculaTxt.Text;
                enfermero.NroDocumento = Convert.ToInt32(DniTxt.Text);
                enfermero.Domicilio = DomicilioTxt.Text;
                enfermero.Telefono = TelefonoTxt.Text;
                enfermero.CodPostal = Convert.ToInt32(LocalidadCbo.SelectedValue);
                enfermero.CodCentroAtencion = Convert.ToInt32(CentroAtencionCbo.SelectedValue);

                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(enfermero);
                // intentar guardar en la Base de datos.
                try
                {
                    enfermero.SaveObj();
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
                        DoCompleteOperationForm(enfermero, new EventArgDom { ObjProcess = enfermero, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(enfermero, new EventArgDom { ObjProcess = enfermero, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
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

        private bool VerificarCamposObligatorios()
        {

            if (ApellidoTxt.Text.Trim() != string.Empty)
            {
                if (NombresTxt.Text.Trim() != string.Empty)
                {
                    if (MatriculaTxt.Text.Trim() != string.Empty)
                    {
                        if (DniTxt.Text.Trim() != string.Empty)
                        {
                            if ((LocalidadCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                            {
                                if ((CentroAtencionCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("El campo de Centro de Atencion es obligatorio y esta vacio\n\n Por favor ingrese e Centro de Atencion del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo de localidad es obligatorio y esta vacio\n\n Por favor ingrese la localidad del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo de Dni es obligatorio y esta vacio\n\n Por favor ingrese el DNI del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de Matricula es obligatorio y esta vacio\n\n Por favor ingrese la matricula del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo de Nombre es obligatorio y esta vacio\n\nPor favor ingrese el nombre del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo de Apellido es obligatorio y esta vacio\n\n Por favor ingrese el apellido del enfermero", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmEnfermeroAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default; 
        }

        private void FrmEnfermeroAM_Deactivate(object sender, EventArgs e)
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
                        sw.Write("|Modificacion de un Enfermero");
                    }
                    else
                    {
                        sw.Write("|Alta de un Enfermero");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }
    }
}
           
