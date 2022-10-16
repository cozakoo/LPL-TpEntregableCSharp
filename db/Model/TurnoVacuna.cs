using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace medicApp.db
{
    [Table(Name = "turno_vacuna")]
    public partial class TurnoVacuna
    {
        #region variables locales
        private int _codigo;
        private int _codCentroAtencion;
        private int _nroDocEnfermero;
        private int _nroDocPaciente;
        private int _codVacuna;
        private int _nroDosis;
        private bool _asistio;
        private DateTime _fecha;
        private DateTime _hora;
        private Paciente _paciente = null;
        private Enfermero _enfermero = null;
        private CentroAtencion _centroAtencion = null;
        private Vacuna _vacuna = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "cod_centro_a", Tipo = typeof(int))]
        public int CodCentroAtencion
        {
            get { return _codCentroAtencion; }
            set { _codCentroAtencion = value; }
        }

        [Propiedad(Name = "nro_doc_enfermero", Tipo = typeof(int))]
        public int NroDocEnfermero
        {
            get { return _nroDocEnfermero; }
            set { _nroDocEnfermero = value; }
        }

        [Propiedad(Name = "nro_doc_paciente", Tipo = typeof(int))]
        public int NroDocPaciente
        {
            get { return _nroDocPaciente; }
            set { _nroDocPaciente = value; }
        }

        [Propiedad(Name = "fecha", Tipo = typeof(DateTime), Format = "yyyy-MM-dd")]
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        [Propiedad(Name = "hora", Tipo = typeof(DateTime), Format = "HH:mm:ss")]
        public DateTime Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        [Propiedad(Name = "asistio", Tipo = typeof(bool))]
        public bool Asistio
        {
            get { return _asistio; }
            set { _asistio = value; }
        }

        [Propiedad(Name = "nro_dosis", Tipo = typeof(int))]
        public int NroDosis
        {
            get { return _nroDosis; }
            set { _nroDosis = value; }
        }

        [Propiedad(Name = "cod_vacuna", Tipo = typeof(int))]
        public int CodVacuna
        {
            get { return _codVacuna; }
            set { _codVacuna = value; }
        }

        #endregion  
        
        #region Relaciones con otras entidades

        public CentroAtencion CentroAtencionTurnoVacuna
        {
            get
            {
                if (_centroAtencion == null && this._codCentroAtencion != 0)
                {
                    _centroAtencion = new CentroAtencion();
                    _centroAtencion = CentroAtencion.FindByKeyStatic(this._codCentroAtencion);
                }
                return _centroAtencion;
            }
            set { _centroAtencion = value; } 
        }

        public Paciente PacienteTurnoVacuna
        {
            get
            {
                if (_paciente == null && this._nroDocPaciente != 0)
                {
                    _paciente = new Paciente();
                    _paciente = Paciente.FindByKeyStatic(this._nroDocPaciente);

                    if (_paciente == null)
                    {
                        return null;
                    }
                }
                return _paciente;
            }
            set { _paciente = value; }
        }

        public Enfermero EnfermeroTurnoVacuna
        {
            get
            {
                if (_enfermero == null && this._nroDocEnfermero != 0)
                {
                    _enfermero = new Enfermero();
                    _enfermero = Enfermero.FindByKeyStatic(this._nroDocEnfermero);
                }
                return _enfermero;
            }
            set { _enfermero = value; }
        }

        public Vacuna VacunaTurnoVacuna
        {
            get
            {
                if (_vacuna == null && this._codVacuna != 0)
                {
                    _vacuna = new Vacuna();
                    _vacuna = Vacuna.FindByKeyStatic(this._codVacuna);
                }
                return _vacuna;
            }
            set { _vacuna = value; }
        }
        #endregion
    }
}
