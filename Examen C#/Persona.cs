using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_C_
{
    abstract class Persona
    {
        private string _nombre;
        private string _dni;
        
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public Persona() //Constructor
        {
            this._nombre = string.Empty;
            this._dni = string.Empty;
        }

        public Persona(string nombre, string dni)
        {
            this._nombre = nombre;
            this._dni = dni;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, dni: {dni}";
        }

    }
}
