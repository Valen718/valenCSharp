using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_C_
{
    class Paciente : Persona
    {
        private string _historiaclinica;
        private List<string> _turnos;

        public string historialclinico
        {
            get { return _historiaclinica; }
            set {  _historiaclinica = value; }
        }

        public Paciente(string nombre, string dni, string historiaclinica, List<string> turnos)
        {
            this.nombre = nombre;
            this.dni = dni;
            this._historiaclinica = historiaclinica;
            this._turnos = turnos ?? new List<string>();
        }

        public void AgregarTurnos(string turno)
        {
            _turnos.Add(turno);
        }
        public void EliminarTurnos(string turno)
        {
            _turnos.Remove(turno);
        }

        public void ConsultarTurnos()
        {
            Console.WriteLine("Turnos:");
            foreach(string turnos in _turnos)
            {
                Console.WriteLine($" - {turnos}");
            }
        }

        public override string ToString()
        {
            string turnosString = string.Join(", ", _turnos);
            return $"Nombre del paciente: {nombre}, dni: {dni}, Historia clinica: {historialclinico}, Turnos: {turnosString}";
        }
    }
}
