using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;

namespace medicApp.db
{
    public partial class Localidad : BaseClass, IAccessDB<Localidad>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionLocalidadGuardar;
        public List<Localidad> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Localidad> FindAll(string criterio)
        {
            return ORMDB<Localidad>.FindAll(criterio); 
        }
        public Localidad FindbyKey(params object[] key)
        {
            var loc = ORMDB<Localidad>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.Id = loc.Id;
            this.Nombre = loc.Nombre;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionLocalidadGuardar != null)
                {
                    if(Nombre == "" )
                        ValidacionLocalidadGuardar("No se puede poner Nombre vacio");
                }
            }
            return ORMDB<Localidad>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Localidad
        public static List<Localidad> FindAllStatic(string criterio, Comparison<Localidad> compara)
        {
            var lista = ORMDB<Localidad>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Localidad FindByKeyStatic(int key)
        {
            return ORMDB<Localidad>.FindbyKey(key);
        }
    }
}
