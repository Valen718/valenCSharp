using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using prueba_C_;

namespace prueba_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Clase medico:
            var medico = new Medico("Valentin", "44957077");
            Console.WriteLine(medico);


            //lista turnos de la clase Paciente:
            List<string> turnos = new List<string>() { "Lunes", "Miercoles"};
            var paciente = new Paciente("Juan", "44957022", "2", turnos);
            paciente.AgregarTurnos("Viernes");
            paciente.EliminarTurnos("Miercoles");
            paciente.ConsultarTurnos();
            Console.WriteLine(paciente.ToString());

            //Clase Turnos:
            var turno = new Turno("777", DateTime.Now, medico, true);
            Console.WriteLine(turno.ToString());

            Console.ReadKey();
        }
    }
}
