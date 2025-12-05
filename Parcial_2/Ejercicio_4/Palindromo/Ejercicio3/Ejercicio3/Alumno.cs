using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Alumno
    {
        // Atributos privados
        private string _strNombre;
        private int _intEdad;
        private double _dblPromedio;

        // Propiedades públicas
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public int Edad
        {
            get { return _intEdad; }
            set
            {
                if (value >= 0)
                    _intEdad = value;
                else
                    _intEdad = 0;
            }
        }

        public double Promedio
        {
            get { return _dblPromedio; }
            set
            {
                if (value >= 0 && value <= 100)
                    _dblPromedio = value;
                else
                    _dblPromedio = 0;
            }
        }

        // Constructor
        public Alumno(string nombre, int edad, double promedio)
        {
            _strNombre = nombre;
            _intEdad = edad;
            _dblPromedio = promedio;
        }

        public override string ToString()
        {
            return $"Nombre: {_strNombre}, Edad: {_intEdad}, Promedio: {_dblPromedio}";
        }
    }
}
