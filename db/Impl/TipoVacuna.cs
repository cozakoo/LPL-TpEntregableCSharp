using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;

namespace medicApp.db
{
    public partial class TipoVacuna : BaseClass, IAccessDB<TipoVacuna>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionTipoVacunaGuardar;
        public List<TipoVacuna> FindAll()
        {
            return this.FindAll(null);
        }
        public List<TipoVacuna> FindAll(string criterio)
        {
            return ORMDB<TipoVacuna>.FindAll(criterio);
        }
        public TipoVacuna FindbyKey(params object[] key)
        {
            var tvac = ORMDB<TipoVacuna>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = tvac.Id;
            this.Nombre = tvac.Nombre;
            this.CantDosis = tvac.CantDosis;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionTipoVacunaGuardar != null)
                {
                    if (Nombre == "")
                        ValidacionTipoVacunaGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<TipoVacuna>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-TipoVacuna
        public static List<TipoVacuna> FindAllStatic(string criterio, Comparison<TipoVacuna> compara)
        {
            var lista = ORMDB<TipoVacuna>.FindAll(criterio);
            if(compara!=null)
                lista.Sort(compara);
            return lista;
        }

        public static TipoVacuna FindByKeyStatic(int key)
        {
            return ORMDB<TipoVacuna>.FindbyKey(key);
        }
    }
}
