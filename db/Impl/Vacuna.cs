using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;

namespace medicApp.db
{
    public partial class Vacuna : BaseClass, IAccessDB<Vacuna>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionVacunaGuardar;
        public List<Vacuna> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Vacuna> FindAll(string criterio)
        {
            return ORMDB<Vacuna>.FindAll(criterio);
        }
        public Vacuna FindbyKey(params object[] key)
        {
            var vac = ORMDB<Vacuna>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = vac.Id;
            this.Lote = vac.Lote;
            this.Cantidad = vac.Cantidad;
            this.CodTipoVacuna = vac.CodTipoVacuna;
            this.FechaVenc = vac.FechaVenc;            
            this.SetIsObjFromDB();//marcar como que se recupero desde la base.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionVacunaGuardar != null)
                {
                }
            }
            return ORMDB<Vacuna>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Vacuna
        public static List<Vacuna> FindAllStatic(string criterio, Comparison<Vacuna> compara)
        {
            var lista = ORMDB<Vacuna>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Vacuna FindByKeyStatic(int key)
        {
            return ORMDB<Vacuna>.FindbyKey(key);
        }
    }
}
