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

    [Permiso(ClaseBaseForm = "Turno", FuncionPermiso = "AltaTurno,ModificaTurno,ConsultaTurno", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    public partial class FrmTurnoAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private TurnoVacuna _turno_modif = null;
        private string TurnoLog = "";

        public FrmTurnoAM()
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

            this.LocalidadCbo.DataSource = Localidad.FindAllStatic(null, (l1, l2) => l1.Nombre.CompareTo(l2.Nombre));
            this.LocalidadCbo.SelectedIndex = -1;
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
                    this.Text = "Ingreso de nuevo Turno...";
                    this.LocalidadCbo.Enabled = false;
                    this.CentroAtencionCbo.Enabled = false;
                    this.EnfermoCbo.Enabled = false;
                    this.FechaTurnoDtp.Enabled = false;
                    this.VacunaCbo.Enabled = false;
                    this.Dosistxt.Enabled = false;
                    this.AsistioChk.Enabled = false;

                    this.Horatxt.Enabled = false;
                    this.minutotxt.Enabled = false;

                    this.GuardarBtn.Enabled = false;
                    this.GuardarBtn.Enabled = false;

                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Turno...";
                    this.NroDocPacienteTxt.Enabled = false;
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Turno...";
                    this.GuardarBtn.Visible = false;
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowModificarTurno(FormBase Invoker, TurnoVacuna Turno_modif)
        {
            ShowInfoTurnoInForm(Turno_modif, Invoker);
        }

        public void ShowModificarTurno(TurnoVacuna Turno_modif)
        {
            ShowInfoTurnoInForm(Turno_modif, null);
        }

        private void ShowInfoTurnoInForm(TurnoVacuna Turno_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _turno_modif = Turno_modif;
            TurnoLog = Newtonsoft.Json.JsonConvert.SerializeObject(_turno_modif);

            // cargar cada control con informacion del enfermero....
            FormBase.ShowDataFromModel(this, Turno_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();
        }

        public void ShowIngresoTurno(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoTurno()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            TurnoVacuna turno = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                turno = new TurnoVacuna();
                operacionLog = "ALTA";
                // cargar la info de la paciente antes de dar de alta.
            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                turno = _turno_modif;
                detalleLog = "OBJ-Antes:" + TurnoLog + " - OBJ-MOD";
            }
            if (VerificarCamposObligatorios())
            {
                // SET CAMPOS DE LOS CONTROLES A LOS ATRIBUTOS
                turno.NroDocPaciente = Convert.ToInt32(NroDocPacienteTxt.Text);
                turno.Asistio = AsistioChk.Checked;
                turno.NroDosis = Convert.ToInt32(Dosistxt.Value);
                turno.CodCentroAtencion = Convert.ToInt32((CentroAtencionCbo.SelectedItem as CentroAtencion).Id);
                turno.NroDocEnfermero = Convert.ToInt32((EnfermoCbo.SelectedItem as Enfermero).NroDocumento);
                turno.CodVacuna = Convert.ToInt32((VacunaCbo.SelectedItem as Vacuna).Id);
                
                int hora = Convert.ToInt32(Horatxt.Value);
                int minuto = Convert.ToInt32(minutotxt.Value);
                DateTime horario = new DateTime(2001,1,1, hora, minuto, 0);
                turno.Hora = Convert.ToDateTime((horario));

                int anioTurno = FechaTurnoDtp.Value.Year;
                int mesTurno = FechaTurnoDtp.Value.Month;
                int diaTurno = FechaTurnoDtp.Value.Day;
                DateTime fechaTurno = new DateTime(anioTurno, mesTurno, diaTurno);

                turno.Fecha = fechaTurno;



                detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(turno);
                // intentar guardar en la Base de datos.
                try
                {
                    turno.SaveObj();
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
                        DoCompleteOperationForm(turno, new EventArgDom { ObjProcess = turno, Status = TipoOperacionStatus.stOK });
                    else
                        DoCompleteOperationForm(turno, new EventArgDom { ObjProcess = turno, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
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

        
        private bool VerificarCamposObligatorios()
        {

            if (NroDocPacienteTxt.Text.Trim() != string.Empty)
            {
                if (LocalidadCbo.Text.Trim() != string.Empty)
                {
                    if (CentroAtencionCbo.Text.Trim() != string.Empty)
                    {
                        if (EnfermoCbo.Text.Trim() != string.Empty)
                        {
                            if (DateTime.Now < FechaTurnoDtp.Value)
                            {
                                if (VacunaCbo.Text.Trim() != string.Empty)
                                {
                                    if (Dosistxt.Value != 0)
                                    {
                                        if ((minutotxt.Value == 0) || (minutotxt.Value == 20) || (minutotxt.Value == 40))
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El numero de Dosis no puede ser 0", "Error: numero incorrecto...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo de Vacuna es obligatorio y esta vacio\n\nPor favor ingrese una Vacuna", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo de Fecha esta incorrecto\n\nPor favor ingrese una fecha valida", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("El campo de Enfermero es obligatorio y esta vacio\n\n Por favor ingrese el Enfermero que vacunara al paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo de Centro de Atencion es obligatorio y esta vacio\n\n Por favor ingrese el Centro de Atencion donde sera vacunado el paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo de Localidad es obligatorio y esta vacio\n\n Por favor ingrese La localidad donde sera vacunado el paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El Dni es obligatorio y esta vacio\n\n Por favor ingrese el DNI del paciente", "Campo obligatorio vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmTurnoAM_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default; 
        }

        private void FrmTurnoAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default; 
        }

        private void VacunaCbo_Click(object sender, EventArgs e)
        {
            if (VacunaCbo.Text == string.Empty)
            {
                this.VacunaCbo.DataSource = Vacuna.FindAllStatic(null, (e1, e2) => (e1.Lote).CompareTo(e2.Lote));
                this.VacunaCbo.SelectedIndex = -1;
                this.VacunaCbo.ToString();
            }
        }

        private void LocalidadCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((LocalidadCbo.Text.Trim() != string.Empty) && this.LocalidadCbo.SelectedIndex != -1)
            {
                errorProvider1.SetError(this.LocalidadCbo, "");

                string filtro = String.Format("cod_postal = {0}", (LocalidadCbo.SelectedItem as Localidad).Id);

                this.CentroAtencionCbo.DataSource = CentroAtencion.FindAllStatic(filtro, (ca1, ca2) => ca1.Nombre.CompareTo(ca2.Nombre));
                this.CentroAtencionCbo.SelectedIndex = -1;
                this.CentroAtencionCbo.Enabled = true;
            }
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (NroDocPacienteTxt.Text == string.Empty)
            {
                errorProvider1.SetError(this.NroDocPacienteTxt, "Error: Tiene que llenar este campo para poder continuar con el registro");
            }
            else
            {
                if ((LocalidadCbo.Text.Trim() == string.Empty) && this.LocalidadCbo.SelectedIndex == -1)
                {
                    errorProvider1.SetError(this.LocalidadCbo, "Error: Tiene que llenar este campo para poder continuar con el registro");
                }
                else
                {
                    if ((CentroAtencionCbo.Text.Trim() != string.Empty) && this.CentroAtencionCbo.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(this.CentroAtencionCbo, "Error: Tiene que llenar este campo para poder continuar con el registro");
                    }
                    else
                    {
                        if ((EnfermoCbo.Text.Trim() != string.Empty) && this.EnfermoCbo.SelectedIndex == -1)
                        {
                            errorProvider1.SetError(this.EnfermoCbo, "Error: Tiene que llenar este campo para poder continuar con el registro");
                        }
                        else
                        {
                            if ((VacunaCbo.Text.Trim() != string.Empty) && this.VacunaCbo.SelectedIndex == -1)
                            {
                                errorProvider1.SetError(this.VacunaCbo, "Error: Tiene que llenar este campo para poder continuar con el registro");
                            }
                        }
                    }
                }

            }
        }

        private void NroDocPacienteTxt_TextChanged(object sender, EventArgs e)
        {
            if (NroDocPacienteTxt.Text != string.Empty)
            {
                errorProvider1.SetError(this.NroDocPacienteTxt, "");
                this.LocalidadCbo.Enabled = true;
            }
            else
            {
                VerificarCamposObligatorios();
            }
        }

        private void FechaTurnoDtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = FechaTurnoDtp.Value;

            //si es menor
            if (DateTime.Now < fecha) 
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday)
                {
                    errorProvider1.SetError(FechaTurnoDtp, "");
                    
                    this.VacunaCbo.DataSource = Vacuna.FindAllStatic(null, (v1, v2) => v1.CodTipoVacuna + v1.Cantidad.CompareTo(v2.CodTipoVacuna + v2.Cantidad));
                    this.VacunaCbo.SelectedIndex = -1;
                    this.VacunaCbo.Enabled = true;
                }
                else
                {
                    errorProvider1.SetError(FechaTurnoDtp, "Error: El turno no puede ser un dia domingo");
                    this.GuardarBtn.Enabled = false;
                }
            }
            else
            {
                errorProvider1.SetError(FechaTurnoDtp, "La fecha tiene que ser mayor que el año actual");
                this.GuardarBtn.Enabled = false;
            }
            FechaTurnoDtp.Focus();
        }

        private void CentroAtencionCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CentroAtencionCbo.Text.Trim() != string.Empty) && this.CentroAtencionCbo.SelectedIndex != -1)
            {
                errorProvider1.SetError(this.CentroAtencionCbo, "");

                string filtro = String.Format("cod_centro_a = {0}", (CentroAtencionCbo.SelectedItem as CentroAtencion).Id);

                this.EnfermoCbo.DataSource = Enfermero.FindAllStatic(filtro, (ca1, ca2) => (ca1.Apellido.CompareTo(ca2.Apellido)));
                this.EnfermoCbo.SelectedIndex = -1;
                this.EnfermoCbo.Enabled = true;
            }
            else
            {
                this.GuardarBtn.Enabled = false;
            }
        
        }

        private void EnfermoCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((EnfermoCbo.Text.Trim() != string.Empty) && this.EnfermoCbo.SelectedIndex != -1)
            {
                errorProvider1.SetError(this.EnfermoCbo, "");
                this.FechaTurnoDtp.Enabled = true;
            }
            else
            {
                this.GuardarBtn.Enabled = false;
            }
        }

        private void VacunaCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VacunaCbo.Text.Trim() != string.Empty) && this.VacunaCbo.SelectedIndex != -1)
            {
                errorProvider1.SetError(this.VacunaCbo, "");
                this.Dosistxt.Enabled = true;
                this.AsistioChk.Enabled = true;
            }
            else
            {
                this.GuardarBtn.Enabled = false;
            }
        }

        private void minutotxt_ValueChanged(object sender, EventArgs e)
        {
            if ((minutotxt.Value == 0) || (minutotxt.Value == 20) || (minutotxt.Value == 40))
            {
                this.GuardarBtn.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(horaslbl, "los minutos tienen que ser: 0, 20 o 40");
                this.GuardarBtn.Enabled = false;
            }
        }

        private void Dosistxt_ValueChanged(object sender, EventArgs e)
        {
            this.Horatxt.Enabled = true;
            this.minutotxt.Enabled = true;
            this.GuardarBtn.Enabled = true;
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
                        sw.Write("|Modificacion de un Turno");
                    }
                    else
                    {
                        sw.Write("|Alta de un Turno");
                    }
                    sw.Write("|Fecha: {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    sw.Write("|Hora: {0}\n", DateTime.Now.ToString("hh:mm:ss"));
                }
                sw.Close();
            }
        }
    }
}
           
