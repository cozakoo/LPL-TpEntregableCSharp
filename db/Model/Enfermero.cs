using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace medicApp.db
{
    [Table(Name = "enfermeros")]
    public partial class Enfermero
    {
        #region variables locales
        private int _id;
        private string _matricula;
        private int _dni;
        private string _apellido;
        private string _nombres;
        private string _domicilio;
        private string _telefono;
        private int _cod_postal;
        private int _cod_cento_atencion;        
        // usado para relacion con la clase Localidad, carga Lazy
        private Localidad _localidad = null;
        private CentroAtencion _centroAtencion = null;
        
        #endregion        

        #region propiedades publicas

        [Propiedad(Name = "nro_documento", Tipo = typeof(int), EsAutoGenerado = false, EsClave = true)]
        public int NroDocumento
        {
            get { return _id; }
            set { _id = value; }
        }

        [Propiedad(Name = "matricula", Tipo = typeof(string), Longitud = 20)]
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
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

        [Propiedad(Name = "domicilio", Tipo = typeof(string), Longitud = 20)]
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
            set { _cod_postal = value; }
        }

        [Propiedad(Name = "cod_centro_a", Tipo = typeof(int))]
        public int CodCentroAtencion
        {
            get { return _cod_cento_atencion; }
            set { _cod_cento_atencion = value; }
        }
       
        #endregion  

        #region Relaciones con otras entidades
        public Localidad LocalidadEnfermero
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

        public CentroAtencion CentroAtencionEnfermero
        {
            get
            {
                if (_centroAtencion == null && this._cod_cento_atencion != 0)
                {
                    _centroAtencion = new CentroAtencion();
                    _centroAtencion = CentroAtencion.FindByKeyStatic(this._cod_cento_atencion);
                }
                return _centroAtencion;
            }
            set { _centroAtencion = value; }
        }
        #endregion

        public override string ToString()
        {
            return Nombres + " " + Apellido;
        }
    }
}
