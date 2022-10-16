using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;
using System.Windows.Forms;
using medicApp.Views;

namespace medicApp.db
{
    public partial class TurnoVacuna : BaseClass, IAccessDB<TurnoVacuna>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTurnoGuardar;
        public List<TurnoVacuna> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TurnoVacuna> FindAll(string criterio)
        {
            return ORMDB<TurnoVacuna>.FindAll(criterio);
        }
        public TurnoVacuna FindbyKey(params object[] key)
        {
            var turno = ORMDB<TurnoVacuna>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Codigo = turno.Codigo;
            this.CodCentroAtencion = turno.CodCentroAtencion;
            this.NroDocPaciente = turno.NroDocPaciente;
            this.NroDocEnfermero = turno.NroDocEnfermero;            
            this.Fecha = turno.Fecha;
            this.Hora = turno.Hora;
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool SaveObj()
        {
            List<TurnoVacuna> turnoVacuna = new List<TurnoVacuna>();
            string fitroTurno;

            if (this.IsNew)
            {
                if (this._paciente == null)
                {
                    DialogResult result = MessageBox.Show("EL PACIENTE NO EXISTE EN EL SISTEMA\n¿Desea registrarlo en el sistema?", "Error: paciente no existe..", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        MainView.Instance.Cursor = Cursors.WaitCursor;
                        FrmPacienteAM frm = new FrmPacienteAM();
                        frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                        frm.ShowIngresoPaciente();
                    }

                    //si es paciente nuevo si o si tiene que ser la primera dosis
                    if (this._nroDosis != 1)
                    {
                        throw new Exception("Error: El paciente se tiene que registrar con la primera dosis");
                    }

                }
                else
                {
                    //si ya existe el paciente en el sistema
                    fitroTurno = String.Format("nro_doc_paciente = {0} and fecha >= '{1}' and asistio = {2}", this.NroDocPaciente, DateTime.Now.ToString("yyyy-MM-dd"), false);
                    turnoVacuna = TurnoVacuna.FindAllStatic(fitroTurno, (t1, t2) => t1.Codigo.CompareTo(t2.Codigo));

                    //no tiene turnos pendientes
                    if (turnoVacuna.Count == 0)
                    {
                        fitroTurno = String.Format(" and nro_dosis >= {0}", this.NroDosis);

                        if (turnoVacuna.Count > 0)
                        {
                            throw new Exception("Error: EL PACIENTE TIENE YA ESTA REGISTRADO CON ESTA DOSIS");
                        }
                    }
                    else
                    {
                        throw new Exception("Error: El paciente tiene turnos pendientes");
                    }
                }

                //VERIFICO LA DISPONIBILIDAD PARA EL LA FECHA DEL TURNO
                fitroTurno = String.Format("fecha = '{0}'", this.Fecha.ToString("yyyy-MM-dd"));
                
                turnoVacuna = TurnoVacuna.FindAllStatic(fitroTurno, (t1, t2) => t1.Codigo.CompareTo(t2.Codigo));

                //saber si hay menos de 72 turnos para ese dia  - LISTO
                if (turnoVacuna.Count < 72)
                {
                    //saber si el enfermero tiene asignado mas de 24 turnos 
                    fitroTurno += String.Format(" and nro_doc_enfermero = {0}", this.NroDocEnfermero);
                    turnoVacuna = TurnoVacuna.FindAllStatic(fitroTurno, (t1, t2) => t1.Codigo.CompareTo(t2.Codigo));

                    if (turnoVacuna.Count < 24)
                    {
                        //saber si ese enfermero ya tiene asignada la hora
                        fitroTurno += String.Format(" and hora = '{0}'", this.Hora.ToString("hh:mm:ss"));// this.Hora.Hour, this.Hora.Minute, 00);// ToShortTimeString());
                        turnoVacuna = TurnoVacuna.FindAllStatic(fitroTurno, (t1, t2) => t1.Codigo.CompareTo(t2.Codigo));

                        //no hay turnos previos
                        if (turnoVacuna.Count > 0)
                        {
                            throw new Exception("Error: El enfermero ya tiene  los turnos llenos para ese dia");
                        }
                    }
                    else
                    {
                        throw new Exception("Error: Los turnos del enfermero estan llenos para ese dia");
                    }
                }
                else
                {
                    throw new Exception("Error: Los turnos estan llenos para ese dia");
                }
            }
            return ORMDB<TurnoVacuna>.SaveObject(this);
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente ", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TurnoVacuna
        public static List<TurnoVacuna> FindAllStatic(string criterio, Comparison<TurnoVacuna> compara)
        {
            var lista = ORMDB<TurnoVacuna>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static TurnoVacuna FindByKeyStatic(int key)
        {
            return ORMDB<TurnoVacuna>.FindbyKey(key);
        }
    }
}
