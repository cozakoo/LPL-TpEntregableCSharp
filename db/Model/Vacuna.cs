using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace medicApp.db
{
    [Table(Name = "vacunas")]
    public partial class Vacuna
    {
        #region variables locales
        private int _codigo;
        private string _lote;
        private float _cantidad;
        private int _cod_tipo_vacuna;
        private DateTime _fechaVenc;
        private TipoVacuna _tipo_vacunaObj = null;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "lote", Tipo = typeof(string), Longitud = 10)]
        public string Lote
        {
            get { return _lote; }
            set { _lote = value; }
        }

        [Propiedad(Name = "cantidad", Tipo = typeof(float))]
        public float Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        [Propiedad(Name = "fecha_venc", Tipo = typeof(DateTime))]
        public DateTime FechaVenc
        {
            get { return _fechaVenc; }
            set { _fechaVenc = value; }
        }

        [Propiedad(Name = "cod_tipo_vacuna", Tipo = typeof(float))]
        public int CodTipoVacuna
        {
            get { return _cod_tipo_vacuna; }
            set { _cod_tipo_vacuna = value; }
        }
        #endregion

        #region Relaciones con otras entidades

        public TipoVacuna TipoVacunaVacuna
        {
            get
            {
                if (_tipo_vacunaObj == null && this._cod_tipo_vacuna != 0)
                {
                    _tipo_vacunaObj = new TipoVacuna();
                    _tipo_vacunaObj = TipoVacuna.FindByKeyStatic(this._cod_tipo_vacuna);
                }
                return _tipo_vacunaObj;
            }
            set { _tipo_vacunaObj = value; }
        }

        #endregion

        public override string ToString()
        {
            return TipoVacunaVacuna.Nombre + " Lote: " + _lote;
        }
    }
}
