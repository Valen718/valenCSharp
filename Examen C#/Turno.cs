using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_C_
{
    class Turno
    {
        private string _codigoturno;
        private DateTime _fechahora;
        private Medico _medico;
        private bool _activo;


        public string codigoturno
        {
            get { return _codigoturno; }
            set { _codigoturno = value; }
        }
        public DateTime fechahora
        {
            get { return _fechahora; }
            set { _fechahora = value; }
        }
        public Medico medico
        {
            get { return _medico; }
            set { _medico = value; }
        }

        public Turno(string codigoturno, DateTime fechahora, Medico medico, bool activo)
        {
            this._codigoturno = codigoturno;
            this._fechahora = fechahora;
            this._medico = medico;
        }

        public bool CambiarEstado()
        {
            bool activo = true;

            bool valoranterior = activo;

            _activo = !_activo;

            return valoranterior;
        }

        public override string ToString()
        {
            return $"Codigo del turno: {codigoturno}, Fecha: {fechahora}, Nombre del medico: {medico.nombre}, Estado del turno: {CambiarEstado()}";
        }

    }
}
