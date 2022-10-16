using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using medicApp.db.orm;

namespace medicApp.db
{
    public partial class Paciente : BaseClass, IAccessDB<Paciente>
    {  // HACER VERIFICACIONES ANTES DE REALIZAR OPERACIONES DE ACTUALIZACION, LANZAR EVENTO O EXCEPCION
        public event ValidarClaseDelegate ValidacionPacienteGuardar;
        public List<Paciente> FindAll()
        {
            return this.FindAll(null);
        }
        public List<Paciente> FindAll(string criterio)
        {
            return ORMDB<Paciente>.FindAll(criterio);
        }
        public Paciente FindbyKey(params object[] key)
        {
            var pac = ORMDB<Paciente>.FindbyKey(key);
            // completar datos en this para dejarlo inicializado
            this.NroDocumento = pac.NroDocumento;            
            this.FechaNac = pac.FechaNac;            
            this.Apellido = pac.Apellido;
            this.Nombres = pac.Nombres;
            this.Domicilio = pac.Domicilio;
            this.Telefono = pac.Telefono;
            this.CodPostal = pac.CodPostal;
            this.DeRiesgo = pac.DeRiesgo;
            this.Vacunado = pac.Vacunado;
            this.Observaciones = pac.Observaciones;
            this.SetIsObjFromDB();// marcar la lectura desde la Base de datos.
            return this;
        }
        public bool SaveObj()
        {
            if (!this.IsNew)
            {
                if (this.ValidacionPacienteGuardar != null)
                {
                    if (NroDocumento == 0)
                        ValidacionPacienteGuardar("No se puede poner Dni cero");
                }
            }
            return ORMDB<Paciente>.SaveObject(this);
        }
        // Metodos estaticos para no usar una instancia para acceder a metodo FindAll-Paciente
        public static List<Paciente> FindAllStatic(string criterio, Comparison<Paciente> compara)
        {
            var lista = ORMDB<Paciente>.FindAll(criterio);
            if (compara != null)
                lista.Sort(compara);
            return lista;
        }

        public static Paciente FindByKeyStatic(int key)
        {
            return ORMDB<Paciente>.FindbyKey(key);
        }

        public int Edad()
        {
            DateTime now = DateTime.Today;
            int edad = DateTime.Today.Year - _fecha_nac.Year;

            if (DateTime.Today < _fecha_nac.AddYears(edad))
                return --edad;
            else
                return edad;
        }
    }
}