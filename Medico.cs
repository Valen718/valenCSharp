using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_C_
{
    class Medico : Persona
    {
        private enum _especializacion
        {
            cirujano,
            cardiologo
        }
        private _especializacion especializacion;

        public Medico(string nombre, string dni) : base(nombre, dni)
        {
            especializacion = _especializacion.cardiologo;
        }

        public override string ToString()
        {
            return $"Nombre del medico: {nombre}, dni: {dni}, especialidad: {especializacion}";
        }
    }
}
