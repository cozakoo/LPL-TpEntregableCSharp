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
    [Permiso(ClaseBaseForm="Paciente", FuncionPermiso = "AltaPaciente,ModificaPaciente,ConsultaPaciente", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    public partial class FrmPacienteAM : FormBase
    {
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Paciente _paciente_modif = null;
        private string PacienteLog = "";

        public FrmPacienteAM()
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
            this.LocalidadCbo.DataSource =  Localidad.FindAllStatic(null, (loc1, loc2) => loc1.Nombre.CompareTo(loc2.Nombre));

            //this.LocalidadCbo.DataSource = ORMDB<Localidad>.FindAll(null);
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
                    this.Text = "Ingreso de nuevo paciente...";
                    this.LocalidadCbo.SelectedIndex = -1;
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de paciente...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de paciente...";
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
            Paciente paciente = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog="";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                paciente = new Paciente();
                operacionLog = "ALTA";
                // cargar la info de la paciente antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                paciente = _paciente_modif;
                this.DniTxt.Enabled = false;
                detalleLog = "OBJ-Antes:" + PacienteLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }


            if (verificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                paciente.Apellido = ApellidoTxt.Text;
                paciente.Nombres = NombresTxt.Text;
                paciente.NroDocumento = Convert.ToInt32(DniTxt.Text.Trim());
                paciente.FechaNac = FechaNacDtp.Value;
                paciente.Domicilio = DomicilioTxt.Text;
                paciente.CodPostal = Convert.ToInt32(LocalidadCbo.SelectedValue);
                paciente.DeRiesgo = DeRiesgoChk.Checked;
                paciente.Observaciones = ObservacionesTxt.Text;
                paciente.Telefono = TelefonoTxt.Text;
                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(paciente);
                // intentar guardar en la Base de datos.
                try
                {
                    paciente.SaveObj();
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
                        DoCompleteOperationForm(paciente, new EventArgDom { ObjProcess = paciente, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(paciente, new EventArgDom { ObjProcess = paciente, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
                }

                if (this.InvokerForm != null)
                {
                    InvokerForm.Reload();
                }
                MainView.Instance.Cursor = Cursors.Default;
                this.Close();
            }
        }

        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarPaciente(FormBase Invoker, Paciente Pac_modif)
        {
            ShowInfoPacienteInForm(Pac_modif, Invoker);
        }
        public void ShowModificarPaciente(Paciente Pac_modif)
        {
            ShowInfoPacienteInForm(Pac_modif, null);
        }
        private void ShowInfoPacienteInForm(Paciente Pac_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _paciente_modif = Pac_modif;
            PacienteLog = Newtonsoft.Json.JsonConvert.SerializeObject(_paciente_modif);
            
            // cargar cada control con informacion del paciente....
            //this.ApellidoTxt.Text = Pac_modif.Apellido;
            
            FormBase.ShowDataFromModel(this, Pac_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();
        }
        public void ShowIngresoPaciente(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoPaciente()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmPacienteAM_Deactivate(object sender, EventArgs e)
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

        private void FechaNacDtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = FechaNacDtp.Value;

            //si es menor
            if (DateTime.Now.Year - fecha.Year > 18)
            {
                errorProvider1.SetError(FechaNacDtp, "");
            }
            else
            {
                errorProvider1.SetError(FechaNacDtp, "No se puede ingresar pacientes que sean menores de edad");
            }
            FechaNacDtp.Focus();
        }

        private bool verificarCamposObligatorios()
        {

            if (ApellidoTxt.Text.Trim() != string.Empty)
            {
                if (NombresTxt.Text.Trim() != string.Empty)
                {
                    if (DniTxt.Text.Trim() != string.Empty)
                    {
                        if (DomicilioTxt.Text.Trim() != string.Empty)
                        {
                            if (LocalidadCbo.Text.Trim() != string.Empty)
                            {
                                if (FechaNacDtp.Value != null)
                                {
                                    if (DateTime.Now.Year - FechaNacDtp.Value.Year > 18)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("El paciente es menor de edad\n\nNo se puede registrar en el sistema", "Error: Es menor de edad...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo de fecha de nacimiento es obligatorio y esta vacio\n\n Por favor ingrese la fecha de nacimiento del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo de localidad es obligatorio y esta vacio\n\n Por favor ingrese la localidad del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo de Domicilio es obligatorio y esta vacio\n\n Por favor ingrese el domicilio del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de DNI es obligatorio y esta vacio\n\n Por favor ingrese el DNI del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo de Nombre es obligatorio y esta vacio\n\nPor favor ingrese el nombre del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo de Apellido es obligatorio y esta vacio\n\n Por favor ingrese el apellido del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        sw.Write("|Modificacion de un Paciente");
                    }
                    else
                    {
                        sw.Write("|Alta de un Paciente");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }

        private void FrmPacienteAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
