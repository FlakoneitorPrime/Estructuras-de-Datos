using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class ClaseNodo<Alumno>
    {
        // Atributos privados
        private Alumno _objAlumno;
        private ClaseNodo<Alumno> _siguiente;

        // Propiedades públicas
        public Alumno Dato
        {
            get { return _objAlumno; }
            set { _objAlumno = value; }
        }

        public ClaseNodo<Alumno> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        // Constructor
        public ClaseNodo(Alumno valor)
        {
            _objAlumno = valor;
            _siguiente = null;
        }
    }
}
