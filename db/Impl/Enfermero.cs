using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;

namespace medicApp.db
{
    public partial class Enfermero : BaseClass, IAccessDB<Enfermero>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionEnfermeroGuardar;
        public List<Enfermero> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Enfermero> FindAll(string criterio)
        {
            return ORMDB<Enfermero>.FindAll(criterio);
        }
        public Enfermero FindbyKey(params object[] key)
        {
            var prof = ORMDB<Enfermero>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = prof.NroDocumento;
            this.Matricula = prof.Matricula;            
            this.Apellido = prof.Apellido;
            this.Nombres = prof.Nombres;
            this.Domicilio = prof.Domicilio;
            this.Telefono = prof.Telefono;
            this.CodPostal = prof.CodPostal;
            this.SetIsObjFromDB();
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionEnfermeroGuardar != null)
                {
                    // validar mas de un campo significativo antes de guardar....
                    if (NroDocumento == 0)
                        ValidacionEnfermeroGuardar("No se puede poner NroDocumento cero");
                }
            }
            return ORMDB<Enfermero>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Enfermero
        public static List<Enfermero> FindAllStatic(string criterio, Comparison<Enfermero> compara)
        {
            var lista = ORMDB<Enfermero>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Enfermero FindByKeyStatic(int key)
        {
            return ORMDB<Enfermero>.FindbyKey(key);
        }


    }
}
