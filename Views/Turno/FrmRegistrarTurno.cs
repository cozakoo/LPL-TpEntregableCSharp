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
    [Permiso(ClaseBaseForm = "Turno", FuncionPermiso = "AltaTurno,ModificaTurno,ConsultaTurno", RolUsuario = "administrador,operadorPaciente,operadorTurno,consulta,operador")]
    
    public partial class FrmRegistrarTurno : FormBase
    {
        public FrmRegistrarTurno()
        {
            InitializeComponent();
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.ConsultarBtn.Enabled = perm.HasAddPerm || perm.HasAddPerm;

                if (!this.ConsultarBtn.Enabled && perm.HasViewPerm)
                {
                    this.ConsultarBtn.Visible = true;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
            
        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ShowRegistrar()
        {
            MainView.Instance.Cursor = Cursors.Default;
            this.ConsultarBtn.Enabled = true;
            this.Show();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;

            string criterio = null;
            bool salir = false;

            if (this.NroDoctxt.Text != String.Empty)
            {
                if (criterio == null)
                {
                    criterio = String.Format("nro_doc_paciente = {0}", this.NroDoctxt.Text);
                }
                else
                {
                    criterio += String.Format("and nro_doc_paciente = {0}", this.NroDoctxt.Text);
                }
            }
            else
            {
                MessageBox.Show("El numero de DOCUMENTO esta vacio\nPor favor ingrese el DOCUMENTO ", "Campo vacio...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salir = true;
            }
            
            if (!salir)
            {
                try
                {
                    List<TurnoVacuna> lista = TurnoVacuna.FindAllStatic(criterio, (p1, p2) => (p1.Fecha).CompareTo(p2.Fecha));
                    MainView.Instance.Cursor = Cursors.Default;

                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No se encontro al paciente", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        TurnoVacuna turnoAux = lista[lista.Count - 1];
                        string errMsj = "";
                        turnoAux.Asistio = true;
                        try
                        {
                            turnoAux.SaveObj();
                            MessageBox.Show("PACIENTE REGISTRADO CON EXITO!!!", "Listado de turno creado...", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        catch (Exception ex)
                        {
                            errMsj = "Error: " + ex.Message;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmRegistrarTurno_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }

        private void FrmRegistrarTurno_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;  
        }
    }
}
