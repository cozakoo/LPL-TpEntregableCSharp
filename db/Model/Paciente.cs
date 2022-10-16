using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medicApp.db
{
    [Table(Name = "pacientes")]
    public partial class Paciente
    {
        #region variables locales
        private int _nroDocumento;
        private DateTime _fecha_nac;
        private string _apellido;
        private string _nombres;
        private string _domicilio;
        private string _telefono;
        private int _cod_postal;
        private bool _de_riesgo;
        private bool _vacunado;
        private string _observaciones;
        // usado para relacion con la clase Localidad, carga Lazy
        private Localidad _localidad = null;        
        #endregion        

        #region propiedades publicas

        [Propiedad(Name = "nro_documento", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int NroDocumento
        {
            get { return _nroDocumento; }
            set { _nroDocumento = value; }
        }
        
        [Propiedad(Name = "fecha_nac", Tipo = typeof(DateTime), Format="yyyy-MM-dd")]
        public DateTime FechaNac
        {
            get { return _fecha_nac; }
            set { _fecha_nac = value; }
        }

        [Propiedad(Name = "apellido", Tipo = typeof(string), Longitud = 50)]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        [Propiedad(Name = "nombres", Tipo = typeof(string), Longitud = 90)]
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        [Propiedad(Name = "domicilio", Tipo = typeof(string), Longitud = 120)]
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio= value; }
        }

        [Propiedad(Name = "telefono", Tipo = typeof(string), Longitud = 20)]        
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        
        [Propiedad(Name = "cod_postal", Tipo = typeof(int))]
        public int CodPostal
        {
            get { return _cod_postal; }
            set {
                if (value != _cod_postal && value > 0)
                    this._localidad = null;
                _cod_postal = value;
            }
        }

        [Propiedad(Name = "de_riesgo", Tipo = typeof(bool))]
        public bool DeRiesgo
        {
            get { return _de_riesgo; }
            set { _de_riesgo = value; }
        }

        [Propiedad(Name = "vacunado", Tipo = typeof(bool))]
        public bool Vacunado
        {
            get { return _vacunado; }
            set { _vacunado = value; }
        }

        [Propiedad(Name = "observaciones", Tipo = typeof(string), Longitud = 250)]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        #endregion  

        #region Relaciones con otras entidades
        public Localidad LocalidadPaciente
        {
            get
            {
                if (_localidad == null && this._cod_postal != 0)
                {
                    _localidad = new Localidad();
                    _localidad = Localidad.FindByKeyStatic(this._cod_postal);
                }
                return _localidad;
            }
            set { _localidad = value; }
        }        
        
        // implementar para obtener listado de turnos asignados

        #endregion


    }
}
