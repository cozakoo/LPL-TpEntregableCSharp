using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace medicApp.db
{
    [Table(Name = "tipo_vacuna")]
    public partial class TipoVacuna
    {
        #region variables locales
        private int _codigo;
        private string _nombre;
        private int _cant_dosis;
        #endregion

        #region propiedades publicas

        [Propiedad(Name = "codigo", Tipo = typeof(int), EsAutoGenerado = true, EsClave = true)]
        public int Id
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        [Propiedad(Name = "nombre", Tipo = typeof(string), Longitud = 90)]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Propiedad(Name = "cant_dosis", Tipo = typeof(int))]
        public int CantDosis
        {
            get { return _cant_dosis; }
            set { _cant_dosis = value; }
        }

        #endregion
    }

}
